using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N09310002
{
    public partial class Form2 : Form
    {
        public int second;
        public Form2()
        {
            InitializeComponent();
            second = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text =  String.Format("{0}秒",second);
            second++;
        }
    }
}
