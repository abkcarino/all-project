using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppS2
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin(); // Appel la Form2
            
            lblAffichageLog.Text = "Bienvenu Mr/Mme : " + fl.u;
        }

        private void btnAfficherDTP_Click(object sender, EventArgs e)
        {
            lblDate1.Text = dateTimePicker1.Value.ToString();
            lblDate2.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            lblDate3.Text = dateTimePicker1.Value.ToShortDateString();
            lblDate4.Text = dateTimePicker1.Value.ToLongDateString();
            lblDate5.Text = dateTimePicker1.Value.ToShortTimeString();
            lblDate6.Text = dateTimePicker1.Value.ToLongTimeString();
            lblDate7.Text = DateTime.Now.ToString();
        }

      
    }
}
