using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4
{
    public partial class WebFormArticles : System.Web.UI.Page
    {
        ClassDB cdb=new ClassDB();
        
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {

 
                cdb.remplirDDL(DropDownList1,"select idcat, CONCAT (idcat,'-->',nomcat) as nom from categorie ","nom","idcat");


                cdb.remplirGV(GridView1, "select * from article");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string req = "insert into article values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + DropDownList1.SelectedValue + "')";
            cdb.insertRow(req);

            cdb.remplirGV(GridView1, "select * from article");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
}