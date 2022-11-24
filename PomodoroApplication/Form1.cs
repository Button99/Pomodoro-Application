using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroApplication
{
    public partial class Form1 : Form
    {
        int seconds;
        Boolean hasElapsed = true;
        Boolean flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled && hasElapsed)
            {
                seconds = Convert.ToInt32(timeField.Text) * 60;
                timeField.Enabled = false;
                hasElapsed = false;
                flag = true;
                timer1.Start();
            }
            else if(!hasElapsed)
            {
                timer1.Start();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timerLabel.Text = seconds--.ToString();
                    if (seconds < 0 && flag)
                    {
                        timer1.Stop();
                        timerLabel.Text = "Time finished";
                        hasElapsed = true;
                        timeField.Enabled = true;
                        MessageBox.Show("Time has elapsed!");
                    }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerLabel.Text = "000";
            hasElapsed = true;
            timeField.Enabled = true;
        }
    }
}
