using System;
using System.Drawing;
using System.Windows.Forms;

namespace calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool b = false;

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //  textBox1.Enabled = false;

            //  int.TryParse(textBox1.Text, out x);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void label14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void label13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void label17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void label16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void label15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void label19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void label18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void label8_Click(object sender, EventArgs e)
        {
           
            int n = textBox1.TextLength;

            string s = textBox1.Text;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == '*' && s[i] == s[i + 1])
                {
                    textBox1.ForeColor = Color.Red;
                    b = true;

                }
               
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "%";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int n = textBox1.TextLength;
            string s = textBox1.Text;
            string r = "";
            for (int i = 0; i < n - 1; i++)
            {
                r += s[i];
            }
            textBox1.Text = r;
            textBox1.Text = r;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

    }
}

