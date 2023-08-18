using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homePage1
{
    public partial class ProfileWebBobForm1 : Form
    {
        public ProfileWebBobForm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage1Form1 ob = new HomePage1Form1();
            ob.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServicesPageForm1 ob = new ServicesPageForm1();
            ob.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            WebDevelopmentPageForm1 ob = new WebDevelopmentPageForm1();
            ob.Show();

        }
    }
}
