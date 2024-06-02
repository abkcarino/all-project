using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (radioButton2.Checked==false)
            {
                label6.Visible = false;

                label7.Visible = false;
                textBox3.Visible = false;
                label8.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum =  23;
            numericUpDown1.Increment = 5;
            numericUpDown1.ReadOnly = true;
            monthCalendar1.MaxSelectionCount = 365;
            monthCalendar1.ShowToday=true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean boolmessagerror = false;
            if (comboBox1.SelectedIndex==-1 ||  comboBox2.SelectedIndex==-1 || comboBox1.SelectedIndex==comboBox2.SelectedIndex)
            {
                MessageBox.Show("veullez verifier : le lieu de depart et (ou) arrive !.\n");
                boolmessagerror=true;
            }
            if (!radioButton5.Checked && !radioButton6.Checked)
            {
                MessageBox.Show("veullez verifier : le aller simple ou avec retour.\n");
                boolmessagerror=true;
            }
            string depuis =comboBox1.Text;
            string a = comboBox2.Text;
            string nom=textBox1.Text;
            string prenom=textBox2.Text;
            string ar;
            if (radioButton6.Checked) ar = "aller simple";
            if (radioButton5.Checked) ar = "aller RETEUR";







            if (boolmessagerror==false)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt=dateTimePicker1.Value;
            dateTimePicker2.MinDate = dt;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "num ci:";
            label6.Visible = true;
            label7.Text = "date de delivrance de ci :";
            textBox3.Visible = true;
            label7.Visible = true;
            label8.Text = " date d'expiration ci : ";
            label8.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
        }
    }
}
