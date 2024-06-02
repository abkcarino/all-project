using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Web;
using System.Web.UI.WebControls;

namespace TP4
{
    public class ClassDB
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
                con.ConnectionString = @"Data Source=DESKTOP-AFU6OHB;Initial Catalog=webAsp2024;Integrated Security=True;";
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
        public void remplirGV (GridView gv,string reqSQL)
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
           
                deconnecter() ;

        }
        public void deleteRow(string reqSQL)
        {
            connecter();
            cmd = new SqlCommand(reqSQL, con);
            cmd.ExecuteNonQuery();
            deconnecter();
        }
        //modefier
        public void updateRow(string reqSQL)
        {
            connecter();
            cmd= new SqlCommand(reqSQL, con);
            cmd.ExecuteNonQuery();
            deconnecter();
        }

        public void remplirDDL(DropDownList ddl,string reqSQL,string dataTextField,string dataValueField)

        {

            //connecter();
            //dt.Clear();
            //cmd=new SqlCommand(reqSQL, con);
            //dr=cmd.ExecuteReader();
            //dt.Load(dr);
            //ddl.DataSource = dt;
            //ddl.DataTextField = dataTextField;
            //ddl.DataValueField = dataValueField;
            //ddl.DataBind();
            //deconnecter();
            connecter();
            
            cmd = new SqlCommand(reqSQL, con);
            SqlDataAdapter sda=new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            ddl.DataSource = ds;
            ddl.DataTextField = dataTextField;
            ddl.DataValueField = dataValueField;
            ddl.DataBind();
            deconnecter();

        }
    }
}       
   