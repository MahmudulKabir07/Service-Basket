using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace homePage1
{
    public partial class LoginPageForm1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["jubo"].ConnectionString;

        public LoginPageForm1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            if (status == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;

            }
        }

        private void LoginPageForm1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from REGISTRATION_TABLE where USERNAME=@inputusername and PASS=@inputpassword";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@inputusername", textBox1.Text);
                cmd.Parameters.AddWithValue("@inputpassword", textBox2.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    HomePage1Form1 ob3 = new HomePage1Form1();
                    ob3.Show();
                }
                else
                {
                    MessageBox.Show("Login fail", "fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Login fail", "fail", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationPageForm1 ob4 = new RegistrationPageForm1();
            ob4.Show();
        }
    }
}
