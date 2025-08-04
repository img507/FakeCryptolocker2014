using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptolocker_2014_clone
{
    public partial class Form2 : Form
    {
        private Timer timer_1 = new Timer();

        public Form2()
        {
            InitializeComponent();
        }

        public int int_0 = 7200;

        public DateTime dateTime_0;

        private void Form2_Load(object sender, EventArgs e)
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
                timer_1.Stop();
                return;
            }
            label25.Text = timeSpan.Days.ToString();
            label6.Text = timeSpan.Hours.ToString();
            label8.Text = timeSpan.Minutes.ToString();
            label10.Text = timeSpan.Seconds.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            bool flag2 = false;
            bool flag3 = false;
            Form3 form = new Form3();
            if (comboBox1.SelectedIndex == 0)
            {
                if (textBox4.Text.Length == 64)
                {
                    flag3 = true;
                }
                else
                {
                    MessageBox.Show("Transaction ID must be 64 digits!", "BitCoin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (textBox1.Text.Length >= 12 && textBox1.Text.Length <= 16)
                {
                    flag = true;
                }
                else
                {
                    MessageBox.Show("Voucher code must be between 12 and 16 digits!", "MoneyPak", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (textBox2.Text.Length == 19 && textBox3.Text.Length == 19 && comboBox3.Text != "" && comboBox4.Text != "" && comboBox5.Text != "")
                {
                    flag2 = true;
                }
                else
                {
                    MessageBox.Show("Voucher code must be 19 digits and country must be selected!", "Ukash", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (flag || flag2 || flag3)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                form.Show();
                base.Hide();
            }
        }

        private void method_1()
        {
            panel3.Hide();
            panel3.Visible = false;
            panel4.Hide();
            panel4.Visible = false;
            panel2.Show();
            panel2.BringToFront();
        }

        private void method_2()
        {
            panel2.Hide();
            panel2.Visible = false;
            panel4.Hide();
            panel4.Visible = false;
            panel3.Show();
            panel3.BringToFront();
        }

        private void method_3()
        {
            panel2.Hide();
            panel2.Visible = false;
            panel3.Hide();
            panel3.Visible = false;
            panel4.Show();
            panel4.BringToFront();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                method_1();
                return;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                method_2();
                return;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                method_3();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://bitcoin.org/en/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://bitcoin.org/en/getting-started");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.ukash.com");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.moneypak.com");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.moneypak.com/storelocator.aspx");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://howtobuybitcoins.info/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            Form1 form = new Form1();
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
