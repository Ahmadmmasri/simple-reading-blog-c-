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
    public partial class Form4 : MaterialSkin.Controls.MaterialForm
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", "https://www.psychologytoday.com/us/blog/the-mysteries-love/201610/why-we-obsess-over-people-who-dont-want-us");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", "https://allthatsinteresting.com/death-from-laughter-chrysippus");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", "https://www.manrepeller.com/2017/04/benefits-of-laughter.html?fbclid=IwAR3rjrCBLh3VgeoDSP7FyW4EQaQ6gfj8huMGSo5qJg1SBMSFV8B4RNi-4sE");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", "https://www.mayoclinic.org/diseases-conditions/pseudobulbar-affect/symptoms-causes/syc-20353737?fbclid=IwAR0jBokaql4fy8PGSPZJM2BJ8FnfBrva_n8JEQw2c5mdnIxXHneuQxwOZDY");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", "http://www.bbc.com/future/story/20150320-why-do-we-laugh-inappropriately?fbclid=IwAR3QG45c9Knwb6S9SmMFfFg8p7Nd1u6hLSePfdD2YK4P7BsVj0No73hTlAM");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", "https://abcnews.go.com/Health/deal-comedians-depression/story?id=24945911");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", "https://www.psychologytoday.com/us/blog/humor-sapiens/201209/when-do-tragedies-become-funny");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            System.Diagnostics.Process.Start("Chrome", "https://www.psychologytoday.com/us/blog/humor-sapiens/201805/humor-may-not-be-so-good-your-health");
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Form4.ActiveForm.Close();
        }
    }
}
