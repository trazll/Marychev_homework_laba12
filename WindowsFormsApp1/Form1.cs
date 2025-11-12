using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int clickCount = 0;
        private int seconds = 0;
        private bool isTimerRunning = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            clickCount++;
            lblClicks.Text = $"Кликов: {clickCount}";


            if (!isTimerRunning)
            {
                timer1.Start();
                isTimerRunning = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            int minutes = seconds / 60;
            int secs = seconds % 60;
            lblTimer.Text = $"Время: {minutes:00}:{secs:00}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clickCount = 0;
            seconds = 0;
            isTimerRunning = false;

            lblClicks.Text = "Кликов: 0";
            lblTimer.Text = "Время: 00:00";

            timer1.Stop();
        }

    }
}
