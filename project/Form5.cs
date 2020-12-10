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
    public partial class Form5 : MaterialSkin.Controls.MaterialForm
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
                richTextBox2.Font = new Font("Tahoma", 14, FontStyle.Bold);
            else
                richTextBox2.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }

        private void Refrence_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
  System.Diagnostics.Process.Start("Chrome", "https://www.theguardian.com/theguardian/2011/may/12/deep-blue-beats-kasparov-1997");
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
