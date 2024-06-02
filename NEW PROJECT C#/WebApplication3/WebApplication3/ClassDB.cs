using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public class ClassDB
    {


        //declaration des variables
        public SqlConnection con= new SqlConnection();
        public DataTable dt = new DataTable();
        public SqlCommand cmd;
        public SqlDataReader dr;



        //les methodes

        public void connecter()
        {
            if (con.State==ConnectionState.Closed || con.State==ConnectionState.Broken)
            {
                con.ConnectionString = @"Data Source=DESKTOP-AFU6OHB;Initial Catalog=webAsp2024;Integrated Security=True;";
            con.Open();
            }
        }

        public void deconnecter() 
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }




        }

        public void insertROW(string reqInsert )
        {
            connecter();            
            cmd=new SqlCommand(reqInsert,con);
            cmd.ExecuteNonQuery();
            deconnecter();

            
        }
        public void remplissageGV(GridView gv,string reqSQL)
        {
            connecter();
           dt.Clear();
            cmd= new SqlCommand(reqSQL,con);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            gv.DataBind();
            deconnecter();  
        }




    }
}