using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppS2
{
    class ClassLogin
    {
        //Attribus
        private string pathFile= Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        //Constructeurs
        public ClassLogin()
        {
            
        }
        public ClassLogin(string nomFichier)
        {
            string str=CheminComplet(nomFichier);
            if (!File.Exists(str))
            {
                File.Create(str);
                MessageBox.Show("Le fichier texte ( "+ nomFichier + " ) a ete bien cree .");
            }
            else MessageBox.Show("Le fichier texte ( " + nomFichier + " ) il existe deja !! .");
        }
        //Les methodes
        private string CheminComplet(string nomFichier)
        {
            pathFile += @"\";
            pathFile += nomFichier;
            pathFile += ".txt";
            return pathFile;

        }
        public void suppFichierText(string nomFichier)
        {
            string str = CheminComplet(nomFichier);
            try
            {
                if (File.Exists(str))
                {
                    File.Delete(str);
                    MessageBox.Show("Le fichier texte ( " + nomFichier + " ) a ete bien Supprime .");
                }
                else MessageBox.Show("Le fichier ( " + nomFichier + " ) n'existe pas !! .");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void remplissageFichierTxt(string nomFichier,string user,string pass)
        {
            string str = CheminComplet(nomFichier);
            MessageBox.Show(str);
            if (File.Exists(str))
                {
                    try
                    {
                        StreamWriter w = new StreamWriter(str);

                        w.WriteLine(user);
                        w.WriteLine(pass);
                        MessageBox.Show("Nom d'utilisateur et le mot de passe a ete modifiesb " +
                            "avec succes. !!.");
                        w.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else MessageBox.Show("Le fichier n'existe pas !! .");
            
        }

        public void recupInfo(string nomFichier)
        {
            string str = CheminComplet(nomFichier);

            if (File.Exists(str))
            {
                try
                {
                    StreamReader r = new StreamReader(str);
                    string ligne = r.ReadLine();
                    if (ligne != null) { MessageBox.Show("User = " + ligne); }
                    ligne = r.ReadLine();
                    if (ligne != null) { MessageBox.Show("Password= " + ligne); }
                    r.Close();

                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            else MessageBox.Show("Le fichiern'existe pas !! .");
        }

        public void viderPanel(Panel pl)
        {
            foreach (Control c in pl.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
    }
}
