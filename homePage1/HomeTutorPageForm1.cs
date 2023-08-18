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
    public partial class HomeTutorPageForm1 : Form
    {
        public HomeTutorPageForm1()
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

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileTutorThomasForm1 ob = new ProfileTutorThomasForm1();
            ob.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileTutorCharlesForm1 ob = new ProfileTutorCharlesForm1();
            ob.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileTutorJaxonForm1 ob = new ProfileTutorJaxonForm1();
            ob.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
             ProfileTutorPhillipForm1 ob = new ProfileTutorPhillipForm1();
            ob.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
           ProfileTutorSammuelForm1 ob = new ProfileTutorSammuelForm1();
            ob.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileTutorAlysonForm1 ob = new ProfileTutorAlysonForm1();
            ob.Show();

        }
    }
}
