using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitCliker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            text_x.Text = "";
            text_y.Text = "";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Cursor.Position.X;
            y= Cursor.Position.Y;
            text_x.Text += x.ToString() + Environment.NewLine;
            text_y.Text += y.ToString() + Environment.NewLine;
        }
    }
}
