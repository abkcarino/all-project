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
        public FormChangemetMotDePasse()
        {
            InitializeComponent();
        }

        //Declaration des variables
        public string pathFile = Path.GetDirectoryName(System.Reflection.
            Assembly.GetEntryAssembly().Location) +@"\login.txt";


        private void btnCreFileTxt_Click(object sender, EventArgs e)
        {

            if (!File.Exists(pathFile))
            {
                File.Create(pathFile);
                MessageBox.Show("Le fichier texte a ete bien cree .");
                }
            else MessageBox.Show("Le fichier texte il existe deja !! .");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(pathFile))
                {
                    File.Delete(pathFile);
                    MessageBox.Show("Le fichier texte a ete bien Supprime .");
                }
                else MessageBox.Show("Le fichiern'existe pas !! .");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  
            }
            //finally 
            //{
            //    MessageBox.Show("Fin");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            
        }

        private void FormChangemetMotDePasse_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnAnnulerSauv_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            foreach (Control c in panel1.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }
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
                if (File.Exists(pathFile))
                {
                    try
                    {
                        StreamWriter w = new StreamWriter(pathFile);

                        w.WriteLine(tbU.Text);
                        w.WriteLine(tbP.Text);
                        MessageBox.Show("Nom d'utilisateur et le mot de passe a ete modifiesb " +
                            "avec succes. !!.");
                        w.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else MessageBox.Show("Le fichiern'existe pas !! .");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(pathFile))
            {
                try
                {
                    StreamReader r = new StreamReader(pathFile);
                    string ligne = r.ReadLine();
                    if(ligne!=null)   {      MessageBox.Show("User = "+ligne);     }
                    ligne = r.ReadLine();
                    if (ligne != null)   {      MessageBox.Show("Password= "+ligne);       }
                    r.Close();
                    
                }
                catch (Exception ex)
                {            MessageBox.Show(ex.Message);              }
            }
            else MessageBox.Show("Le fichiern'existe pas !! .");
        }
    }
}
