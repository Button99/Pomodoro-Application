using System;

namespace PomodoroApplication
{
    partial class Form1
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
            this.secondsLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.timeField = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Minutes = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SM = new System.Windows.Forms.Button();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(388, 92);
            this.secondsLabel.Margin = new System.Windows.Forms.Padding(35, 0, 35, 0);
            this.secondsLabel.MaximumSize = new System.Drawing.Size(50, 50);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(19, 13);
            this.secondsLabel.TabIndex = 0;
            this.secondsLabel.Tag = "";
            this.secondsLabel.Text = "00";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(44, 246);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(210, 44);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(466, 246);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(210, 44);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timeField
            // 
            this.timeField.Location = new System.Drawing.Point(313, 184);
            this.timeField.Name = "timeField";
            this.timeField.Size = new System.Drawing.Size(100, 20);
            this.timeField.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Minutes
            // 
            this.Minutes.AutoSize = true;
            this.Minutes.Location = new System.Drawing.Point(210, 187);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(44, 13);
            this.Minutes.TabIndex = 4;
            this.Minutes.Text = "Minutes";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // SM
            // 
            this.SM.Location = new System.Drawing.Point(621, 34);
            this.SM.Name = "SM";
            this.SM.Size = new System.Drawing.Size(134, 23);
            this.SM.TabIndex = 7;
            this.SM.Text = "Silent Mode: On";
            this.SM.UseVisualStyleBackColor = true;
            this.SM.Click += new System.EventHandler(this.SM_Click);
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(353, 92);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(19, 13);
            this.minutesLabel.TabIndex = 8;
            this.minutesLabel.Text = "00";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(310, 92);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(19, 13);
            this.hoursLabel.TabIndex = 9;
            this.hoursLabel.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.SM);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.timeField);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.secondsLabel);
            this.Name = "Form1";
            this.Text = "Pomodoro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox timeField;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Minutes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SM;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label hoursLabel;
    }
}

