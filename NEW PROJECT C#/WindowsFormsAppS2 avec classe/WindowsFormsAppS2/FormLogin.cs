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
    public partial class frmLogin : Form
    {
        public string u="root", p="p@$$";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)   tbPass.PasswordChar = (Char)0 ;
            else tbPass.PasswordChar = '*';
        }
        //Mes methodes
        private void login()
        {
            string pathFile = Path.GetDirectoryName(System.Reflection.
                Assembly.GetEntryAssembly().Location) + @"\login.txt";
            if (File.Exists(pathFile))
            {  try
                {
                    string u="", p="";
                    StreamReader r = new StreamReader(pathFile);
                    string ligne = r.ReadLine();
                    if (ligne != null) {  u = ligne; }
                    ligne = r.ReadLine();
                    if (ligne != null) {   p = ligne;  }
                    r.Close(); 

                    //u = "root";
                    //p = "p@$$";
                    if (tbUser.Text == u && tbPass.Text == p)
                    { 
                        this.Hide();
                        frmHome fh = new frmHome();
                        fh.Show();
                    }
                    else
                    {    MessageBox.Show("L'utilisateur ou mot de passe incorrect ..!");         }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }          else MessageBox.Show("Le fichiern'existe pas !! .");
            ////////////////////////////////////////////////////////////           
        }

    }
}
