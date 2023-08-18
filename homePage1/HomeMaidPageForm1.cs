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
    public partial class HomeMaidPageForm1 : Form
    {
        public HomeMaidPageForm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage1Form1 home = new HomePage1Form1();
            home.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomePage1Form1 home = new HomePage1Form1();
            home.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServicesPageForm1 ob = new ServicesPageForm1();
            ob.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
           ProfileMaidLiamForm1 ob = new ProfileMaidLiamForm1();
            ob.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileMaidMarkForm1 ob = new ProfileMaidMarkForm1();
            ob.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileMaidKallieForm1 ob = new ProfileMaidKallieForm1();
            ob.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileMaidJoeForm1 ob = new ProfileMaidJoeForm1();
            ob.Show();

        }
    }
}
