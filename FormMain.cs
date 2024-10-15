using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkyBlueBox
{
    public partial class FormMain : Form
    {
        private DateTime _TaskStartTime;
        private int _TaskCount;

        public BoxMain Model { get; } = new BoxMain();

        public FormMain()
        {
            InitializeComponent();

            this.numericUpDownStartPointX.Value = BoxMain.StartPointX;
            this.numericUpDownStartPointY.Value = BoxMain.StartPointY;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.SetVersionInfo();
            this.textBoxMessage.Text = this.Text + Environment.NewLine + Environment.NewLine;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void numericUpDownStartPointX_ValueChanged(object sender, EventArgs e)
        {
            BoxMain.StartPointX = (int)this.numericUpDownStartPointX.Value;
        }

        private void numericUpDownStartPointY_ValueChanged(object sender, EventArgs e)
        {
            BoxMain.StartPointY = (int) this.numericUpDownStartPointY.Value;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            _TaskStartTime = DateTime.Now;
            SetButtonEnableStates(true);
            this.Out($"starting - ({BoxMain.StartPointX},{BoxMain.StartPointY})");
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            SetButtonEnableStates(false);
            var passedString = (DateTime.Now - _TaskStartTime).ToString(@"h\:mm\:ss");
            this.Out($"stopping, spent: {passedString}");
        }

        private void SetButtonEnableStates(bool isRunning)
        {
            this.buttonStart.Enabled = !isRunning;
            this.buttonStop.Enabled = isRunning;
            this.groupBoxStartPoint.Enabled = !isRunning;
        }

        private void Out(string message)
        {
            FormTarget.Out(this.textBoxMessage, message);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBoxMessage.Text = null;
            this._TaskCount = 0;
            this.DisableButtonShortTime(this.buttonClear);
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            _TaskCount++;
            this.Out($"btn #{_TaskCount}");
        }

       

        private void panelTest_Click(object sender, EventArgs e)
        {
            _TaskCount++;
            this.Out($"pnl #{_TaskCount}");
        }
    }
}
