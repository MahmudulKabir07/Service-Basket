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
    public partial class HandiCraftPageForm1 : Form
    {
        public HandiCraftPageForm1()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileHandiCraftsJacksonForm1 ob = new ProfileHandiCraftsJacksonForm1();
            ob.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
           ProfileHandiCraftsLeviForm1 ob = new ProfileHandiCraftsLeviForm1();
            ob.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileHandiCraftsSiennaForm1 ob = new ProfileHandiCraftsSiennaForm1();
            ob.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileHandiCraftsRoseForm1 ob = new ProfileHandiCraftsRoseForm1();
            ob.Show();

        }
    }
}
