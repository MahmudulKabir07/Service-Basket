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
using System.IO;

namespace homePage1
{
    public partial class RegistrationPageForm1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["jubo"].ConnectionString;
        public RegistrationPageForm1()
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPageForm1 ob = new LoginPageForm1();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into REGISTRATION_TABLE values(@FULLNAME,@USERNAME,@PASS,@EMAIL,@PHONE)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FULLNAME", textBox1.Text);
                cmd.Parameters.AddWithValue("@USERNAME", textBox2.Text);
                cmd.Parameters.AddWithValue("@PASS", textBox3.Text);
                cmd.Parameters.AddWithValue("@EMAIL", textBox5.Text);
                cmd.Parameters.AddWithValue("@PHONE", textBox6.Text);

                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Sign up Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sign up failed", "failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Sign up failed", "failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

       
    }
}
