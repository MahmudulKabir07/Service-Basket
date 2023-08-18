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
    public partial class ServicesPageForm1 : Form
    {
        public ServicesPageForm1()
        {
            InitializeComponent();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void ServicesPageForm1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage1Form1 home = new HomePage1Form1();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WebDevelopmentPageForm1 ob = new WebDevelopmentPageForm1();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GraphicsDesignPageForm1 ob = new GraphicsDesignPageForm1();
            ob.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeTutorPageForm1 ob = new HomeTutorPageForm1();
            ob.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HandiCraftPageForm1 ob = new HandiCraftPageForm1();
            ob.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DressDesignPageForm1 ob = new DressDesignPageForm1();
            ob.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeMaidPageForm1 ob = new HomeMaidPageForm1();
            ob.Show();
        }
    }
}
