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
        public int second;
        public Form1()
        {
            InitializeComponent();
            second = 0;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}秒", second);
            second++;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnStart__Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Text = String.Format("{0}秒", second);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            second = 0;
            label1.Text = String.Format("{0}秒", second);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form_Layouts = new Form_Layouts();
            form_Layouts.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}