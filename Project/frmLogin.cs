using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            if (txtUserName.Text == newUser.Name && txtPassword.Text == newUser.Password.ToString())
            {
                this.Visible = false;
                frmCategory frm = new frmCategory();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("UserName or Password is wrong !!");
            }
        }
    }
}
