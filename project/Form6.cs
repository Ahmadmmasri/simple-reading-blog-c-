using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form6 : MaterialSkin.Controls.MaterialForm
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void color_Move(object sender, EventArgs e)
        {
            
        }

        private void color_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            textBox1.Text = x+"";
            textBox2.Text = y + "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
