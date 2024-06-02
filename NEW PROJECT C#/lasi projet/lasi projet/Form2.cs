using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace lasi_projet
{
    public partial class signupforme : Form
    {
        public signupforme()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AFU6OHB;Initial Catalog=LOG-IN;Integrated Security=True");

        private void label4_Click(object sender, EventArgs e)
        {
            loginform lf = new loginform();
            lf.Show();
            this.Hide();



        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtpassword.Clear();
            txtusername.Clear();
            txtusername.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text!="" && txtpassword.Text!="" && textBox1.Text!="")
            {
                if (textBox1.Text ==txtpassword.Text)
                {
                    try
                    {
                        conn.Open();
                        string queru = "INSERT INTO login_new ( username,password) VALUES ('" + txtusername.Text + "' ,'" + txtpassword.Text + "')";
                        SqlDataAdapter sda = new SqlDataAdapter(queru, conn);
                        sda.SelectCommand.ExecuteNonQuery();
                        MessageBox.Show("new user is succesfully registred");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    txtpassword.Clear();
                    textBox1.Clear();
                    MessageBox.Show("password inncorrect");
                }


            }
            else
            {
                MessageBox.Show("username and password are vide");

            }


        }
    }
}
 