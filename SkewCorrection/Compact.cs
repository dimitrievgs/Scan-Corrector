//Copyright © Storm23, GPL3, 2015

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace SkewCorrectionNS
{
    [Serializable]
    public class Compact
    {
        public int[][] Strips { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }
        public float Scale { get; private set; }

        public int SourceHeight { get; private set; }
        public int SourceWidth { get; private set; }
        public bool IsVertical { get; private set; }

        public const int MaxHeight = 600;

        public Compact(Bitmap img, int stripCount, out int stripX1, out int stripX2, bool vert = false)
        {
            SourceHeight = img.Height;
            SourceWidth = img.Width;
            IsVertical = vert;


            Scale = SourceHeight > MaxHeight ? 1f * MaxHeight / SourceHeight : 1f;

            Height = (int)((IsVertical ? SourceWidth : SourceHeight) * Scale);
            Width = stripCount;

            var w = vert ? Height : Width;
            var h = vert ? Width : Height;

            using (var bmp = new Bitmap(w, h))
            using (var gr = Graphics.FromImage(bmp))
            {
                gr.InterpolationMode = InterpolationMode.Low;
                gr.DrawImage(img, 0, 0, w, h);

                using (var wr = new ImageWrapper(bmp, true))
                {
                    Strips = new int[Width][];
                    for (int x = 0; x < Strips.Length; x++)
                    {
                        var strip = Strips[x] = new int[Height];

                        if (vert)
                            for (int y = 0; y < strip.Length; y++) strip[y] = wr[y, x].G;
                        else
                            for (int y = 0; y < strip.Length; y++) strip[y] = wr[x, y].G;
                    }

                    //let's find strips best StripIndexes
                    List<double> StripLinesAverages = new List<double>();
                    for (int x = 0; x < Strips.Length; x++)
                    {
                        var strip = Strips[x];
                        StripLinesAverages.Add(strip.Average());
                    }

                    int Middle = Strips.Length / 2;
                    List<double> StripLinesAveragesSub1 = StripLinesAverages.GetRange(0, Middle);
                    List<double> StripLinesAveragesSub2 = StripLinesAverages.GetRange(Middle, Strips.Length - Middle - 1); //дополнительный -1 в конце из-за особенностей алгоритма
                    stripX1 = StripLinesAveragesSub1.FindIndex(o => o == StripLinesAveragesSub1.Min());
                    stripX2 = Middle + StripLinesAveragesSub2.FindIndex(o => o == StripLinesAveragesSub2.Min());

                    //????
                    /*int HowBad = StripLinesAverages.FindAll(o => o > 253).Count();
                    if (HowBad > 5)
                    {
                        Strips[stripX1 + 1] = Strips[stripX1];
                        Strips[stripX2 + 1] = Strips[stripX2];
                    }*/
                }
            }
        }

        public static List<int> GetMargins(Bitmap img, int stripCount, int MaxGValue)
        {
            //Vertical

            int SourceHeight = img.Height;
            int SourceWidth = img.Width;
            //IsVertical = vert;

            //int stripCount = 1;

            //Scale = SourceHeight > MaxHeight ? 1f * MaxHeight / SourceHeight : 1f;

            //int Height = SourceWidth; // (int)((IsVertical ? SourceWidth : SourceHeight) * Scale);
            //int Width = stripCount;

            var w = 0; //vert ? Height : Width;
            var h = 0; //vert ? Width : Height;

            int XGapLeft, XGapRight, XtextRB, YGapTop, YGapBottom, YtextBB;

            w = stripCount; //YGaps
            h = SourceHeight;
            using (var bmp = new Bitmap(w, h))
            using (var gr = Graphics.FromImage(bmp))
            {
                gr.InterpolationMode = InterpolationMode.Low;
                gr.DrawImage(img, 0, 0, w, h);

                using (var wr = new ImageWrapper(bmp, true))
                {
                    int[][] Strips = new int[h][];
                    int[] Str = new int[h];
                    for (int y = 0; y < h; y++)
                    {
                        var strip = Strips[y] = new int[w];
                        for (int x = 0; x < w; x++)
                            strip[x] = wr[x, y].G;
                        Str[y] = strip.Min();
                    }

                    YGapTop = Str.ToList().FindIndex(o => o < MaxGValue);
                    YtextBB = Str.ToList().FindLastIndex(o => o < MaxGValue);
                    YGapBottom = SourceHeight - YtextBB - 1;
                }
            }

            w = SourceWidth; //XGaps
            h = stripCount;
            using (var bmp = new Bitmap(w, h))
            using (var gr = Graphics.FromImage(bmp))
            {
                gr.InterpolationMode = InterpolationMode.Low;
                gr.DrawImage(img, 0, 0, w, h);

                using (var wr = new ImageWrapper(bmp, true))
                {
                    int[][] Strips = new int[w][];
                    int[] Str = new int[w];
                    for (int x = 0; x < w; x++)
                    {
                        var strip = Strips[x] = new int[h];
                        for (int y = 0; y < h; y++)
                            strip[y] = wr[x, y].G;
                        Str[x] = strip.Min();
                    }

                    XGapLeft = Str.ToList().FindIndex(o => o < MaxGValue);
                    XtextRB = Str.ToList().FindLastIndex(o => o < MaxGValue);
                    XGapRight = SourceWidth - XtextRB - 1;
                }
            }

            return new List<int> { XGapLeft, XGapRight, YGapTop, YGapBottom };
        }
    }
}