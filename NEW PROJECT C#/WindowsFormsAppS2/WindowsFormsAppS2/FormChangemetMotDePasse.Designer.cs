
namespace WindowsFormsAppS2
{
    partial class FormChangemetMotDePasse
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
            this.components = new System.ComponentModel.Container();
            this.btnCreFileTxt = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddUserPass = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbU = new System.Windows.Forms.TextBox();
            this.tbP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnnulerSauv = new System.Windows.Forms.Button();
            this.btnSauvgarder = new System.Windows.Forms.Button();
            this.tbPC = new System.Windows.Forms.TextBox();
            this.lblPC = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreFileTxt
            // 
            this.btnCreFileTxt.Location = new System.Drawing.Point(443, 88);
            this.btnCreFileTxt.Name = "btnCreFileTxt";
            this.btnCreFileTxt.Size = new System.Drawing.Size(291, 44);
            this.btnCreFileTxt.TabIndex = 0;
            this.btnCreFileTxt.Text = "Creation fichhier texte";
            this.btnCreFileTxt.UseVisualStyleBackColor = true;
            this.btnCreFileTxt.Click += new System.EventHandler(this.btnCreFileTxt_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Suprimer fichier texte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddUserPass
            // 
            this.btnAddUserPass.Location = new System.Drawing.Point(443, 240);
            this.btnAddUserPass.Name = "btnAddUserPass";
            this.btnAddUserPass.Size = new System.Drawing.Size(291, 44);
            this.btnAddUserPass.TabIndex = 3;
            this.btnAddUserPass.Text = "Ajouter User and Password";
            this.btnAddUserPass.UseVisualStyleBackColor = true;
            this.btnAddUserPass.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(291, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "Afficher les infos (User and Passw)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "lblU";
            // 
            // tbU
            // 
            this.tbU.Location = new System.Drawing.Point(127, 23);
            this.tbU.Name = "tbU";
            this.tbU.Size = new System.Drawing.Size(160, 26);
            this.tbU.TabIndex = 6;
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(127, 61);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(160, 26);
            this.tbP.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "lblP";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAnnulerSauv);
            this.panel1.Controls.Add(this.btnSauvgarder);
            this.panel1.Controls.Add(this.tbPC);
            this.panel1.Controls.Add(this.lblPC);
            this.panel1.Controls.Add(this.tbP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbU);
            this.panel1.Location = new System.Drawing.Point(59, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 193);
            this.panel1.TabIndex = 9;
            // 
            // btnAnnulerSauv
            // 
            this.btnAnnulerSauv.Location = new System.Drawing.Point(176, 145);
            this.btnAnnulerSauv.Name = "btnAnnulerSauv";
            this.btnAnnulerSauv.Size = new System.Drawing.Size(122, 38);
            this.btnAnnulerSauv.TabIndex = 12;
            this.btnAnnulerSauv.Text = "Annuler";
            this.btnAnnulerSauv.UseVisualStyleBackColor = true;
            this.btnAnnulerSauv.Click += new System.EventHandler(this.btnAnnulerSauv_Click);
            // 
            // btnSauvgarder
            // 
            this.btnSauvgarder.Location = new System.Drawing.Point(32, 145);
            this.btnSauvgarder.Name = "btnSauvgarder";
            this.btnSauvgarder.Size = new System.Drawing.Size(122, 38);
            this.btnSauvgarder.TabIndex = 11;
            this.btnSauvgarder.Text = "Sauvgarder";
            this.btnSauvgarder.UseVisualStyleBackColor = true;
            this.btnSauvgarder.Click += new System.EventHandler(this.btnSauvgarder_Click);
            // 
            // tbPC
            // 
            this.tbPC.Location = new System.Drawing.Point(127, 104);
            this.tbPC.Name = "tbPC";
            this.tbPC.Size = new System.Drawing.Size(160, 26);
            this.tbPC.TabIndex = 10;
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.Location = new System.Drawing.Point(40, 104);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(34, 20);
            this.lblPC.TabIndex = 9;
            this.lblPC.Text = "lblP";
            // 
            // FormChangemetMotDePasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 396);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAddUserPass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreFileTxt);
            this.Name = "FormChangemetMotDePasse";
            this.Text = "FormChangemetMotDePasse";
            this.Load += new System.EventHandler(this.FormChangemetMotDePasse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreFileTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddUserPass;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbU;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnnulerSauv;
        private System.Windows.Forms.Button btnSauvgarder;
        private System.Windows.Forms.TextBox tbPC;
        private System.Windows.Forms.Label lblPC;
    }
}