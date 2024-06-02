using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace exercice
{
    public class Class1
    {
        public SqlConnection con = new SqlConnection();
        public static DataTable dt = new DataTable();
        public static SqlCommand cmd;

        public void connecter()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)/*si el nest pas connecter*/
            {
                con.ConnectionString = @"Data Source=DESKTOP-AFU6OHB;Initial Catalog=Utilisateur;Integrated Security=True";
                con.Open();
            }
        }

        public void deconnecter()/*si el est connecter*/
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }
        public void insertRow(string reqInsert)
        {
            connecter();
            SqlCommand cmd = new SqlCommand(reqInsert, con);
            cmd.ExecuteNonQuery();
            deconnecter();
        }



    }
}