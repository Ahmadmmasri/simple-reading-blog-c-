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
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int numberimage = 1;
        private void loadnextimage() {
            if (numberimage == 5)
            {
                numberimage = 1;
            }
            pictureBox_earth.ImageLocation = string.Format(@"image\{0}.jpg", numberimage);
            numberimage++;

        }
        private void logo_MouseEnter(object sender, EventArgs e)
        {
            logo.Size = new Size(180, 90);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Blegger_Click(object sender, EventArgs e)
        {
           Form2 reader = new Form2();


           reader.Show();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadnextimage();
        }

        private void About_Click(object sender, EventArgs e)
        {
        }

        private void logo_MouseLeave(object sender, EventArgs e)
        {
            logo.Size = new Size(140, 73);
        }

        private void About_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Group of students intresting in share reserches related in science in diffrent majors by help of some profissons", "Who are we", MessageBoxButtons.OK);
        }
    }
}
