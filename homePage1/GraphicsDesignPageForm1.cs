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
    public partial class GraphicsDesignPageForm1 : Form
    {
        public GraphicsDesignPageForm1()
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
            ProfileGraphicsSarfForm1 ob = new ProfileGraphicsSarfForm1();
            ob.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileGraphicsJaydaForm1 ob = new ProfileGraphicsJaydaForm1();
            ob.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileGraphicsHarisForm1 ob = new ProfileGraphicsHarisForm1();
            ob.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileGraphicsLisanForm1 ob = new ProfileGraphicsLisanForm1();
            ob.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileGraphicsAmberForm1 ob = new ProfileGraphicsAmberForm1();
            ob.Show();

        }
    }
}
