using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace examenc_web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Dbclass cdb = new Dbclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cdb.remplirGV(GridView1, "select * from etudiant");
            }
               
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

                string req = "insert into etudiant values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
                cdb.insertRow(req);

                cdb.remplirGV(GridView1, "select * from etudiant");
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
            }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
    }
}