using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lasi_projet
{
    public partial class Home : Form 
    {
        public Home()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AFU6OHB;Initial Catalog=LOG-IN;Integrated Security=True");


     public string namedata { get; set; }
        private void Home_Load(object sender, EventArgs e)
        {
            int a = 3;
            a = a^3;
            MessageBox.Show(Convert.ToString(a));
            //String requat = "SELECT username FROM login_new WHERE username  ";
            //SqlCommand cmd = new SqlCommand(requat, conn);

            //SqlDataReader rad;
            //rad = cmd.ExecuteReader();
            //SqlDataReader sdr=cmd.ExecuteReader();
            //rad = sdr;




            //if (rad.Read())
            //{
            //    string user = rad.GetValue(1).ToString();
            //    label1.Text = "welcome back" + user;
            //}


            



        }
    }
}
