using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace move_label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point newPoint = new Point(label.Location.X + 5, label.Location.Y);
            label.Location = newPoint;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Point newPoint = new Point(label.Location.X, label.Location.Y-5);
            label.Location = newPoint;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Point newPoint = new Point(label.Location.X -5, label.Location.Y);
            label.Location = newPoint;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Point newPoint = new Point(label.Location.X , label.Location.Y+5);
            label.Location = newPoint;
        }
        private void label_Click(object sender, EventArgs e)
        {
            Point newPoint = new Point(label.Location.X, label.Location.Y);
            label.Location = newPoint;
        }
    }
}
