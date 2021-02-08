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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            fill_listview();
        }
        private void fill_listview()
        {
            if (TraineeData.trainees_data_list.Count != 0)
            {    
                ListViewItem t;
                foreach (personal_data item in TraineeData.trainees_data_list)
                {
                    t = new ListViewItem(item.name);
                    t.SubItems.Add(item.phone.ToString());
                    t.SubItems.Add(item.birthdate.ToString());
                    listView1.Items.Add(t);
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Additem()
        {
            ListViewItem t = new ListViewItem(textBox1.Text);
            t.SubItems.Add(textBox2.Text);
            t.SubItems.Add(dateTimePicker1.Text);
            listView1.Items.Add(t);
            TraineeData.trainees_data_list.Add(new personal_data()
            {
                name = textBox1.Text,
                phone = int.Parse(textBox2.Text),
                birthdate = dateTimePicker1.Value
            });

        }
        private void button1_Click(object sender, EventArgs e)
        { 
            Additem();
            textBox1.Text = textBox2.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem t = new ListViewItem(textBox1.Text);
            t.SubItems.Add(textBox2.Text);
            t.SubItems.Add(dateTimePicker1.Text);
            int i = 0;
            foreach (int x in listView1.SelectedIndices)
            {
                i = int.Parse(x.ToString());
                TraineeData.trainees_data_list.RemoveAt(i);
                listView1.Items.RemoveAt(i);
            }
            listView1.Items.Insert(i, t);
            TraineeData.trainees_data_list.Insert(i, new personal_data()
            {
                name = textBox1.Text,
                phone = int.Parse(textBox2.Text),
                birthdate = dateTimePicker1.Value
            });

        }

        private void button4_Click(object sender, EventArgs e)
        {

            foreach (int x in listView1.SelectedIndices)
            {
                int i = int.Parse(x.ToString());
                TraineeData.trainees_data_list.RemoveAt(i);
                listView1.Items.RemoveAt(i);
              
            }
            textBox1.Text = textBox2.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem t in listView1.SelectedItems)
            {
                textBox1.Text = t.SubItems[0].Text;
                textBox2.Text = t.SubItems[1].Text.ToString();
                dateTimePicker1.Text = t.SubItems[2].Text.ToString();
            }
        }
    }
}
