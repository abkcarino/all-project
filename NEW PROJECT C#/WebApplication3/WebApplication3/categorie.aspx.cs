using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class categorie : System.Web.UI.Page
    {
        ClassDB dB= new ClassDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            dB.remplissageGV(GridView1, "SELECT * FROM categorie");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string req = " INSERT INTO categorie values ('" +  TextBox1.Text + "','" + TextBox2.Text + "')";
            dB.insertROW(req);
            dB.remplissageGV(GridView1, "SELECT * FROM categorie");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}