using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form3 : Form
    {
        int withdPresent;
        int increment;
        public Form3()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.Width = 500;
            withdPresent = this.Width;
            increment = timer1.Interval;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Graphics gr = this.CreateGraphics();
            gr.FillRectangle(Brushes.Red, 0, 0, 50, 50);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            gr.Clear(Color.White);
            gr.FillRectangle(Brushes.Red, (increment), 0, 50, 50);

            if (increment >= withdPresent && increment > 0)
            {

                increment -= 70;
                withdPresent -= 70;
            }
            else if (increment < this.Width)
            {
                increment += 70;
                withdPresent = this.Width;
            }
        }
    }
}
