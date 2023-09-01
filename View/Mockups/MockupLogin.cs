using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Mockups
{
    public partial class MockupLogin : Form
    {
        public MockupLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Width.ToString() + " " + this.Height.ToString());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
