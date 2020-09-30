using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ese01
{
    public partial class btnForm2 : Form
    {
        public btnForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnForm2B_Click(object sender, EventArgs e)
        {
            Form f2b = new Form();
            f2b.Text ="Aperta Form Dinamica";
            f2b.Show();
        }
    }
}
