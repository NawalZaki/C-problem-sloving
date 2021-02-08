using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day8_iTi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fillfirstlistbox();
            fillcombobox();
        }
        private void fillfirstlistbox()
        {

            foreach (trainer t in Trainee.all_trainees)
            {
                checkedListBox1.Items.Add(t);
            }
        }
        private void fillcombobox()
        {
            comboBox1.DataSource = Trainee.lab_trainees;
            comboBox1.DisplayMember = nameof(labs.num);
            comboBox1.ValueMember = nameof(labs.num);
        
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int i = int.Parse(comboBox1.SelectedValue.ToString()) - 1;
            foreach (trainer t in checkedListBox1.CheckedItems)
            {
                if (!checkedListBox2.Items.Contains(t))
                {
                    checkedListBox2.Items.Add(t);
                    Trainee.lab_trainees[i].lab_member.Add(t);
                }
            }
            for (int j = checkedListBox1.CheckedItems.Count - 1; j >= 0; j--)
            {
                checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[j]);

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            int i = int.Parse(comboBox1.SelectedValue.ToString()) - 1;
            foreach (trainer t in checkedListBox1.Items)
            {
                if (!checkedListBox2.Items.Contains(t))
                {
                    checkedListBox2.Items.Add(t);
                    Trainee.lab_trainees[i].lab_member.Add(t);
                }
            }

            checkedListBox1.Items.Clear();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            int i = int.Parse(comboBox1.SelectedValue.ToString()) - 1;
            foreach (trainer t in checkedListBox2.CheckedItems)
            {
                if (!checkedListBox1.Items.Contains(t))
                {
                    checkedListBox1.Items.Add(t);
                    Trainee.lab_trainees[i].lab_member.Remove(t);
                }
            }

            foreach (int t in checkedListBox2.SelectedIndices)
            {
                checkedListBox2.Items.RemoveAt(t);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int i = int.Parse(comboBox1.SelectedValue.ToString()) - 1;
            foreach (trainer t in checkedListBox2.Items)
            {
                if (!checkedListBox1.Items.Contains(t))
                { checkedListBox1.Items.Add(t); }
            }

            checkedListBox2.Items.Clear();
            Trainee.lab_trainees[i].lab_member.Clear();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int i = int.Parse(comboBox1.SelectedIndex.ToString());
            checkedListBox2.Items.Clear();
            foreach (trainer t in Trainee.lab_trainees[i].lab_member)
            {
                checkedListBox2.Items.Add(t);
            }

        }
    }
}
