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
     partial class frmTask : Form
    {
        public Category myCategory;
        public Team myTeam;
        public event EventHandler MyEvent;
        public frmTask(Team t, Category c)
        {
            InitializeComponent();
            myCategory = c;
            myTeam = t;

            foreach (Category i in Program.Teams[0].TeamCategories)
            {
                cmbCategory.Items.Add(i.Title.ToString());
            }
            cmbCategory.SelectedItem = myCategory.Title.ToString();
        }

        private void frmTask_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MyEvent(this, new EventArgs());
            this.Close();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCategory.Title = (CategoryTitle)Enum.Parse(typeof(CategoryTitle), cmbCategory.SelectedItem.ToString(), true);

        }
    }
}
