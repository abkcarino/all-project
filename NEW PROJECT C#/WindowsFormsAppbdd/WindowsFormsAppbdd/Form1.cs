using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppbdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Classinstitutbd cibd = new Classinstitutbd();
        private void Form1_Load(object sender, EventArgs e)
        {
            cibd.remplirGV(dataGridView1, "select * from employe");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cibd.viderpanel(panel1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cibd.verifiertb(panel1))
            {
                MessageBox.Show("ecccv");

            }else if(textBox7.Text != textBox8.Text){
                MessageBox.Show("mot");


            }
            else
            {
                string req = "insert into employe values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.Date + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "'";
                cibd.insereremploye(req);
                cibd.viderpanel(panel1);
                dateTimePicker1.Value=DateTime.Now;
                cibd.remplirGV(dataGridView1, "select * from employe");



            }
        }
    }
}
