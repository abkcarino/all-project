using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace examenc_web
{
    public class Dbclass
    {
        //declaration des variables
        public SqlConnection con = new SqlConnection();
        public static DataTable dt = new DataTable();
        public static SqlCommand cmd;
        //public static SqlDataReader dr;
        public static SqlDataAdapter dr;



        //les methodes

        public void connecter()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)/*si el nest pas connecter*/
            {
                con.ConnectionString = @"Data Source=DESKTOP-AFU6OHB;Initial Catalog=ITEEM_EXAM;Integrated Security=True";
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
        public void remplirGV(GridView gv, string reqSQL)
        {
            //connecter();
            //dt.Clear();
            //cmd = new SqlCommand(reqSQL, con);
            //dr = cmd.ExecuteReader();            
            //dt.Load(dr);
            //gv.DataSource = dt;
            //gv.DataBind();
            //deconnecter();

            connecter();

            cmd = new SqlCommand(reqSQL, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            sda.Fill(ds);
            gv.DataSource = ds;
            gv.DataBind();

            deconnecter();

        }

    }
}