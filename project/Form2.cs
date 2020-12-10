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
    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            
                    }

        private void psychology_Click(object sender, EventArgs e)
        {
            Form4 r = new Form4();
            r.Show();
           
        }

        private void artificial_intelligence_Click(object sender, EventArgs e)
        {
            Form5 q = new Form5();
            q.Show();
        }

        private void Arts_Click(object sender, EventArgs e)
        {
            Form6 t = new Form6();
            t.Show();
        }
    }
}
