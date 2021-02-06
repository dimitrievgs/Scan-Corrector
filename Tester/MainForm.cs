//Copyright © Storm23, GPL3, 2015

using System;
using System.Drawing;
using System.Windows.Forms;
using SkewCorrectionNS;

using System.Drawing.Imaging; //save
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Drawing.Drawing2D;


namespace Tester
{
    public partial class MainForm : Form
    {
        //ribbon: www.codeproject.com/Articles/364272/Easily-Add-a-Ribbon-into-a-WinForms-Application-Cs

        public MainForm()
        {
            InitializeComponent();

            this.CenterToScreen();

            cCleanSourceMargins_CheckedChanged(null, null);
            cChangeMargins_CheckedChanged(null, null);
            cbAutomCalcAngle_CheckedChanged(null, null);

        }

        private Bitmap ImageSource;
        private string LastFileName = "";

        private void ProcessFile(string filePath)
        {
            LoadFile(filePath);
            CorrectFile(filePath, true);
        }

        private void LoadFile(string filePath)
        {
            ImageSource /*var img*/ = (Bitmap)Image.FromFile(filePath);

            this.Invoke((MethodInvoker)delegate ()
            {
                pbLeft.Image = (Bitmap)ImageSource.Clone();
                pbRight.Image = null;
                RescaleToShow(ImageSource.Size, ref pbLeft);
            });
        }

