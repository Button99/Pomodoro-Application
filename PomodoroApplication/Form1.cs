using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroApplication
{
    public partial class Form1 : Form
    {
        // TODO::Create Rest Mech.
        int seconds, minutes, hours;
        private String wavFile = "C:\\Users\\User\\source\\repos\\PomodoroApplication\\PomodoroApplication\\Properties\\FinishAlarm.wav";
        Boolean hasElapsed = true, silentMode= true;
        Boolean flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled && hasElapsed)
            {
                hours = Convert.ToInt32(timeField.Text) / 60;
                minutes = Convert.ToInt32(timeField.Text) % 60;
                minutesLabel.Text = minutes.ToString();
                hoursLabel.Text = hours.ToString();
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
                secondsLabel.Text = seconds--.ToString();
                // Need to make cases
                // Change minute case
                // Change hour case
                // Stop Case
                if (seconds < 0 && hours < 0 && minutes <0 && flag)
                {
                    timer1.Stop();
                    secondsLabel.Text = "Time finished";
                    if(silentMode == true) {
                        SoundPlayer sp = new SoundPlayer(wavFile);
                        sp.PlaySync();
                    }
                    hasElapsed = true;
                    timeField.Enabled = true;
                    MessageBox.Show("Time has elapsed!");
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            secondsLabel.Text = "00";
            hasElapsed = true;
            timeField.Enabled = true;
        }

        // Silent mode
        private void SM_Click(object sender, EventArgs e)
        {
            silentMode = !silentMode;
            if(silentMode == true)
            {
                SM.Text = "Silent mode: On";

            }
            else
            {
                SM.Text = "Silent mode: Off";
            }
        }
    }
}
