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
    partial class frmCategory : Form
    {
        public Category myCategory;
        CategoryData mycategoryData;
        Team myTeam;
        frmTask f;
        public frmCategory()
        {
            InitializeComponent();
            myCategory = new Category();
            mycategoryData = new CategoryData();
            cmbTitle.DataSource = Enum.GetValues(typeof(CategoryTitle));
            foreach (Team t in Program.Teams)
                cmbTeam.Items.Add(t.Name);
        }
        private void fill_listview()
        {
            lstviwCategory.Items.Clear();
            foreach (Category c in myTeam.TeamCategories)
            {
                ListViewItem it = new ListViewItem(c.Title.ToString());
                it.SubItems.Add(c.Description);


                lstviwCategory.Items.Add(it);
            }
        }
        private void AddItem()
        {
            Category cat = new Category(myCategory.Title, myCategory.Description);
            myTeam.TeamCategories.Add(cat);
            fill_listview();
        }
        public void change(object t, EventArgs e)
        {
            myCategory = f.myCategory;
            txtDescription.Text = myCategory.Title.ToString();
            cmbTitle.SelectedItem = myCategory.Title.ToString();
            this.TopMost = true;


        }
        private void frmCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            AddItem();
            txtDescription.Text = string.Empty;
            cmbTitle.SelectedIndex = -1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            f = new frmTask(myTeam, myCategory);
            f.MyEvent += change;
            f.Show();
            this.TopMost = false;
            f.TopMost = true;

        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myTeam.TeamCategories.Count; i++)
                if (myCategory.ID == myTeam.TeamCategories[i].ID)
                    myTeam.TeamCategories.RemoveAt(i);

            fill_listview();


            txtDescription.Text = string.Empty;
            cmbTitle.SelectedIndex = -1;
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            if (txtDescription.Text == "Description Of Category")
            {
                txtDescription.Text = "";
                txtDescription.ForeColor = Color.Black;
            }
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                txtDescription.Text = "Description Of Category";
                txtDescription.ForeColor = Color.Silver;
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myTeam.TeamCategories.Count; i++)
                if (myCategory.ID == myTeam.TeamCategories[i].ID)
                    myTeam.TeamCategories[i] = myCategory;
            fill_listview();
        }

        private void lstviwCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Category c in myTeam.TeamCategories)
            {
                if (c.Title.ToString() == lstviwCategory.Items[lstviwCategory.FocusedItem.Index].SubItems[0].Text)
                    myCategory = new Category(c);
            }
            cmbTitle.Text = myCategory.Title.ToString();
            txtDescription.Text = myCategory.Description;
        }

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTitle.SelectedItem != null)
                myCategory.Title = (CategoryTitle)cmbTitle.SelectedItem;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            myCategory.Description = txtDescription.Text;
        }

        private void cmbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Team t in Program.Teams)
                if (t.Name == cmbTeam.SelectedItem.ToString())
                    myTeam = t;
            fill_listview();
        }
    }
}
