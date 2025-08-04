using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptolocker_2014_clone
{
    public partial class Form3 : Form
    {
        private Timer timer_0 = new Timer();

        public Form3()
        {
            InitializeComponent();
        }

        public int int_0 = 7200;

        public DateTime dateTime_0;

        private void Form3_Load(object sender, EventArgs e)
        {
            dateTime_0 = DateTime.Now.AddSeconds((double)int_0);
            timer_0.Interval = 1000;
            timer_0.Tick += timer_0_Tick;
            timer_0.Start();
            label3.Text = dateTime_0.ToString();
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            int_0--;
            TimeSpan timeSpan = TimeSpan.FromSeconds((double)int_0);
            if (int_0 < 0)
            {
                timer_0.Stop();
                return;
            }
            label25.Text = timeSpan.Days.ToString();
            label6.Text = timeSpan.Hours.ToString();
            label8.Text = timeSpan.Minutes.ToString();
            label10.Text = timeSpan.Seconds.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Form4 form = new Form4();
            form.Show();
            base.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
            base.OnFormClosing(e);
        }

    }
}
