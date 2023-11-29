namespace ASCOM.NanoOC
{
    partial class SetupOC
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
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.picASCOM = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkTrace = new System.Windows.Forms.CheckBox();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputgain = new System.Windows.Forms.NumericUpDown();
            this.inputhighT = new System.Windows.Forms.NumericUpDown();
            this.inputSkyMag = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.trim = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.inputoffset = new System.Windows.Forms.NumericUpDown();
            this.chkBuzzer = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.inputHtrim = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.inputPtrim = new System.Windows.Forms.NumericUpDown();
            this.temptrim = new System.Windows.Forms.Label();
            this.inputTtrim = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inputUL = new System.Windows.Forms.NumericUpDown();
            this.inputLL = new System.Windows.Forms.NumericUpDown();
            this.inputRainAdj = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picASCOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputgain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputhighT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSkyMag)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.trim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputoffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHtrim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPtrim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTtrim)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputUL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputRainAdj)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Location = new System.Drawing.Point(267, 113);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(59, 24);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(267, 143);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(59, 25);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // picASCOM
            // 
            this.picASCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picASCOM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picASCOM.Image = global::ASCOM.NanoOC.Properties.Resources.ASCOM;
            this.picASCOM.Location = new System.Drawing.Point(278, 13);
            this.picASCOM.Name = "picASCOM";
            this.picASCOM.Size = new System.Drawing.Size(48, 56);
            this.picASCOM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picASCOM.TabIndex = 3;
            this.picASCOM.TabStop = false;
            this.picASCOM.Click += new System.EventHandler(this.BrowseToAscom);
            this.picASCOM.DoubleClick += new System.EventHandler(this.BrowseToAscom);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Comm Port";
            // 
            // chkTrace
            // 
            this.chkTrace.AutoSize = true;
            this.chkTrace.Location = new System.Drawing.Point(184, 118);
            this.chkTrace.Name = "chkTrace";
            this.chkTrace.Size = new System.Drawing.Size(69, 17);
            this.chkTrace.TabIndex = 6;
            this.chkTrace.Text = "Trace on";
            this.chkTrace.UseVisualStyleBackColor = true;
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(84, 143);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(57, 21);
            this.comboBoxComPort.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "mag +/-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "hot coeff";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "amb. coeff";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputgain
            // 
            this.inputgain.Location = new System.Drawing.Point(216, 25);
            this.inputgain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputgain.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.inputgain.Name = "inputgain";
            this.inputgain.Size = new System.Drawing.Size(45, 20);
            this.inputgain.TabIndex = 12;
            // 
            // inputhighT
            // 
            this.inputhighT.Location = new System.Drawing.Point(216, 83);
            this.inputhighT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputhighT.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.inputhighT.Name = "inputhighT";
            this.inputhighT.Size = new System.Drawing.Size(45, 20);
            this.inputhighT.TabIndex = 13;
            // 
            // inputSkyMag
            // 
            this.inputSkyMag.DecimalPlaces = 1;
            this.inputSkyMag.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputSkyMag.Location = new System.Drawing.Point(84, 25);
            this.inputSkyMag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputSkyMag.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.inputSkyMag.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.inputSkyMag.Name = "inputSkyMag";
            this.inputSkyMag.Size = new System.Drawing.Size(45, 20);
            this.inputSkyMag.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.trim);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(340, 204);
            this.tabControl1.TabIndex = 20;
            // 
            // trim
            // 
            this.trim.BackColor = System.Drawing.Color.DarkGray;
            this.trim.Controls.Add(this.label12);
            this.trim.Controls.Add(this.label11);
            this.trim.Controls.Add(this.label1);
            this.trim.Controls.Add(this.inputoffset);
            this.trim.Controls.Add(this.chkBuzzer);
            this.trim.Controls.Add(this.label10);
            this.trim.Controls.Add(this.inputHtrim);
            this.trim.Controls.Add(this.label9);
            this.trim.Controls.Add(this.inputPtrim);
            this.trim.Controls.Add(this.temptrim);
            this.trim.Controls.Add(this.inputTtrim);
            this.trim.Controls.Add(this.cmdCancel);
            this.trim.Controls.Add(this.picASCOM);
            this.trim.Controls.Add(this.cmdOK);
            this.trim.Controls.Add(this.label3);
            this.trim.Controls.Add(this.label2);
            this.trim.Controls.Add(this.chkTrace);
            this.trim.Controls.Add(this.comboBoxComPort);
            this.trim.Controls.Add(this.inputSkyMag);
            this.trim.Controls.Add(this.label4);
            this.trim.Controls.Add(this.inputhighT);
            this.trim.Controls.Add(this.label5);
            this.trim.Controls.Add(this.inputgain);
            this.trim.Location = new System.Drawing.Point(4, 22);
            this.trim.Name = "trim";
            this.trim.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.trim.Size = new System.Drawing.Size(332, 178);
            this.trim.TabIndex = 0;
            this.trim.Text = "trim values";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "offset";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputoffset
            // 
            this.inputoffset.DecimalPlaces = 1;
            this.inputoffset.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.inputoffset.Location = new System.Drawing.Point(216, 54);
            this.inputoffset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputoffset.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.inputoffset.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.inputoffset.Name = "inputoffset";
            this.inputoffset.Size = new System.Drawing.Size(45, 20);
            this.inputoffset.TabIndex = 23;
            // 
            // chkBuzzer
            // 
            this.chkBuzzer.AutoSize = true;
            this.chkBuzzer.Location = new System.Drawing.Point(184, 147);
            this.chkBuzzer.Name = "chkBuzzer";
            this.chkBuzzer.Size = new System.Drawing.Size(73, 17);
            this.chkBuzzer.TabIndex = 21;
            this.chkBuzzer.Text = "Buzzer on";
            this.chkBuzzer.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "RH% +/-";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputHtrim
            // 
            this.inputHtrim.DecimalPlaces = 1;
            this.inputHtrim.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputHtrim.Location = new System.Drawing.Point(84, 54);
            this.inputHtrim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputHtrim.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.inputHtrim.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.inputHtrim.Name = "inputHtrim";
            this.inputHtrim.Size = new System.Drawing.Size(45, 20);
            this.inputHtrim.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "hPa +/-";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputPtrim
            // 
            this.inputPtrim.DecimalPlaces = 1;
            this.inputPtrim.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputPtrim.Location = new System.Drawing.Point(84, 83);
            this.inputPtrim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputPtrim.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.inputPtrim.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.inputPtrim.Name = "inputPtrim";
            this.inputPtrim.Size = new System.Drawing.Size(45, 20);
            this.inputPtrim.TabIndex = 18;
            // 
            // temptrim
            // 
            this.temptrim.AutoSize = true;
            this.temptrim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.temptrim.Location = new System.Drawing.Point(13, 114);
            this.temptrim.Name = "temptrim";
            this.temptrim.Size = new System.Drawing.Size(57, 13);
            this.temptrim.TabIndex = 15;
            this.temptrim.Text = "temp C +/-";
            this.temptrim.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputTtrim
            // 
            this.inputTtrim.DecimalPlaces = 1;
            this.inputTtrim.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputTtrim.Location = new System.Drawing.Point(84, 112);
            this.inputTtrim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputTtrim.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            65536});
            this.inputTtrim.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.inputTtrim.Name = "inputTtrim";
            this.inputTtrim.Size = new System.Drawing.Size(45, 20);
            this.inputTtrim.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.inputUL);
            this.tabPage2.Controls.Add(this.inputLL);
            this.tabPage2.Controls.Add(this.inputRainAdj);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(332, 178);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "limits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "100% cloud temp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "0% cloud temp";
            // 
            // inputUL
            // 
            this.inputUL.Location = new System.Drawing.Point(115, 52);
            this.inputUL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputUL.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.inputUL.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.inputUL.Name = "inputUL";
            this.inputUL.Size = new System.Drawing.Size(48, 20);
            this.inputUL.TabIndex = 23;
            this.inputUL.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // inputLL
            // 
            this.inputLL.Location = new System.Drawing.Point(115, 87);
            this.inputLL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputLL.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.inputLL.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147483648});
            this.inputLL.Name = "inputLL";
            this.inputLL.Size = new System.Drawing.Size(48, 20);
            this.inputLL.TabIndex = 22;
            // 
            // inputRainAdj
            // 
            this.inputRainAdj.DecimalPlaces = 1;
            this.inputRainAdj.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputRainAdj.Location = new System.Drawing.Point(115, 122);
            this.inputRainAdj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputRainAdj.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.inputRainAdj.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputRainAdj.Name = "inputRainAdj";
            this.inputRainAdj.Size = new System.Drawing.Size(48, 20);
            this.inputRainAdj.TabIndex = 21;
            this.inputRainAdj.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "rain rate limit";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "sensor tuning";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(153, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "sky T adjustments";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "cloud and rain limits";
            // 
            // SetupOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 207);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupOC";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nano observing conditions setup 2.5";
            ((System.ComponentModel.ISupportInitialize)(this.picASCOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputgain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputhighT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSkyMag)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.trim.ResumeLayout(false);
            this.trim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputoffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHtrim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPtrim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTtrim)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputUL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputRainAdj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.PictureBox picASCOM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkTrace;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown inputgain;
        private System.Windows.Forms.NumericUpDown inputhighT;
        private System.Windows.Forms.NumericUpDown inputSkyMag;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage trim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown inputHtrim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown inputPtrim;
        private System.Windows.Forms.Label temptrim;
        private System.Windows.Forms.NumericUpDown inputTtrim;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown inputUL;
        private System.Windows.Forms.NumericUpDown inputLL;
        private System.Windows.Forms.NumericUpDown inputRainAdj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkBuzzer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inputoffset;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}