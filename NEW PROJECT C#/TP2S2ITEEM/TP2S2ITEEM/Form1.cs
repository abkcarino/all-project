using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2S2ITEEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "error";
            string titre = "iteem";
            Button b=new Button();
           
            MessageBox.Show(message, titre);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "voulez vous vraiment ferme cette fenetre";
            string titre = "EXIT";
            MessageBoxButtons mbb = MessageBoxButtons.YesNo;
            DialogResult resultat=MessageBox.Show(message, titre,mbb);
            if (resultat==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "voulez vous abondonner cette operation";
            string titre = "EXIT";
            MessageBoxButtons mbb = MessageBoxButtons.AbortRetryIgnore;
            DialogResult result=MessageBox.Show(message, titre,mbb,MessageBoxIcon.Warning);
            if (result == DialogResult.Abort)
            {
                this.Close();
            }
        }
    }
}
