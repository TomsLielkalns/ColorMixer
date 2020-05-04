namespace ColorMixer
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
            this.RedBox = new System.Windows.Forms.PictureBox();
            this.BlueBox = new System.Windows.Forms.PictureBox();
            this.GreenBox = new System.Windows.Forms.PictureBox();
            this.RandomRed = new System.Windows.Forms.Button();
            this.RandomGreen = new System.Windows.Forms.Button();
            this.RandomBlue = new System.Windows.Forms.Button();
            this.RandomMix = new System.Windows.Forms.Button();
            this.RedSlider = new System.Windows.Forms.TrackBar();
            this.GreenSlider = new System.Windows.Forms.TrackBar();
            this.BlueSlider = new System.Windows.Forms.TrackBar();
            this.Reset = new System.Windows.Forms.Button();
            this.RedTimer = new System.Windows.Forms.Timer(this.components);
            this.RedTimerStart = new System.Windows.Forms.Button();
            this.GreenTimerStart = new System.Windows.Forms.Button();
            this.BlueTimerStart = new System.Windows.Forms.Button();
            this.GreenTimer = new System.Windows.Forms.Timer(this.components);
            this.BlueTimer = new System.Windows.Forms.Timer(this.components);
            this.StopParty = new System.Windows.Forms.Button();
            this.StartParty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // RedBox
            // 
            this.RedBox.Location = new System.Drawing.Point(12, 12);
            this.RedBox.Name = "RedBox";
            this.RedBox.Size = new System.Drawing.Size(200, 200);
            this.RedBox.TabIndex = 0;
            this.RedBox.TabStop = false;
            // 
            // BlueBox
            // 
            this.BlueBox.Location = new System.Drawing.Point(588, 12);
            this.BlueBox.Name = "BlueBox";
            this.BlueBox.Size = new System.Drawing.Size(200, 200);
            this.BlueBox.TabIndex = 1;
            this.BlueBox.TabStop = false;
            // 
            // GreenBox
            // 
            this.GreenBox.Location = new System.Drawing.Point(304, 12);
            this.GreenBox.Name = "GreenBox";
            this.GreenBox.Size = new System.Drawing.Size(200, 200);
            this.GreenBox.TabIndex = 2;
            this.GreenBox.TabStop = false;
            // 
            // RandomRed
            // 
            this.RandomRed.Location = new System.Drawing.Point(12, 231);
            this.RandomRed.Name = "RandomRed";
            this.RandomRed.Size = new System.Drawing.Size(200, 66);
            this.RandomRed.TabIndex = 3;
            this.RandomRed.Text = "Random Red";
            this.RandomRed.UseVisualStyleBackColor = true;
            this.RandomRed.Click += new System.EventHandler(this.RandomRed_Click);
            // 
            // RandomGreen
            // 
            this.RandomGreen.Location = new System.Drawing.Point(304, 231);
            this.RandomGreen.Name = "RandomGreen";
            this.RandomGreen.Size = new System.Drawing.Size(200, 66);
            this.RandomGreen.TabIndex = 4;
            this.RandomGreen.Text = "Random Green";
            this.RandomGreen.UseVisualStyleBackColor = true;
            this.RandomGreen.Click += new System.EventHandler(this.RandomGreen_Click);
            // 
            // RandomBlue
            // 
            this.RandomBlue.Location = new System.Drawing.Point(588, 231);
            this.RandomBlue.Name = "RandomBlue";
            this.RandomBlue.Size = new System.Drawing.Size(200, 66);
            this.RandomBlue.TabIndex = 5;
            this.RandomBlue.Text = "Random Blue";
            this.RandomBlue.UseVisualStyleBackColor = true;
            this.RandomBlue.Click += new System.EventHandler(this.RandomBlue_Click);
            // 
            // RandomMix
            // 
            this.RandomMix.Location = new System.Drawing.Point(12, 515);
            this.RandomMix.Name = "RandomMix";
            this.RandomMix.Size = new System.Drawing.Size(776, 66);
            this.RandomMix.TabIndex = 6;
            this.RandomMix.Text = "Random Mix";
            this.RandomMix.UseVisualStyleBackColor = true;
            this.RandomMix.Click += new System.EventHandler(this.RandomMix_Click);
            // 
            // RedSlider
            // 
            this.RedSlider.Location = new System.Drawing.Point(12, 303);
            this.RedSlider.Maximum = 255;
            this.RedSlider.Name = "RedSlider";
            this.RedSlider.Size = new System.Drawing.Size(200, 45);
            this.RedSlider.TabIndex = 7;
            this.RedSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedSlider.Scroll += new System.EventHandler(this.RedSlider_Scroll);
            // 
            // GreenSlider
            // 
            this.GreenSlider.Location = new System.Drawing.Point(304, 303);
            this.GreenSlider.Maximum = 255;
            this.GreenSlider.Name = "GreenSlider";
            this.GreenSlider.Size = new System.Drawing.Size(200, 45);
            this.GreenSlider.TabIndex = 8;
            this.GreenSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenSlider.Scroll += new System.EventHandler(this.GreenSlider_Scroll);
            // 
            // BlueSlider
            // 
            this.BlueSlider.Location = new System.Drawing.Point(588, 303);
            this.BlueSlider.Maximum = 255;
            this.BlueSlider.Name = "BlueSlider";
            this.BlueSlider.Size = new System.Drawing.Size(200, 45);
            this.BlueSlider.TabIndex = 9;
            this.BlueSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueSlider.Scroll += new System.EventHandler(this.BlueSlider_Scroll);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(12, 587);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(776, 66);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "Reset colors";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // RedTimer
            // 
            this.RedTimer.Tick += new System.EventHandler(this.RedTimer_Tick);
            // 
            // RedTimerStart
            // 
            this.RedTimerStart.Location = new System.Drawing.Point(12, 354);
            this.RedTimerStart.Name = "RedTimerStart";
            this.RedTimerStart.Size = new System.Drawing.Size(200, 66);
            this.RedTimerStart.TabIndex = 11;
            this.RedTimerStart.Text = "Red Party";
            this.RedTimerStart.UseVisualStyleBackColor = true;
            this.RedTimerStart.Click += new System.EventHandler(this.RedTimerStart_Click);
            // 
            // GreenTimerStart
            // 
            this.GreenTimerStart.Location = new System.Drawing.Point(304, 354);
            this.GreenTimerStart.Name = "GreenTimerStart";
            this.GreenTimerStart.Size = new System.Drawing.Size(200, 66);
            this.GreenTimerStart.TabIndex = 12;
            this.GreenTimerStart.Text = "Green Party";
            this.GreenTimerStart.UseVisualStyleBackColor = true;
            this.GreenTimerStart.Click += new System.EventHandler(this.GreenTimerStart_Click);
            // 
            // BlueTimerStart
            // 
            this.BlueTimerStart.Location = new System.Drawing.Point(588, 354);
            this.BlueTimerStart.Name = "BlueTimerStart";
            this.BlueTimerStart.Size = new System.Drawing.Size(200, 66);
            this.BlueTimerStart.TabIndex = 13;
            this.BlueTimerStart.Text = "Blue Party";
            this.BlueTimerStart.UseVisualStyleBackColor = true;
            this.BlueTimerStart.Click += new System.EventHandler(this.BlueTimerStart_Click);
            // 
            // GreenTimer
            // 
            this.GreenTimer.Tick += new System.EventHandler(this.GreenTimer_Tick);
            // 
            // BlueTimer
            // 
            this.BlueTimer.Tick += new System.EventHandler(this.BlueTimer_Tick);
            // 
            // StopParty
            // 
            this.StopParty.Location = new System.Drawing.Point(418, 426);
            this.StopParty.Name = "StopParty";
            this.StopParty.Size = new System.Drawing.Size(370, 83);
            this.StopParty.TabIndex = 14;
            this.StopParty.Text = "Stop Party";
            this.StopParty.UseVisualStyleBackColor = true;
            this.StopParty.Click += new System.EventHandler(this.StopParty_Click);
            // 
            // StartParty
            // 
            this.StartParty.Location = new System.Drawing.Point(12, 426);
            this.StartParty.Name = "StartParty";
            this.StartParty.Size = new System.Drawing.Size(370, 83);
            this.StartParty.TabIndex = 15;
            this.StartParty.Text = "Start Party";
            this.StartParty.UseVisualStyleBackColor = true;
            this.StartParty.Click += new System.EventHandler(this.StartParty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.StartParty);
            this.Controls.Add(this.StopParty);
            this.Controls.Add(this.BlueTimerStart);
            this.Controls.Add(this.GreenTimerStart);
            this.Controls.Add(this.RedTimerStart);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.BlueSlider);
            this.Controls.Add(this.GreenSlider);
            this.Controls.Add(this.RedSlider);
            this.Controls.Add(this.RandomMix);
            this.Controls.Add(this.RandomBlue);
            this.Controls.Add(this.RandomGreen);
            this.Controls.Add(this.RandomRed);
            this.Controls.Add(this.GreenBox);
            this.Controls.Add(this.BlueBox);
            this.Controls.Add(this.RedBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RedBox;
        private System.Windows.Forms.PictureBox BlueBox;
        private System.Windows.Forms.PictureBox GreenBox;
        private System.Windows.Forms.Button RandomRed;
        private System.Windows.Forms.Button RandomGreen;
        private System.Windows.Forms.Button RandomBlue;
        private System.Windows.Forms.Button RandomMix;
        private System.Windows.Forms.TrackBar RedSlider;
        private System.Windows.Forms.TrackBar GreenSlider;
        private System.Windows.Forms.TrackBar BlueSlider;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Timer RedTimer;
        private System.Windows.Forms.Button RedTimerStart;
        private System.Windows.Forms.Button GreenTimerStart;
        private System.Windows.Forms.Button BlueTimerStart;
        private System.Windows.Forms.Timer GreenTimer;
        private System.Windows.Forms.Timer BlueTimer;
        private System.Windows.Forms.Button StopParty;
        private System.Windows.Forms.Button StartParty;
    }
}

