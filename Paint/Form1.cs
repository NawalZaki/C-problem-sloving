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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics Draw = this.CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                Draw.FillEllipse(Brushes.Red, e.X, e.Y, 40, 40);
            }
            else if (e.Button == MouseButtons.Right)
            {
                Draw.FillEllipse(Brushes.White, e.X, e.Y, 40, 40) ;
            }
        }
    }
}
