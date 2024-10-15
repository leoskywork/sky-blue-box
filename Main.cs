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
    public partial class Main : Form
    {
        private DateTime _TaskStartTime;

        public MainBox Model { get; } = new MainBox();

        public Main()
        {
            InitializeComponent();

            this.numericUpDownStartPointX.Value = MainBox.StartPointX;
            this.numericUpDownStartPointY.Value = MainBox.StartPointY;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.SetVersion();
            this.textBoxMessage.Text = this.Text + Environment.NewLine + Environment.NewLine;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void numericUpDownStartPointX_ValueChanged(object sender, EventArgs e)
        {
            MainBox.StartPointX = (int)this.numericUpDownStartPointX.Value;
        }

        private void numericUpDownStartPointY_ValueChanged(object sender, EventArgs e)
        {
            MainBox.StartPointY = (int) this.numericUpDownStartPointY.Value;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            _TaskStartTime = DateTime.Now;
            SetButtonEnableStates(true);
            this.Out($"starting - ({MainBox.StartPointX},{MainBox.StartPointY})");
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
            if (this.InvokeRequired)
            {
                this.BeginInvoke((Action<string>)Out, message);
                return;
            }

            //this.labelTimerMessage.Text = message;
            this.textBoxMessage.Text += DateTime.Now.ToString("h:mm:ss ") + message + Environment.NewLine;
            textBoxMessage.SelectionStart = textBoxMessage.Text.Length;
            textBoxMessage.ScrollToCaret();

            this.BeginInvoke((Action)(() =>
            {
                //Thread.Sleep(200);
                //textBoxMessage.Focus();
                textBoxMessage.Select(textBoxMessage.Text.Length - Environment.NewLine.Length, 0);
            }));
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBoxMessage.Text = null;
            this.DisableButtonShortTime(this.buttonClear);
        }
    }
}
