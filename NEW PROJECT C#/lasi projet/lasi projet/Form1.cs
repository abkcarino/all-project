using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace lasi_projet
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AFU6OHB;Initial Catalog=LOG-IN;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username= txtusername.Text;
            user_password =txtpassword.Text;

            try
            {
                
                String querry = "SELECT * FROM login_new WHERE username ='" + txtusername.Text + "'AND password ='"+ txtpassword.Text+"'";
                SqlDataAdapter sda= new SqlDataAdapter(querry,conn);
               

  DataTable dTable = new DataTable();
                
                sda.Fill(dTable);
                
                if (dTable.Rows.Count>0)
                {
                   
                    username =txtusername.Text;
                    user_password =txtpassword.Text;
                    Home home = new Home();
                    
                    home.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("error");
                    txtpassword.Clear();
                    txtusername.Clear();
                    txtusername.Focus();

                }
            }
            catch {
                MessageBox.Show("error");
                txtpassword.Clear();
                txtusername.Clear();
                txtusername.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtpassword.Clear();
            txtusername.Clear();
            txtusername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
