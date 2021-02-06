namespace Tester
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nMaxMarginGValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nNewXrightMargin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nNewYbottomMargin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nKnownSourceXMargin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nKnownSourceYMargin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cCleanSourceMarginsBeforeRotation = new System.Windows.Forms.CheckBox();
            this.cChangeMargins = new System.Windows.Forms.CheckBox();
            this.bSingleCorrection = new System.Windows.Forms.Button();
            this.tbProcess = new System.Windows.Forms.TextBox();
            this.nStripApproxLength = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cCleanSourceMarginsAfterRotation = new System.Windows.Forms.CheckBox();
            this.cbAutomCalcAngle = new System.Windows.Forms.CheckBox();
            this.nAngleValueManually = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.cMakeGray = new System.Windows.Forms.CheckBox();
            this.nQuality = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.singleConvertorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleConvertorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correctToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bCorrect = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.bMultipleCorrection = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.nApeture = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cBlur = new System.Windows.Forms.CheckBox();
            this.cSharpen = new System.Windows.Forms.CheckBox();
            this.pbLeft = new Tester.Controls.ZoomPictureBox();
            this.pbRight = new Tester.Controls.ZoomPictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxMarginGValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNewXrightMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNewYbottomMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKnownSourceXMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKnownSourceYMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStripApproxLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAngleValueManually)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQuality)).BeginInit();
            this.msMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nApeture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pbLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbRight, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 158);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1013, 731);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // nMaxMarginGValue
            // 
            this.nMaxMarginGValue.Location = new System.Drawing.Point(508, 66);
            this.nMaxMarginGValue.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nMaxMarginGValue.Name = "nMaxMarginGValue";
            this.nMaxMarginGValue.Size = new System.Drawing.Size(90, 20);
            this.nMaxMarginGValue.TabIndex = 6;
            this.nMaxMarginGValue.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "MaxMarginGValue";
            // 
            // nNewXrightMargin
            // 
            this.nNewXrightMargin.Location = new System.Drawing.Point(265, 66);
            this.nNewXrightMargin.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nNewXrightMargin.Name = "nNewXrightMargin";
            this.nNewXrightMargin.Size = new System.Drawing.Size(90, 20);
            this.nNewXrightMargin.TabIndex = 6;
            this.nNewXrightMargin.Value = new decimal(new int[] {
            141,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "NewXrightMargin";
            // 
            // nNewYbottomMargin
            // 
            this.nNewYbottomMargin.Location = new System.Drawing.Point(391, 66);
            this.nNewYbottomMargin.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nNewYbottomMargin.Name = "nNewYbottomMargin";
            this.nNewYbottomMargin.Size = new System.Drawing.Size(90, 20);
            this.nNewYbottomMargin.TabIndex = 6;
            this.nNewYbottomMargin.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "NewYbottomMargin";
            // 
            // nKnownSourceXMargin
            // 
            this.nKnownSourceXMargin.Location = new System.Drawing.Point(14, 67);
            this.nKnownSourceXMargin.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nKnownSourceXMargin.Name = "nKnownSourceXMargin";
            this.nKnownSourceXMargin.Size = new System.Drawing.Size(90, 20);
            this.nKnownSourceXMargin.TabIndex = 6;
            this.nKnownSourceXMargin.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "KnownSourceXMargin";
            // 
            // nKnownSourceYMargin
            // 
            this.nKnownSourceYMargin.Location = new System.Drawing.Point(140, 67);
            this.nKnownSourceYMargin.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nKnownSourceYMargin.Name = "nKnownSourceYMargin";
            this.nKnownSourceYMargin.Size = new System.Drawing.Size(90, 20);
            this.nKnownSourceYMargin.TabIndex = 6;
            this.nKnownSourceYMargin.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "KnownSourceYMargin";
            // 
            // cCleanSourceMarginsBeforeRotation
            // 
            this.cCleanSourceMarginsBeforeRotation.AutoSize = true;
            this.cCleanSourceMarginsBeforeRotation.Checked = true;
            this.cCleanSourceMarginsBeforeRotation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cCleanSourceMarginsBeforeRotation.Location = new System.Drawing.Point(14, 29);
            this.cCleanSourceMarginsBeforeRotation.Name = "cCleanSourceMarginsBeforeRotation";
            this.cCleanSourceMarginsBeforeRotation.Size = new System.Drawing.Size(100, 17);
            this.cCleanSourceMarginsBeforeRotation.TabIndex = 9;
            this.cCleanSourceMarginsBeforeRotation.Text = "Before Rotation";
            this.cCleanSourceMarginsBeforeRotation.UseVisualStyleBackColor = true;
            this.cCleanSourceMarginsBeforeRotation.CheckedChanged += new System.EventHandler(this.cCleanSourceMargins_CheckedChanged);
            // 
            // cChangeMargins
            // 
            this.cChangeMargins.AutoSize = true;
            this.cChangeMargins.Checked = true;
            this.cChangeMargins.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cChangeMargins.Location = new System.Drawing.Point(265, 29);
            this.cChangeMargins.Name = "cChangeMargins";
            this.cChangeMargins.Size = new System.Drawing.Size(103, 17);
            this.cChangeMargins.TabIndex = 9;
            this.cChangeMargins.Text = "Change Margins";
            this.cChangeMargins.UseVisualStyleBackColor = true;
            this.cChangeMargins.CheckedChanged += new System.EventHandler(this.cChangeMargins_CheckedChanged);
            // 
            // bSingleCorrection
            // 
            this.bSingleCorrection.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bSingleCorrection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSingleCorrection.ForeColor = System.Drawing.Color.Black;
            this.bSingleCorrection.Image = ((System.Drawing.Image)(resources.GetObject("bSingleCorrection.Image")));
            this.bSingleCorrection.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bSingleCorrection.Location = new System.Drawing.Point(6, 6);
            this.bSingleCorrection.Name = "bSingleCorrection";
            this.bSingleCorrection.Size = new System.Drawing.Size(66, 68);
            this.bSingleCorrection.TabIndex = 10;
            this.bSingleCorrection.Text = "Single";
            this.bSingleCorrection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bSingleCorrection.UseVisualStyleBackColor = true;
            this.bSingleCorrection.Click += new System.EventHandler(this.bSingleCorrection_Click);
            // 
            // tbProcess
            // 
            this.tbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbProcess.Location = new System.Drawing.Point(294, 32);
            this.tbProcess.Name = "tbProcess";
            this.tbProcess.Size = new System.Drawing.Size(100, 26);
            this.tbProcess.TabIndex = 11;
            // 
            // nStripApproxLength
            // 
            this.nStripApproxLength.Location = new System.Drawing.Point(226, 51);
            this.nStripApproxLength.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nStripApproxLength.Name = "nStripApproxLength";
            this.nStripApproxLength.Size = new System.Drawing.Size(90, 20);
            this.nStripApproxLength.TabIndex = 6;
            this.nStripApproxLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "StripApproxLength";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Clean Margins:";
            // 
            // cCleanSourceMarginsAfterRotation
            // 
            this.cCleanSourceMarginsAfterRotation.AutoSize = true;
            this.cCleanSourceMarginsAfterRotation.Location = new System.Drawing.Point(140, 29);
            this.cCleanSourceMarginsAfterRotation.Name = "cCleanSourceMarginsAfterRotation";
            this.cCleanSourceMarginsAfterRotation.Size = new System.Drawing.Size(91, 17);
            this.cCleanSourceMarginsAfterRotation.TabIndex = 9;
            this.cCleanSourceMarginsAfterRotation.Text = "After Rotation";
            this.cCleanSourceMarginsAfterRotation.UseVisualStyleBackColor = true;
            this.cCleanSourceMarginsAfterRotation.CheckedChanged += new System.EventHandler(this.cCleanSourceMargins_CheckedChanged);
            // 
            // cbAutomCalcAngle
            // 
            this.cbAutomCalcAngle.AutoSize = true;
            this.cbAutomCalcAngle.Checked = true;
            this.cbAutomCalcAngle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutomCalcAngle.Location = new System.Drawing.Point(15, 12);
            this.cbAutomCalcAngle.Name = "cbAutomCalcAngle";
            this.cbAutomCalcAngle.Size = new System.Drawing.Size(163, 17);
            this.cbAutomCalcAngle.TabIndex = 9;
            this.cbAutomCalcAngle.Text = "Automatically calculate angle";
            this.cbAutomCalcAngle.UseVisualStyleBackColor = true;
            this.cbAutomCalcAngle.CheckedChanged += new System.EventHandler(this.cbAutomCalcAngle_CheckedChanged);
            // 
            // nAngleValueManually
            // 
            this.nAngleValueManually.DecimalPlaces = 3;
            this.nAngleValueManually.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nAngleValueManually.Location = new System.Drawing.Point(15, 51);
            this.nAngleValueManually.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nAngleValueManually.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nAngleValueManually.Name = "nAngleValueManually";
            this.nAngleValueManually.Size = new System.Drawing.Size(90, 20);
            this.nAngleValueManually.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Angle Value Manually (\"-\"  is lockwise)";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(294, 6);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(516, 20);
            this.tbFileName.TabIndex = 12;
            // 
            // cMakeGray
            // 
            this.cMakeGray.AutoSize = true;
            this.cMakeGray.Checked = true;
            this.cMakeGray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cMakeGray.Location = new System.Drawing.Point(15, 12);
            this.cMakeGray.Name = "cMakeGray";
            this.cMakeGray.Size = new System.Drawing.Size(76, 17);
            this.cMakeGray.TabIndex = 9;
            this.cMakeGray.Text = "Make gray";
            this.cMakeGray.UseVisualStyleBackColor = true;
            this.cMakeGray.CheckedChanged += new System.EventHandler(this.cCleanSourceMargins_CheckedChanged);
            // 
            // nQuality
            // 
            this.nQuality.Location = new System.Drawing.Point(15, 50);
            this.nQuality.Name = "nQuality";
            this.nQuality.Size = new System.Drawing.Size(76, 20);
            this.nQuality.TabIndex = 6;
            this.nQuality.Value = new decimal(new int[] {
            94,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Quality";
            // 
            // miOpen
            // 
            this.miOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleConvertorToolStripMenuItem,
            this.multipleConvertorToolStripMenuItem,
            this.openToolStripMenuItem,
            this.correctToolStripMenuItem});
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(37, 20);
            this.miOpen.Text = "File";
            // 
            // singleConvertorToolStripMenuItem
            // 
            this.singleConvertorToolStripMenuItem.Name = "singleConvertorToolStripMenuItem";
            this.singleConvertorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.singleConvertorToolStripMenuItem.Text = "Single convertor";
            this.singleConvertorToolStripMenuItem.Click += new System.EventHandler(this.bSingleCorrection_Click);
            // 
            // multipleConvertorToolStripMenuItem
            // 
            this.multipleConvertorToolStripMenuItem.Name = "multipleConvertorToolStripMenuItem";
            this.multipleConvertorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.multipleConvertorToolStripMenuItem.Text = "Multiple convertor";
            this.multipleConvertorToolStripMenuItem.Click += new System.EventHandler(this.bMultipleCorrection_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // correctToolStripMenuItem
            // 
            this.correctToolStripMenuItem.Name = "correctToolStripMenuItem";
            this.correctToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.correctToolStripMenuItem.Text = "Correct";
            this.correctToolStripMenuItem.Click += new System.EventHandler(this.bCorrect_Click);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpen});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1013, 24);
            this.msMain.TabIndex = 3;
            this.msMain.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(3, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 122);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bCorrect);
            this.tabPage1.Controls.Add(this.tbProcess);
            this.tabPage1.Controls.Add(this.bLoad);
            this.tabPage1.Controls.Add(this.bMultipleCorrection);
            this.tabPage1.Controls.Add(this.bSingleCorrection);
            this.tabPage1.Controls.Add(this.tbFileName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1001, 96);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Load & Save";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bCorrect
            // 
            this.bCorrect.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bCorrect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCorrect.ForeColor = System.Drawing.Color.Black;
            this.bCorrect.Image = ((System.Drawing.Image)(resources.GetObject("bCorrect.Image")));
            this.bCorrect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bCorrect.Location = new System.Drawing.Point(222, 6);
            this.bCorrect.Name = "bCorrect";
            this.bCorrect.Size = new System.Drawing.Size(66, 68);
            this.bCorrect.TabIndex = 10;
            this.bCorrect.Text = "Correct";
            this.bCorrect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bCorrect.UseVisualStyleBackColor = true;
            this.bCorrect.Click += new System.EventHandler(this.bCorrect_Click);
            // 
            // bLoad
            // 
            this.bLoad.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLoad.ForeColor = System.Drawing.Color.Black;
            this.bLoad.Image = ((System.Drawing.Image)(resources.GetObject("bLoad.Image")));
            this.bLoad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bLoad.Location = new System.Drawing.Point(150, 6);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(66, 68);
            this.bLoad.TabIndex = 10;
            this.bLoad.Text = "Open";
            this.bLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // bMultipleCorrection
            // 
            this.bMultipleCorrection.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bMultipleCorrection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMultipleCorrection.ForeColor = System.Drawing.Color.Black;
            this.bMultipleCorrection.Image = ((System.Drawing.Image)(resources.GetObject("bMultipleCorrection.Image")));
            this.bMultipleCorrection.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bMultipleCorrection.Location = new System.Drawing.Point(78, 6);
            this.bMultipleCorrection.Name = "bMultipleCorrection";
            this.bMultipleCorrection.Size = new System.Drawing.Size(66, 68);
            this.bMultipleCorrection.TabIndex = 10;
            this.bMultipleCorrection.Text = "Multiple";
            this.bMultipleCorrection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bMultipleCorrection.UseVisualStyleBackColor = true;
            this.bMultipleCorrection.Click += new System.EventHandler(this.bMultipleCorrection_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.nQuality);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.cMakeGray);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1001, 96);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Save properties";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbAutomCalcAngle);
            this.tabPage2.Controls.Add(this.nAngleValueManually);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.nStripApproxLength);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1001, 96);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rotation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.nKnownSourceYMargin);
            this.tabPage3.Controls.Add(this.nKnownSourceXMargin);
            this.tabPage3.Controls.Add(this.cChangeMargins);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.cCleanSourceMarginsAfterRotation);
            this.tabPage3.Controls.Add(this.nMaxMarginGValue);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cCleanSourceMarginsBeforeRotation);
            this.tabPage3.Controls.Add(this.nNewXrightMargin);
            this.tabPage3.Controls.Add(this.nNewYbottomMargin);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1001, 96);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Margins";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.nApeture);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.cBlur);
            this.tabPage5.Controls.Add(this.cSharpen);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1001, 96);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Sharpen & Blur";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // nApeture
            // 
            this.nApeture.Location = new System.Drawing.Point(119, 50);
            this.nApeture.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nApeture.Name = "nApeture";
            this.nApeture.Size = new System.Drawing.Size(76, 20);
            this.nApeture.TabIndex = 10;
            this.nApeture.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(116, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Apeture";
            // 
            // cBlur
            // 
            this.cBlur.AutoSize = true;
            this.cBlur.Location = new System.Drawing.Point(119, 12);
            this.cBlur.Name = "cBlur";
            this.cBlur.Size = new System.Drawing.Size(44, 17);
            this.cBlur.TabIndex = 12;
            this.cBlur.Text = "Blur";
            this.cBlur.UseVisualStyleBackColor = true;
            // 
            // cSharpen
            // 
            this.cSharpen.AutoSize = true;
            this.cSharpen.Location = new System.Drawing.Point(15, 12);
            this.cSharpen.Name = "cSharpen";
            this.cSharpen.Size = new System.Drawing.Size(66, 17);
            this.cSharpen.TabIndex = 12;
            this.cSharpen.Text = "Sharpen";
            this.cSharpen.UseVisualStyleBackColor = true;
            // 
            // pbLeft
            // 
            this.pbLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLeft.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
            this.pbLeft.Location = new System.Drawing.Point(3, 3);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.pbLeft.Size = new System.Drawing.Size(500, 705);
            this.pbLeft.TabIndex = 0;
            this.pbLeft.VisibleCenter = ((System.Drawing.PointF)(resources.GetObject("pbLeft.VisibleCenter")));
            this.pbLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pbLeft_Paint);
            // 
            // pbRight
            // 
            this.pbRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRight.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.pbRight.Location = new System.Drawing.Point(509, 3);
            this.pbRight.Name = "pbRight";
            this.pbRight.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.pbRight.Size = new System.Drawing.Size(501, 705);
            this.pbRight.TabIndex = 1;
            this.pbRight.VisibleCenter = ((System.Drawing.PointF)(resources.GetObject("pbRight.VisibleCenter")));
            this.pbRight.Paint += new System.Windows.Forms.PaintEventHandler(this.pbLeft_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 902);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Scan Corrector";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nMaxMarginGValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNewXrightMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNewYbottomMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKnownSourceXMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKnownSourceYMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStripApproxLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAngleValueManually)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQuality)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nApeture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Tester.Controls.ZoomPictureBox pbLeft;
        private Tester.Controls.ZoomPictureBox pbRight;
        private System.Windows.Forms.NumericUpDown nMaxMarginGValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nNewXrightMargin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nNewYbottomMargin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nKnownSourceXMargin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nKnownSourceYMargin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cCleanSourceMarginsBeforeRotation;
        private System.Windows.Forms.CheckBox cChangeMargins;
        private System.Windows.Forms.Button bSingleCorrection;
        private System.Windows.Forms.TextBox tbProcess;
        private System.Windows.Forms.NumericUpDown nStripApproxLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cCleanSourceMarginsAfterRotation;
        private System.Windows.Forms.CheckBox cbAutomCalcAngle;
        private System.Windows.Forms.NumericUpDown nAngleValueManually;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.CheckBox cMakeGray;
        private System.Windows.Forms.NumericUpDown nQuality;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button bMultipleCorrection;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Button bCorrect;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.NumericUpDown nApeture;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cBlur;
        private System.Windows.Forms.CheckBox cSharpen;
        private System.Windows.Forms.ToolStripMenuItem singleConvertorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multipleConvertorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correctToolStripMenuItem;
    }
}

