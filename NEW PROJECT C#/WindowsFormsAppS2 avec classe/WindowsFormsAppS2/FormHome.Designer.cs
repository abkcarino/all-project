
namespace WindowsFormsAppS2
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAffichageLog = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.lblDate3 = new System.Windows.Forms.Label();
            this.btnAfficherDTP = new System.Windows.Forms.Button();
            this.lblDate4 = new System.Windows.Forms.Label();
            this.lblDate5 = new System.Windows.Forms.Label();
            this.lblDate6 = new System.Windows.Forms.Label();
            this.lblDate7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAffichageLog
            // 
            this.lblAffichageLog.AutoSize = true;
            this.lblAffichageLog.Location = new System.Drawing.Point(88, 37);
            this.lblAffichageLog.Name = "lblAffichageLog";
            this.lblAffichageLog.Size = new System.Drawing.Size(119, 20);
            this.lblAffichageLog.TabIndex = 0;
            this.lblAffichageLog.Text = "lblAffichageLog";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblDate1
            // 
            this.lblDate1.AutoSize = true;
            this.lblDate1.Location = new System.Drawing.Point(97, 164);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(87, 20);
            this.lblDate1.TabIndex = 2;
            this.lblDate1.Text = "DateTime1";
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Location = new System.Drawing.Point(97, 208);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(87, 20);
            this.lblDate2.TabIndex = 3;
            this.lblDate2.Text = "DateTime2";
            // 
            // lblDate3
            // 
            this.lblDate3.AutoSize = true;
            this.lblDate3.Location = new System.Drawing.Point(97, 249);
            this.lblDate3.Name = "lblDate3";
            this.lblDate3.Size = new System.Drawing.Size(87, 20);
            this.lblDate3.TabIndex = 4;
            this.lblDate3.Text = "DateTime3";
            // 
            // btnAfficherDTP
            // 
            this.btnAfficherDTP.Location = new System.Drawing.Point(338, 101);
            this.btnAfficherDTP.Name = "btnAfficherDTP";
            this.btnAfficherDTP.Size = new System.Drawing.Size(119, 33);
            this.btnAfficherDTP.TabIndex = 5;
            this.btnAfficherDTP.Text = "AfficherDTP";
            this.btnAfficherDTP.UseVisualStyleBackColor = true;
            this.btnAfficherDTP.Click += new System.EventHandler(this.btnAfficherDTP_Click);
            // 
            // lblDate4
            // 
            this.lblDate4.AutoSize = true;
            this.lblDate4.Location = new System.Drawing.Point(97, 296);
            this.lblDate4.Name = "lblDate4";
            this.lblDate4.Size = new System.Drawing.Size(87, 20);
            this.lblDate4.TabIndex = 6;
            this.lblDate4.Text = "DateTime4";
            // 
            // lblDate5
            // 
            this.lblDate5.AutoSize = true;
            this.lblDate5.Location = new System.Drawing.Point(97, 341);
            this.lblDate5.Name = "lblDate5";
            this.lblDate5.Size = new System.Drawing.Size(87, 20);
            this.lblDate5.TabIndex = 7;
            this.lblDate5.Text = "DateTime5";
            // 
            // lblDate6
            // 
            this.lblDate6.AutoSize = true;
            this.lblDate6.Location = new System.Drawing.Point(97, 379);
            this.lblDate6.Name = "lblDate6";
            this.lblDate6.Size = new System.Drawing.Size(87, 20);
            this.lblDate6.TabIndex = 8;
            this.lblDate6.Text = "DateTime6";
            // 
            // lblDate7
            // 
            this.lblDate7.AutoSize = true;
            this.lblDate7.Location = new System.Drawing.Point(97, 421);
            this.lblDate7.Name = "lblDate7";
            this.lblDate7.Size = new System.Drawing.Size(87, 20);
            this.lblDate7.TabIndex = 8;
            this.lblDate7.Text = "DateTime7";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDate7);
            this.Controls.Add(this.lblDate6);
            this.Controls.Add(this.lblDate5);
            this.Controls.Add(this.lblDate4);
            this.Controls.Add(this.btnAfficherDTP);
            this.Controls.Add(this.lblDate3);
            this.Controls.Add(this.lblDate2);
            this.Controls.Add(this.lblDate1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblAffichageLog);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAffichageLog;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate1;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Label lblDate3;
        private System.Windows.Forms.Button btnAfficherDTP;
        private System.Windows.Forms.Label lblDate4;
        private System.Windows.Forms.Label lblDate5;
        private System.Windows.Forms.Label lblDate6;
        private System.Windows.Forms.Label lblDate7;
    }
}