        private void CorrectFile(string filePath, bool UseAutomateRotation)
        {
            //create strips
            var stripCount = (int)nStripApproxLength.Value; //10;

            Bitmap ImageSource2 = new Bitmap(ImageSource);//(Bitmap)ImageSource.Clone();

            if (cMakeGray.Checked == true)
                Rotator.MakeGray(ImageSource2); //но в фотошопе режим всё равно RGB, а не градации серого!

            double Angle = 0;
            if (UseAutomateRotation == true)
            {
                int stripX1, stripX2;
                var compact = new Compact(ImageSource2, stripCount, out stripX1, out stripX2); 
                //автоматическое вычисление stripX1 и stripX2 здесь не верно в контексте алгоритма...

                //find rotation angle
                stripX1 = 2;//take 3-rd strip
                stripX2 = 6;//take 7-th strip

                Angle = SkewCalculator.FindRotateAngle(compact, stripX1, stripX2);
                Angle = (Angle * 180 / Math.PI); //to degrees

                this.Invoke((MethodInvoker)delegate ()
                {
                    nAngleValueManually.Value = (decimal)Angle;
                });
            }
            else Angle = (double)nAngleValueManually.Value;

            //rotate
            var rotated = Rotator.Rotate(ImageSource2, Angle, cCleanSourceMarginsBeforeRotation.Checked,
                cCleanSourceMarginsAfterRotation.Checked, (int)nKnownSourceXMargin.Value, (int)nKnownSourceYMargin.Value);

            //теперь Margins
            Bitmap shifted = Rotator.ChangeMargins(cChangeMargins.Checked, rotated, stripCount, (int)nMaxMarginGValue.Value,
                (int)nNewXrightMargin.Value, (int)nNewYbottomMargin.Value);

            if (cSharpen.Checked == true)
                shifted = Rotator.Sharpen(shifted);
            if (cBlur.Checked == true)
                shifted = Rotator.MedianFilter(shifted, (int)nApeture.Value);

            this.Invoke((MethodInvoker)delegate ()
            {
                pbRight.Image = (Bitmap)rotated.Clone();
                RescaleToShow(rotated.Size, ref pbRight);
            });

            string NewFilePath = NewFileName(filePath);

            Encoder myEncoder = Encoder.Quality;
            EncoderParameter myEncoderParameter;
            EncoderParameters myEncoderParameters = new EncoderParameters(1);
            // Save the bitmap as a JPEG file with quality level 75.
            myEncoderParameter = new EncoderParameter(myEncoder, (long)nQuality.Value); //new EncoderParameter(myEncoder, 100L);
            myEncoderParameters.Param[0] = myEncoderParameter;
            ImageCodecInfo myImageCodecInfo = GetEncoderInfo("image/jpeg");
            shifted.Save(NewFilePath, myImageCodecInfo, myEncoderParameters);
            //shifted.Save(NewFilePath, ImageFormat.Jpeg); //если просто так написать, сохранит в качестве 75%
        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        private void RescaleToShow(Size imgSize, ref Controls.ZoomPictureBox PicContainer)
        {
            PicContainer.Zoom = Math.Max((float)PicContainer.Width / imgSize.Width, (float)PicContainer.Height / imgSize.Height);
        }

        private string NewFileName(string filePath)
        {
            string Base = Path.GetDirectoryName(filePath);
            string FileName = Path.GetFileNameWithoutExtension(filePath);
            string ProcessFolder = Base + "\\Processed\\";
            if (!Directory.Exists(ProcessFolder))
            {
                Directory.CreateDirectory(ProcessFolder);
            }

            return ProcessFolder + FileName + "_2.jpg";
        }

        private void pbLeft_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.FromArgb(20, Color.Black)))
            {
                for (int i = 0; i < pbLeft.Height; i += 30)
                    e.Graphics.DrawLine(pen, 0, i, pbLeft.Width, i);
                for (int j = 0; j < pbLeft.Width; j += 30)
                    e.Graphics.DrawLine(pen, j, 0, j, pbLeft.Height);
            }
            /*            for (int i = 0; i < 1000; i += 30)
                e.Graphics.DrawLine(pen, 0, i, 1000, i);*/
        }

        private void cCleanSourceMargins_CheckedChanged(object sender, EventArgs e)
        {
            nKnownSourceXMargin.Enabled = cCleanSourceMarginsBeforeRotation.Checked;
            nKnownSourceYMargin.Enabled = cCleanSourceMarginsBeforeRotation.Checked;
        }

        private void cChangeMargins_CheckedChanged(object sender, EventArgs e)
        {
            nNewXrightMargin.Enabled = cChangeMargins.Checked;
            nNewYbottomMargin.Enabled = cChangeMargins.Checked;
        }

        private void cbAutomCalcAngle_CheckedChanged(object sender, EventArgs e)
        {
            nAngleValueManually.Enabled = !cbAutomCalcAngle.Checked;
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            if (RunShow() == true)
            {
                var ofd = new OpenFileDialog { Filter = "Image|*.png;*.jpeg;*.jpg;*.tif" };
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Thread TS = new Thread(delegate ()
                    {
                        Report("");
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            tbFileName.Text = ofd.FileName;
                        });
                        LoadFile(ofd.FileName);

                        LastFileName = ofd.FileName;
                        StoppedShow();
                    });
                    TS.IsBackground = true;
                    TS.Start();
                }
                else StoppedShow();
            }
        }

        private void bCorrect_Click(object sender, EventArgs e)
        {
            if (RunShow() == true)
            {
                if (LastFileName != "" && ImageSource != null)
                {
                    Thread TS = new Thread(delegate ()
                    {
                        Report("");
                        CorrectFile(LastFileName, cbAutomCalcAngle.Checked);
                        Report("Done!");
                        StoppedShow();
                    });
                    TS.IsBackground = true;
                    TS.Start();
                }
                else StoppedShow();
            }
        }

        private void bSingleCorrection_Click(object sender, EventArgs e)
        {
            if (RunShow() == true)
            {
                var ofd = new OpenFileDialog { Filter = "Image|*.png;*.jpeg;*.jpg;*.tif" };
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Thread TS = new Thread(delegate ()
                    {
                        Report("");
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            tbFileName.Text = ofd.FileName;
                        });
                        ProcessFile(ofd.FileName);
                        Report("Done!");

                        LastFileName = ofd.FileName;
                        StoppedShow();
                    });
                    TS.IsBackground = true;
                    TS.Start();
                }
                else StoppedShow();
            }
        }

        private void bMultipleCorrection_Click(object sender, EventArgs e)
        {

            if (RunShow() == true)
            {
                var ofd = new OpenFileDialog { Filter = "Image|*.png;*.jpeg;*.jpg;*.tif" };
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Thread TS = new Thread(delegate ()
                    {
                        Report("");
                        string[] fileNames = ofd.FileNames;
                        int count = fileNames.Length;
                        string countS = "/" + count.ToString();
                        for (int i = 0; i < count; i++)
                        {
                            string curFileName = fileNames[i];
                            this.Invoke((MethodInvoker)delegate ()
                            {
                                tbFileName.Text = curFileName;
                            }); 
                            ProcessFile(curFileName);
                            Report((i + 1).ToString() + countS);
                        }
                        Report("Done!");

                        LastFileName = fileNames[count - 1];
                        StoppedShow();
                    });
                    TS.IsBackground = true;
                    TS.Start();
                }
                else StoppedShow();
            }
        }

        public void Report(string Text)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                tbProcess.Text = Text;
            });
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Environment.Exit(Environment.ExitCode);
            }
            finally { }
        }


        //-------------------------------------------------------------------------
        //-----------------------Run status & Stop requests------------------------

        private bool MeasurementOn = false; //говорит о том, идёт ли эксперимент
        private bool StopRequest = false; //говорит о том, был ли откуда-либо запрос на остановку эксперимента (во время эксперимента)
        protected System.Object lockThis1 = new System.Object();

        public bool RunShow()
        {
            bool result = (Status(true, true) != true);
            StopRequest = false;
            return result;
        }

        public void StoppedShow()
        {
            Status(true, false);
            StopRequest = false;
            GC.Collect(); 
        }

        public bool StatusCheck()
        {
            return Status(false, false);
        }

        public bool Status(bool changeState, bool newState)
        {
            lock (lockThis1) //эта часть кода может выполняться одновременно только в одном потоке
            {
                bool initialState = MeasurementOn;
                if ((changeState == true) && (initialState != newState))
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        MeasurementOn = newState;
                        Text = (newState) ? ("Scan Convertor (converting...)") : ("Scan Convertor");
                        /*bOnoff.Value = newState;
                        IntensityGraph.EnableUserChanges(!newState);
                        PolarizationGraph.EnableUserChanges(!newState);*/

        });
                }
                return initialState;
            }
        }

        public void Stop()
        {
            StopRequest = true;
        }
    }
}
