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
    public partial class FormTarget : Form
    {
        private DateTime _TaskStartTime;
        private int _TaskCount;

        public BoxTarget Model { get; } = new BoxTarget();

        public FormTarget()
        {
            InitializeComponent();

            this.numericUpDownStartPointX.Value = BoxTarget.StartPointX;
            this.numericUpDownStartPointY.Value = BoxTarget.StartPointY;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.SetVersionInfo();
            this.textBoxMessage.Text = this.Text + Environment.NewLine + Environment.NewLine;

            this.StartPosition = FormStartPosition.Manual;
            //this.Location = new Point(200, 100);
            this.Location = new Point(GlobalHub.Default.LastCloseLocationX, GlobalHub.Default.LastCloseLocationY);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalHub.Default.LastCloseLocationX = this.Location.X;
            GlobalHub.Default.LastCloseLocationY = this.Location.Y;
        }

        private void numericUpDownStartPointX_ValueChanged(object sender, EventArgs e)
        {
            BoxTarget.StartPointX = (int)this.numericUpDownStartPointX.Value;
        }

        private void numericUpDownStartPointY_ValueChanged(object sender, EventArgs e)
        {
            BoxTarget.StartPointY = (int) this.numericUpDownStartPointY.Value;
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

        //leotodo move to Ext class(by IOutputBox)
        private void Out(string message)
        {
           Out(this.textBoxMessage, message);
        }

        public static void Out(TextBox textBoxMessage, string message)
        {
            if (textBoxMessage.InvokeRequired)
            {
                textBoxMessage.BeginInvoke((Action<TextBox, string>)Out, textBoxMessage, message);
                return;
            }

            //labelTimerMessage.Text = message;
            textBoxMessage.Text += DateTime.Now.ToString("h:mm:ss ") + message + Environment.NewLine;
            textBoxMessage.SelectionStart = textBoxMessage.Text.Length;
            textBoxMessage.ScrollToCaret();

            textBoxMessage.BeginInvoke((Action)(() =>
            {
                //Thread.Sleep(200);
                //textBoxMessage.Focus();
                textBoxMessage.Select(textBoxMessage.Text.Length - Environment.NewLine.Length, 0);
            }));
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBoxMessage.Text = null;
            this.panelOut.AutoScrollPosition = new Point(0, 0); //scroll to top
            this._TaskCount = 0;
            this.DisableButtonShortTime(this.buttonClear);
        }

     
       

        private void panelOut_Click(object sender, EventArgs e)
        {
            _TaskCount++;
            this.Out($"pnl out #{_TaskCount}, ({Cursor.Position.X}, {Cursor.Position.Y})");
        }

        private void panelInner_Click(object sender, EventArgs e)
        {
            _TaskCount++;
            this.Out($"pnl inner #{_TaskCount}, ({Cursor.Position.X}, {Cursor.Position.Y})");
        }


        private void buttonTest_Click(object sender, EventArgs e)
        {
            _TaskCount++;
            this.Out($"btn 1 #{_TaskCount}, ({Cursor.Position.X}, {Cursor.Position.Y})");
        }
        private void buttonTest2_Click(object sender, EventArgs e)
        {
            _TaskCount++;
            this.Out($"btn 2 #{_TaskCount}, ({Cursor.Position.X}, {Cursor.Position.Y})");
        }


        private void buttonTest3_Click(object sender, EventArgs e)
        {
            _TaskCount++;
            this.Out($"btn 3 #{_TaskCount}, ({Cursor.Position.X}, {Cursor.Position.Y})");
        }

       
    }
}
