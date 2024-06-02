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
    public partial class FormMessage : Form
    {
        public FormMessage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Simple MessageBox";
            MessageBox.Show(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Simple MessageBox";
            string titre = "Titre";
            MessageBox.Show(message, titre);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // Do something
            }
        }

        private void FormMessage_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string message = "Do you want to abort this operation?";//Voulez-vous abandonner cette opération ?
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Abort)
            {
                this.Close();
            }
            else if(result == DialogResult.Retry) {
                // Do nothing
            }
            else
            {
                // Do something
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string message = "Do you want to abort this operation?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Abort)
            {
                this.Close();
            }
            else if(result == DialogResult.Retry) {
                // Do nothing
            }
            else
            {
                // Do something
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string message = "Do you want to abort this operation?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
            DialogResult result = MessageBox.Show(message, title, buttons,MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string message = "Do you want to abort this operation?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
            //DialogResult result = MessageBox.Show(message, title, buttons,MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,MessageBoxOptions.RightAlign, true);
            // OR
            DialogResult result = MessageBox.Show(message, title,buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0, "helpfile.chm");
        }
    }
}
