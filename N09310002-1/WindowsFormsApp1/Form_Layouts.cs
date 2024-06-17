using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form_Layouts : Form
    {
        public Form_Layouts()
        {
            InitializeComponent();
            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv", "時間,主食,配菜\n", Encoding.UTF8);

            File.WriteAllText("Temp.txt", "Hi\n");
            File.AppendAllText("Temp.txt", "歡迎光臨\n");
            string input = File.ReadAllText("Temp.txt");
            MessageBox.Show(input);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mainFood = "";
            string sideFood = "";

            foreach (Control c in panel1.Controls)
            {
                if(c is CheckBox) 
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        mainFood += c.Text + "";
                    }
                }
            }

            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        sideFood += c.Text + "";
                    }
                }
            }
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("yyyy/MM/dd HH;mm");
            File.AppendAllText("OrderData.csv", formattedDateTime + "," + mainFood + "," + sideFood + "\n", Encoding.UTF8);

            MessageBox.Show("主食:" + mainFood + Environment.NewLine + "配菜:" + sideFood);
        }
    }
}
