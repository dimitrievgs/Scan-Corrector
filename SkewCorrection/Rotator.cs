//Copyright © Storm23, GPL3, 2015

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace SkewCorrectionNS
{
    public static class Rotator
    {
        public static Bitmap Rotate(Bitmap img1, double angle, bool CleanBefore, bool CleanAfter, int KnownXMargin, int KnownYMargin)
        {
            int W = img1.Width;
            int H = img1.Height;
            Bitmap ImageForRotation;

            ImageForRotation = CleanMarginsBeforeRotation(CleanBefore, img1, KnownXMargin, KnownYMargin);

            img1 = null;

            var rotated = new Bitmap(W, H);
            using (var gr = Graphics.FromImage(rotated))
            {
                gr.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, W, H));
                //иначе получим черный фон
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.TranslateTransform(W / 2, H / 2);
                gr.RotateTransform(-(float)angle);
                gr.DrawImage(ImageForRotation, -W / 2, -H / 2, W, H);

                if (CleanAfter == true)
                {
                    gr.ResetTransform();
                    gr.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, KnownXMargin, H));
                    gr.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, W, KnownYMargin));
                    gr.FillRectangle(new SolidBrush(Color.White), new Rectangle(W /*- 1*/ - KnownXMargin, 0, KnownXMargin, H));
                    gr.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, H /*- 1*/ - KnownYMargin, W, KnownYMargin));
                }
            }

            return rotated;
        }

        private static Bitmap CleanMarginsBeforeRotation(bool CleanBefore, Bitmap img1, int KnownXMargin, int KnownYMargin)
        {
            if (CleanBefore == true)
            {
                int W = img1.Width;
                int H = img1.Height;
                var rotated0 = new Bitmap(W, H);
                using (var gr = Graphics.FromImage(rotated0))
                {
                    gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    gr.TranslateTransform(W / 2, H / 2);
                    gr.DrawImage(img1, -W / 2, -H / 2, W, H);

                    gr.ResetTransform();
                    gr.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, KnownXMargin, H));
                    gr.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, W, KnownYMargin));
                    gr.FillRectangle(new SolidBrush(Color.White), new Rectangle(W /*- 1*/ - KnownXMargin, 0, KnownXMargin, H));
                    gr.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, H /*- 1*/ - KnownYMargin, W, KnownYMargin));
                }
                return rotated0;
            }
            else return img1;
        }

        public static Bitmap Translate(Bitmap img, int X, int Y)
        {
            var rotated = new Bitmap(img.Width, img.Height);
            using (var gr = Graphics.FromImage(rotated))
            {
                gr.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, img.Width, img.Height));
                //иначе получим черный фон
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.TranslateTransform(img.Width / 2 + X, img.Height / 2 + Y);
                //gr.RotateTransform(-(float)angle);
                gr.DrawImage(img, -img.Width / 2, -img.Height / 2, img.Width, img.Height);
            }

            return rotated;
        }

        public static Bitmap ChangeMargins(bool ChangeMargins, Bitmap Image, int stripCount, int MaxMarginGValue,
            int NewXrightMargin, int NewYbottomMargin)
        {
            if (ChangeMargins == true)
            {
                List<int> Margins = Compact.GetMargins(Image, stripCount, MaxMarginGValue);
                int Xshift = Margins[1] - NewXrightMargin;
                int Yshift = Margins[3] - NewYbottomMargin;

                return Rotator.Translate(Image, Xshift, Yshift);
            }
            else return Image;
        }

        public static Bitmap Sharpen(Bitmap image)
        {
            Bitmap sharpenImage = (Bitmap)image.Clone();

            int filterWidth = 3;
            int filterHeight = 3;
            int width = image.Width;
            int height = image.Height;

            // Create sharpening filter.
            double[,] filter = new double[filterWidth, filterHeight];
            filter[0, 0] = filter[0, 1] = filter[0, 2] = filter[1, 0] = filter[1, 2] = filter[2, 0] = filter[2, 1] = filter[2, 2] = -1;
            filter[1, 1] = 9;

            double factor = 1.0;
            double bias = 0.0;

            Color[,] result = new Color[image.Width, image.Height];

            // Lock image bits for read/write.
            BitmapData pbits = sharpenImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            // Declare an array to hold the bytes of the bitmap.
            int bytes = pbits.Stride * height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(pbits.Scan0, rgbValues, 0, bytes);

            int rgb;
            // Fill the color array with the new sharpened color values.
            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    double red = 0.0, green = 0.0, blue = 0.0;

                    for (int filterX = 0; filterX < filterWidth; filterX++)
                    {
                        for (int filterY = 0; filterY < filterHeight; filterY++)
                        {
                            int imageX = (x - filterWidth / 2 + filterX + width) % width;
                            int imageY = (y - filterHeight / 2 + filterY + height) % height;

                            rgb = imageY * pbits.Stride + 3 * imageX;

                            red += rgbValues[rgb + 2] * filter[filterX, filterY];
                            green += rgbValues[rgb + 1] * filter[filterX, filterY];
                            blue += rgbValues[rgb + 0] * filter[filterX, filterY];
                        }
                        int r = Math.Min(Math.Max((int)(factor * red + bias), 0), 255);
                        int g = Math.Min(Math.Max((int)(factor * green + bias), 0), 255);
                        int b = Math.Min(Math.Max((int)(factor * blue + bias), 0), 255);

                        result[x, y] = Color.FromArgb(r, g, b);
                    }
                }
            }

            // Update the image with the sharpened pixels.
            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    rgb = y * pbits.Stride + 3 * x;

                    rgbValues[rgb + 2] = result[x, y].R;
                    rgbValues[rgb + 1] = result[x, y].G;
                    rgbValues[rgb + 0] = result[x, y].B;
                }
            }

            // Copy the RGB values back to the bitmap.
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, pbits.Scan0, bytes);
            // Release image bits.
            sharpenImage.UnlockBits(pbits);

            return sharpenImage;
        }

        public static Bitmap MedianFilter(Bitmap Image, int Size)
        {
            System.Drawing.Bitmap TempBitmap = Image;
            System.Drawing.Bitmap NewBitmap = new System.Drawing.Bitmap(TempBitmap.Width, TempBitmap.Height);
            System.Drawing.Graphics NewGraphics = System.Drawing.Graphics.FromImage(NewBitmap);
            NewGraphics.DrawImage(TempBitmap, new System.Drawing.Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), new System.Drawing.Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), System.Drawing.GraphicsUnit.Pixel);
            NewGraphics.Dispose();
            System.Random TempRandom = new System.Random();
            int ApetureMin = -(Size / 2);
            int ApetureMax = (Size / 2);
            for (int x = 0; x < NewBitmap.Width; ++x)
            {
                for (int y = 0; y < NewBitmap.Height; ++y)
                {
                    List<int> RValues = new List<int>();
                    List<int> GValues = new List<int>();
                    List<int> BValues = new List<int>();
                    for (int x2 = ApetureMin; x2 < ApetureMax; ++x2)
                    {
                        int TempX = x + x2;
                        if (TempX >= 0 && TempX < NewBitmap.Width)
                        {
                            for (int y2 = ApetureMin; y2 < ApetureMax; ++y2)
                            {
                                int TempY = y + y2;
                                if (TempY >= 0 && TempY < NewBitmap.Height)
                                {
                                    Color TempColor = TempBitmap.GetPixel(TempX, TempY);
                                    RValues.Add(TempColor.R);
                                    GValues.Add(TempColor.G);
                                    BValues.Add(TempColor.B);
                                }
                            }
                        }
                    }
                    RValues.Sort();
                    GValues.Sort();
                    BValues.Sort();
                    Color MedianPixel = Color.FromArgb(RValues[RValues.Count / 2],
                        GValues[GValues.Count / 2],
                       BValues[BValues.Count / 2]);
                    NewBitmap.SetPixel(x, y, MedianPixel);
                }
            }
            return NewBitmap;
        }

        public static void MakeGray(Bitmap bmp)
        {
            // Задаём формат Пикселя.
            PixelFormat pxf = PixelFormat.Format24bppRgb;

            // Получаем данные картинки.
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            //Блокируем набор данных изображения в памяти
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, pxf);

            // Получаем адрес первой линии.
            IntPtr ptr = bmpData.Scan0;

            // Задаём массив из Byte и помещаем в него надор данных.
            // int numBytes = bmp.Width * bmp.Height * 3; 
            //На 3 умножаем - поскольку RGB цвет кодируется 3-мя байтами
            //Либо используем вместо Width - Stride
            int numBytes = bmpData.Stride * bmp.Height;
            int widthBytes = bmpData.Stride;
            byte[] rgbValues = new byte[numBytes];

            // Копируем значения в массив.
            Marshal.Copy(ptr, rgbValues, 0, numBytes);

            // Перебираем пикселы по 3 байта на каждый и меняем значения
            for (int counter = 0; counter < rgbValues.Length; counter += 3)
            {

                int value = rgbValues[counter] + rgbValues[counter + 1] + rgbValues[counter + 2];
                byte color_b = 0;

                color_b = Convert.ToByte(value / 3);


                rgbValues[counter] = color_b;
                rgbValues[counter + 1] = color_b;
                rgbValues[counter + 2] = color_b;

            }
            // Копируем набор данных обратно в изображение
            Marshal.Copy(rgbValues, 0, ptr, numBytes);

            // Разблокируем набор данных изображения в памяти.
            bmp.UnlockBits(bmpData);
        }
    }
}
