using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercice
{
  
    public partial class WebForm1 : System.Web.UI.Page
    {
        Class1 cdb = new Class1();
        private static Random random = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (genPassword.Checked==true)
            {
                int b = Convert.ToInt32(TextBox7.Text);
                string Q = Membership.GeneratePassword(b, b);
                password1.Text = Q;
                password2.Text = Q;
            }
            else
                password1.Text = "";
            password2.Text = "";

        }

        protected void Button1_Click(object sender, EventArgs e)

        {
            if (TextBox1.Text!="" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != ""  )
            {

            }

            string req = "insert into categorie values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "',,'" + TextBox6.Text + "')";
            cdb.insertRow(req);
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}