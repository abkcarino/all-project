using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsAppS2
{
    public partial class FormChangemetMotDePasse : Form
    {
        ClassLogin cl;
        public const string nomFichier= "loginClasse";
        public FormChangemetMotDePasse()
        {
            InitializeComponent();
        }
        private void FormChangemetMotDePasse_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        private void btnCreFileTxt_Click(object sender, EventArgs e)
        {
            cl = new ClassLogin(nomFichier);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl = new ClassLogin();
            cl.suppFichierText(nomFichier);           
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            
        }

      

        private void btnAnnulerSauv_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            cl.viderPanel(panel1);
        }

        private void btnSauvgarder_Click(object sender, EventArgs e)
        {
            if (tbU.Text == "" || tbP.Text == "" || tbPC.Text == "")
            {
                MessageBox.Show("Verifier le remplissage des champs !!.");
            }
            else if (tbP.Text != tbPC.Text)
            {
                MessageBox.Show("Verifier le mot de passe !!.");
            }
            else
            {
                cl = new ClassLogin();
                cl.remplissageFichierTxt(nomFichier, tbU.Text, tbP.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cl = new ClassLogin();
            cl.recupInfo(nomFichier);
        }
    }
}
