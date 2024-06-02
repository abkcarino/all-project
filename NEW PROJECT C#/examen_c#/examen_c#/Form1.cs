using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace examen_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 cibd = new Class1();

        private void Form1_Load(object sender, EventArgs e)
        {

            cibd.remplirGV(dataGridView1, "select * from etudiant");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((cibd.verifierTbPanel(panel1)) || (comboBox1.Text==""))
            {
                MessageBox.Show("Verifier les champs ...!");
            }
            
            else 
            {
                // Appeler la méthode inserer
                string req = "insert into etudiant values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text
                   + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "')";
               
                cibd.insererEtudiant(req);
                cibd.viderPanel(panel1);
               
                cibd.remplirGV(dataGridView1, "select * from etudiant");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
