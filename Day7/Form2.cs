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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (txt_Name.TextLength > 4)
            {
                lbl_chName.Visible = false;
            }
            else
            {
                lbl_chName.Visible = true;
            }
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            if (txt_Email.Text.Contains("@"))
            {
                lbl_chEmail.Visible = false;
            }
            else
            {
                lbl_chEmail.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                lbl_chHoppies.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                lbl_chHoppies.Visible = false;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                lbl_chHoppies.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {  
                lbl_chHoppies.Visible = false;
              
            }
            else
            {
                lbl_chHoppies.Visible = true;
         
            }
            if(lbl_chName.Visible==false&&lbl_chEmail.Visible==false&&lbl_chHoppies.Visible==false)
            {
                lbl_chValidation.Visible = true;
            }
            else
            {
                lbl_chValidation.Visible = false;
            }
            if(txt_Email.Text=="")
            {
                lbl_chEmail.Visible = true;
            }
            if(txt_Name.Text=="")
            {
                lbl_chName.Visible = true;
            }
        }
    }
}
