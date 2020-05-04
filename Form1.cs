using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixer
{
    public partial class Form1 : Form
    {
        int red = 0;
        int green = 0;
        int blue = 0;
        int redStep = 1;
        int greenStep = 1;
        int blueStep = 1;
        int redInterval = 0;
        int blueInterval = 0;
        int greenInterval = 0;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void RandomRed_Click(object sender, EventArgs e)
        {
            red = rand.Next(0, 256);
            RedSlider.Value = red;
            RedBox.BackColor = Color.FromArgb(red, 0, 0);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void RandomGreen_Click(object sender, EventArgs e)
        {
            green = rand.Next(0, 256);
            GreenSlider.Value = green;
            GreenBox.BackColor = Color.FromArgb(0, green, 0);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void RandomBlue_Click(object sender, EventArgs e)
        {
            blue = rand.Next(0, 256);
            BlueSlider.Value = blue;
            BlueBox.BackColor = Color.FromArgb(0, 0, blue);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void RandomMix_Click(object sender, EventArgs e)
        {
            RandomBlue_Click(sender, e);
            RandomGreen_Click(sender, e);
            RandomRed_Click(sender, e);
        }

        private void RedSlider_Scroll(object sender, EventArgs e)
        {
            UpdateRed();
        }

        private void GreenSlider_Scroll(object sender, EventArgs e)
        {
            UpdateGreen();
        }

        private void BlueSlider_Scroll(object sender, EventArgs e)
        {
            UpdateBlue();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            red = 0;
            green = 0;
            blue = 0;

            RedSlider.Value = red;
            GreenSlider.Value = green;
            BlueSlider.Value = blue;


            RedBox.BackColor = Color.FromArgb(red, green, blue);
            GreenBox.BackColor = Color.FromArgb(red, green, blue);
            BlueBox.BackColor = Color.FromArgb(red, green, blue);
            this.BackColor = Color.FromArgb(red, green, blue);
        }


        private void UpdateRed()
        {
            red = RedSlider.Value;
            RedBox.BackColor = Color.FromArgb(red, 0, 0);
            this.BackColor = Color.FromArgb(red, green, blue);
        }
        private void UpdateGreen()
        {
            green = GreenSlider.Value;
            GreenBox.BackColor = Color.FromArgb(0, green, 0);
            this.BackColor = Color.FromArgb(red, green, blue);
        }
        private void UpdateBlue()
        {
            blue = BlueSlider.Value;
            BlueBox.BackColor = Color.FromArgb(0, 0, blue);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void RedTimer_Tick(object sender, EventArgs e)
        {
            RedSlider.Value += redStep;
            if (RedSlider.Value == RedSlider.Maximum || RedSlider.Value == RedSlider.Minimum)
            {
                redStep *= -1;
            }
            UpdateRed();
        }
        private void GreenTimer_Tick(object sender, EventArgs e)
        {
            GreenSlider.Value += greenStep;
            if (GreenSlider.Value == GreenSlider.Maximum || GreenSlider.Value == GreenSlider.Minimum)
            {
                greenStep *= -1;
            }
            UpdateGreen();
        }
        private void BlueTimer_Tick(object sender, EventArgs e)
        {
            BlueSlider.Value += blueStep;
            if (BlueSlider.Value == BlueSlider.Maximum || BlueSlider.Value == BlueSlider.Minimum)
            {
                blueStep *= -1;
            }
            UpdateBlue();
        }

        private void RedTimerStart_Click(object sender, EventArgs e)
        {
            redInterval = rand.Next(1, 30);
            RedTimer.Interval = redInterval;
            RedTimer.Start();
        }

        private void GreenTimerStart_Click(object sender, EventArgs e)
        {
            greenInterval = rand.Next(1, 30);
            GreenTimer.Interval = greenInterval;
            GreenTimer.Start();
        }

        private void BlueTimerStart_Click(object sender, EventArgs e)
        {
            blueInterval = rand.Next(1, 30);
            BlueTimer.Interval = blueInterval;
            BlueTimer.Start();
        }

        private void StopParty_Click(object sender, EventArgs e)
        {
            RedTimer.Stop();
            GreenTimer.Stop();
            BlueTimer.Stop();
        }

        private void StartParty_Click(object sender, EventArgs e)
        {
            RedTimerStart_Click(sender, e);
            GreenTimerStart_Click(sender, e);
            BlueTimerStart_Click(sender, e);
        }
    }
}
