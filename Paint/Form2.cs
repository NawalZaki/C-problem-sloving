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
    public partial class Form2 : Form
    {
        private bool drag = false;
        int x = 0, y = 0;
        Rectangle reg = new Rectangle(10, 10, 50, 50);
        public Form2()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            graph.FillRectangle(Brushes.Green, reg);
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (e.X > x && e.X < x + 50 && e.Y > y && e.Y < y + 50)
                {
                    x = e.X;
                    y = e.Y;
                    drag = true;
                }
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
              if (e.Button != MouseButtons.Left)
            {
                return;
            }
           
            if(drag == true)
            {
                reg = new Rectangle(e.X, e.Y, 50, 50);

                x = e.X;
            y = e.Y;
            Invalidate();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
