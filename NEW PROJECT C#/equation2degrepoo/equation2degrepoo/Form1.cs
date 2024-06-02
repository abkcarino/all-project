using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace equation2degrepoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
            {
                textBox1.Enabled = false;
             textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.Enabled = true;
              

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked==true && textBox1.Text!="" && textBox2.Text != "" && textBox3.Text != "") {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                Equation equation =new Equation(a,b,c);
                equation.eq2d();
            }
            else
            {
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                Equation equation = new Equation( b, c);
                equation.eq1d();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)  && (e.KeyChar!='.'))
            {
                e.Handled = true;
            }
            if((e.KeyChar =='.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
