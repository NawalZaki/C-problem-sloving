using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                float value;
                value = float.Parse(txt_value.Text) / (1000);
                txt_result.Text = value.ToString();
            }
            else if(radioButton2.Checked)
            {
                double value2;
                value2 = double.Parse(txt_value.Text)*(0.0006213712);
                txt_result.Text = value2.ToString();
            }
            else if(radioButton3.Checked)
            {
                double value3;
                value3 = double.Parse(txt_value.Text) / (0.0006213712);
                txt_result.Text = value3.ToString();
            }
            else
            {
                int value4=0;
                txt_result.Text = value4.ToString();
            }

        }
    }
}
