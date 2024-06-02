using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppbdd
{
    internal class Classinstitutbd
    {
        SqlConnection con = new SqlConnection();
        //represente une connexion ouvere a une base de donnes 
        DataTable dt = new DataTable();
        //represente une table de donnes en memoire
        SqlCommand com = new SqlCommand();
        //represente des requetes sql ou des procedures stockes
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void connecter()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = @"Data Source=DESKTOP-AFU6OHB;Initial Catalog=""projet iteem"";Integrated Security=True";
                con.Open();
            }
        }
        private void deconnecter ()
        { 
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void remplirGV(DataGridView dgv ,string reqSql )
        {
            dt.Clear();
            connecter();
            com.Connection= con;
            com.CommandText= reqSql;
            sda.SelectCommand = com;
            sda.Fill(dt);
            dgv.DataSource = dt;
            deconnecter();
        }

        internal void remplirGV(object dgvEmployes, string v)
        {
            throw new NotImplementedException();
        }


        public void viderpanel(Panel l)
        {
            foreach (Control c in l.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
        public bool verifiertb(Panel l)
        {
            bool b = false;

            foreach (Control c in l.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text=="")
                    {
                        b = true;
                        break;

                    }
                }
            }
            return b;

        }
        public void insereremploye(string req)
        {
            connecter();
            com.CommandText = req;
            com.ExecuteNonQuery();
            deconnecter();
        }
    }
}
