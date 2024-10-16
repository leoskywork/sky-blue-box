namespace SkyBlueBox
{
    partial class FormTarget
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownStartPointX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStartPointY = new System.Windows.Forms.NumericUpDown();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxStartPoint = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timerRefreshUI = new System.Windows.Forms.Timer(this.components);
            this.buttonTest1 = new System.Windows.Forms.Button();
            this.panelOut = new System.Windows.Forms.Panel();
            this.panelInner = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonTest3 = new System.Windows.Forms.Button();
            this.buttonTest2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPointY)).BeginInit();
            this.groupBoxStartPoint.SuspendLayout();
            this.panelOut.SuspendLayout();
            this.panelInner.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // numericUpDownStartPointX
            // 
            this.numericUpDownStartPointX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownStartPointX.Location = new System.Drawing.Point(56, 28);
            this.numericUpDownStartPointX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownStartPointX.Name = "numericUpDownStartPointX";
            this.numericUpDownStartPointX.Size = new System.Drawing.Size(80, 25);
            this.numericUpDownStartPointX.TabIndex = 1;
            this.numericUpDownStartPointX.Value = new decimal(new int[] {
            682,
            0,
            0,
            0});
            this.numericUpDownStartPointX.ValueChanged += new System.EventHandler(this.numericUpDownStartPointX_ValueChanged);
            // 
            // numericUpDownStartPointY
            // 
            this.numericUpDownStartPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownStartPointY.Location = new System.Drawing.Point(56, 59);
            this.numericUpDownStartPointY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownStartPointY.Name = "numericUpDownStartPointY";
            this.numericUpDownStartPointY.Size = new System.Drawing.Size(80, 25);
            this.numericUpDownStartPointY.TabIndex = 2;
            this.numericUpDownStartPointY.Value = new decimal(new int[] {
            520,
            0,
            0,
            0});
            this.numericUpDownStartPointY.ValueChanged += new System.EventHandler(this.numericUpDownStartPointY_ValueChanged);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxMessage.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxMessage.Location = new System.Drawing.Point(0, 690);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(1382, 163);
            this.textBoxMessage.TabIndex = 3;
            this.textBoxMessage.Text = "msg";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(168, 24);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(80, 28);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(168, 68);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(80, 28);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(1268, 813);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 28);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBoxStartPoint
            // 
            this.groupBoxStartPoint.Controls.Add(this.label2);
            this.groupBoxStartPoint.Controls.Add(this.numericUpDownStartPointX);
            this.groupBoxStartPoint.Controls.Add(this.numericUpDownStartPointY);
            this.groupBoxStartPoint.Controls.Add(this.label1);
            this.groupBoxStartPoint.Location = new System.Drawing.Point(10, 4);
            this.groupBoxStartPoint.Name = "groupBoxStartPoint";
            this.groupBoxStartPoint.Size = new System.Drawing.Size(152, 109);
            this.groupBoxStartPoint.TabIndex = 7;
            this.groupBoxStartPoint.TabStop = false;
            this.groupBoxStartPoint.Text = "Start point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y:";
            // 
            // timerRefreshUI
            // 
            this.timerRefreshUI.Interval = 1000;
            // 
            // buttonTest1
            // 
            this.buttonTest1.Location = new System.Drawing.Point(280, 64);
            this.buttonTest1.Name = "buttonTest1";
            this.buttonTest1.Size = new System.Drawing.Size(90, 50);
            this.buttonTest1.TabIndex = 8;
            this.buttonTest1.Text = "Test 1";
            this.buttonTest1.UseVisualStyleBackColor = true;
            this.buttonTest1.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // panelOut
            // 
            this.panelOut.AutoScroll = true;
            this.panelOut.BackColor = System.Drawing.Color.LightGray;
            this.panelOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelOut.Controls.Add(this.panelInner);
            this.panelOut.Location = new System.Drawing.Point(51, 136);
            this.panelOut.Name = "panelOut";
            this.panelOut.Size = new System.Drawing.Size(1280, 500);
            this.panelOut.TabIndex = 9;
            this.panelOut.Click += new System.EventHandler(this.panelOut_Click);
            // 
            // panelInner
            // 
            this.panelInner.AutoScroll = true;
            this.panelInner.BackColor = System.Drawing.Color.DarkGray;
            this.panelInner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInner.Controls.Add(this.button7);
            this.panelInner.Controls.Add(this.button6);
            this.panelInner.Controls.Add(this.button5);
            this.panelInner.Controls.Add(this.button4);
            this.panelInner.Controls.Add(this.buttonTest1);
            this.panelInner.Controls.Add(this.buttonTest3);
            this.panelInner.Controls.Add(this.buttonTest2);
            this.panelInner.Location = new System.Drawing.Point(0, 0);
            this.panelInner.Name = "panelInner";
            this.panelInner.Size = new System.Drawing.Size(1000, 2000);
            this.panelInner.TabIndex = 11;
            this.panelInner.Click += new System.EventHandler(this.panelInner_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(280, 1108);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 50);
            this.button7.TabIndex = 14;
            this.button7.Text = "Test 7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(280, 934);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 50);
            this.button6.TabIndex = 13;
            this.button6.Text = "Test 6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(280, 760);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 50);
            this.button5.TabIndex = 12;
            this.button5.Text = "Test 5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(280, 586);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 50);
            this.button4.TabIndex = 11;
            this.button4.Text = "Test 4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonTest3
            // 
            this.buttonTest3.Location = new System.Drawing.Point(280, 412);
            this.buttonTest3.Name = "buttonTest3";
            this.buttonTest3.Size = new System.Drawing.Size(90, 50);
            this.buttonTest3.TabIndex = 10;
            this.buttonTest3.Text = "Test 3";
            this.buttonTest3.UseVisualStyleBackColor = true;
            this.buttonTest3.Click += new System.EventHandler(this.buttonTest3_Click);
            // 
            // buttonTest2
            // 
            this.buttonTest2.Location = new System.Drawing.Point(280, 238);
            this.buttonTest2.Name = "buttonTest2";
            this.buttonTest2.Size = new System.Drawing.Size(90, 50);
            this.buttonTest2.TabIndex = 9;
            this.buttonTest2.Text = "Test 2";
            this.buttonTest2.UseVisualStyleBackColor = true;
            this.buttonTest2.Click += new System.EventHandler(this.buttonTest2_Click);
            // 
            // FormTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.panelOut);
            this.Controls.Add(this.groupBoxStartPoint);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxMessage);
            this.MaximizeBox = false;
            this.Name = "FormTarget";
            this.Text = "Target";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPointY)).EndInit();
            this.groupBoxStartPoint.ResumeLayout(false);
            this.groupBoxStartPoint.PerformLayout();
            this.panelOut.ResumeLayout(false);
            this.panelInner.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownStartPointX;
        private System.Windows.Forms.NumericUpDown numericUpDownStartPointY;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBoxStartPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerRefreshUI;
        private System.Windows.Forms.Button buttonTest1;
        private System.Windows.Forms.Panel panelOut;
        private System.Windows.Forms.Button buttonTest3;
        private System.Windows.Forms.Button buttonTest2;
        private System.Windows.Forms.Panel panelInner;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

