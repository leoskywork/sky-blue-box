namespace SkyBlueBox
{
    partial class Main
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPointY)).BeginInit();
            this.groupBoxStartPoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
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
            this.numericUpDownStartPointX.Location = new System.Drawing.Point(79, 28);
            this.numericUpDownStartPointX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownStartPointX.Name = "numericUpDownStartPointX";
            this.numericUpDownStartPointX.Size = new System.Drawing.Size(80, 25);
            this.numericUpDownStartPointX.TabIndex = 1;
            this.numericUpDownStartPointX.ValueChanged += new System.EventHandler(this.numericUpDownStartPointX_ValueChanged);
            // 
            // numericUpDownStartPointY
            // 
            this.numericUpDownStartPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownStartPointY.Location = new System.Drawing.Point(79, 59);
            this.numericUpDownStartPointY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownStartPointY.Name = "numericUpDownStartPointY";
            this.numericUpDownStartPointY.Size = new System.Drawing.Size(80, 25);
            this.numericUpDownStartPointY.TabIndex = 2;
            this.numericUpDownStartPointY.ValueChanged += new System.EventHandler(this.numericUpDownStartPointY_ValueChanged);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxMessage.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxMessage.Location = new System.Drawing.Point(0, 119);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(382, 134);
            this.textBoxMessage.TabIndex = 3;
            this.textBoxMessage.Text = "msg";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(236, 24);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(80, 28);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(236, 68);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(80, 28);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(327, 213);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(30, 28);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "X";
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
            this.groupBoxStartPoint.Size = new System.Drawing.Size(197, 109);
            this.groupBoxStartPoint.TabIndex = 7;
            this.groupBoxStartPoint.TabStop = false;
            this.groupBoxStartPoint.Text = "Start point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y:";
            // 
            // timerRefreshUI
            // 
            this.timerRefreshUI.Interval = 1000;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.groupBoxStartPoint);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxMessage);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPointY)).EndInit();
            this.groupBoxStartPoint.ResumeLayout(false);
            this.groupBoxStartPoint.PerformLayout();
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
    }
}

