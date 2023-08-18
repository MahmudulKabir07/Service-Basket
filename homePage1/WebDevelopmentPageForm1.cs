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
    public partial class WebDevelopmentPageForm1 : Form
    {
        public WebDevelopmentPageForm1()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage1Form1 home = new HomePage1Form1();
            home.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServicesPageForm1 ob = new ServicesPageForm1();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileWebJoeForm1 ob = new ProfileWebJoeForm1();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileWebYelisForm1 ob = new ProfileWebYelisForm1();
            ob.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileWebBobForm1 ob = new ProfileWebBobForm1();
            ob.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileWebFinleyForm1 ob = new ProfileWebFinleyForm1();
            ob.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
           ProfileWebJordenForm1 ob = new ProfileWebJordenForm1();
            ob.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileWebMariaForm1 ob = new ProfileWebMariaForm1();
            ob.Show();

        }
    }
}
