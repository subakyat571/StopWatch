using System;
using System.Timers;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {

        private System.Timers.Timer timer = new();
        private int h, m, s, ms;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer.Interval = 1;
            timer.Elapsed += OnTimeEvent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

            timer.Start();
        }

        private void startBTN_Click(object sender, EventArgs e)
        {

            timer.Start();
        }

        private void stopBTN_Click(object sender, EventArgs e)
        {

            timer.Stop();
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {

            timer.Stop();
            h = 0;
            m = 0;
            s = 0;
            ms = 0;
            label1.Text = "00:00:00:00";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {

            Invoke(new Action(() =>
            {
                ms += 1;
                if (ms == 100)
                {
                    ms = 0;
                    s += 1;
                }
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }

                label1.Text = string.Format("{0}:{1}:{2}:{3}",
                    h.ToString().PadLeft(2, '0'),
                    m.ToString().PadLeft(2, '0'),
                    s.ToString().PadLeft(2, '0'),
                    ms.ToString().PadLeft(2, '0'));
            }));




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
