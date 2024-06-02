using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebFormtp1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    DropDownList.Itemes.add
            //}
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<h3>" + TextBox1.Text + "</h3><hr>");
            Response.Write("<script>alert('cours asp.net c#"+TextBox1.Text+"')</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string str = "";
            if (CheckBox1.Checked)
            {
                sb.Append(CheckBox1.Text + "");
                str += CheckBox1.Text;
            }
            if (CheckBox2.Checked)
            {
                sb.Append(CheckBox2.Text + "");
                str += CheckBox2.Text;
            }
            if (CheckBox3.Checked)
            {
                sb.Append(CheckBox3.Text + "");
                str += CheckBox3.Text;
            }
            if (CheckBox4.Checked)
            {
                sb.Append(CheckBox4.Text + "");
                str += CheckBox4.Text;
            }
            if (CheckBox5.Checked)
            {
                sb.Append(CheckBox5.Text + "");
                str += CheckBox5.Text;
            }
            if (CheckBox6.Checked)
            {
                sb.Append(CheckBox6.Text + "");
                str += CheckBox6.Text;
            }
            if (CheckBox7.Checked)
            {
                sb.Append(CheckBox7.Text + "");
                str += CheckBox7.Text;
            }
            
            Response.Write("les jour:"+str);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in ListBox1.Items)

            {
                if (li.Selected)
                {
                    Response.Write("text =" + li.Text + "<br>");
                    Response.Write("value =" + li.Value + "<br>");
                    Response.Write("index =" + ListBox1.Items.IndexOf(li).ToString() + "<br>");
                    Response.Write( "---------------------------------------------<br>");
                }


            }
        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox2.Items.Clear();
            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    Response.Write(li);
                    ListBox2.Items.Add(li);
                }
            }
            if (CheckBoxList1.SelectedIndex==-1)
            {
                Label2.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                Label2.ForeColor = System.Drawing.Color.Green;
            }
            Label2.Text=ListBox2.Items.Count.ToString()+" langue(s) selectionnee(s)";    
        }
    }
}