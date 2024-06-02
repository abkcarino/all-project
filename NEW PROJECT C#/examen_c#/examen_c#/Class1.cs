using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_c_
{
    internal class Class1
    {
        SqlConnection con = new SqlConnection();
        
        DataTable dt = new DataTable();
        
        SqlCommand com = new SqlCommand();
        
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void connecter()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = @"Data Source=DESKTOP-AFU6OHB;Initial Catalog=ITEEM;Integrated Security=True";
                con.Open();
            }
        }
        private void deconnecter()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void remplirGV(DataGridView dgv, string reqSql)
        {
            dt.Clear();
            connecter();
            com.Connection = con;
            com.CommandText = reqSql;
            sda.SelectCommand = com;
            sda.Fill(dt);
            dgv.DataSource = dt;
            deconnecter();
        }
        public void insererEtudiant(string req)
        {
            connecter();
            com.CommandText = req;
            com.ExecuteNonQuery();
            deconnecter();
        }
        public bool verifierTbPanel(Panel p)
        {
            Boolean b = false;
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "") { b = true; }
                }
                if (b) break;

            }
            return b;
        }
        public void viderPanel(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
        //public bool verifiermat(string m)
        //{
        //    bool t = false;
        //    string req = "select mat from etudiant";
        //    connecter();
        //    com.CommandText = req;
        //  string z=  com.ExecuteNonQuery().ToString();
        //    deconnecter();
        //    if (z==m)
        //    {
        //        t = true; 
        //    }



        //    return t;
        //}
    }
}
