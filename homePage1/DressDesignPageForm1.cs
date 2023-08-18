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
    public partial class DressDesignPageForm1 : Form
    {
        public DressDesignPageForm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage1Form1 home = new HomePage1Form1();
            home.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServicesPageForm1 ob = new ServicesPageForm1();
            ob.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileDressSarahForm1 ob = new ProfileDressSarahForm1();
            ob.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           ProfileDressLiaForm1 ob = new ProfileDressLiaForm1();
            ob.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           ProfileDressKateForm1 ob = new ProfileDressKateForm1();
            ob.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileDressKatalieForm1 ob = new ProfileDressKatalieForm1();
            ob.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileDressNartimForm1 ob = new ProfileDressNartimForm1();
            ob.Show();

        }
    }
}
