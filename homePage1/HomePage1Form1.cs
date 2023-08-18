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
    public partial class HomePage1Form1 : Form
    {
        public HomePage1Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            groupBox2.Visible = true;

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {

            groupBox2.Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Leave(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServicesPageForm1 service = new ServicesPageForm1();
            service.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPageForm1 login = new LoginPageForm1();
            login.Show();
        }



        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginPageForm1 ob = new LoginPageForm1();
            ob.Show();
        }
    }
}
