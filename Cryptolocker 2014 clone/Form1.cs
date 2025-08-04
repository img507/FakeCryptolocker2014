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
    public partial class Form1 : Form
    {
        private Timer timer_0 = new Timer();

        public Form1()
        {
            InitializeComponent();
        }

        public int int_0 = 7200;

        public DateTime dateTime_0;

        private void method_0()
        {
            listView1.Visible = true;
            listView1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTime_0 = DateTime.Now.AddSeconds((double)int_0);
            timer_0.Interval = 1000;
            timer_0.Tick += timer_1_Tick;
            timer_0.Start();
            label3.Text = dateTime_0.ToString();
            
        }

        private void timer_1_Tick(object sender, EventArgs e)
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
            Form2 form3 = new Form2();
            form3.Show();
            base.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            method_0();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            listView1.Visible = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
            base.OnFormClosing(e);
        }

    }
}
