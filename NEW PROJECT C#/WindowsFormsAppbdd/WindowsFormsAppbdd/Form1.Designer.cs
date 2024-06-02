namespace WindowsFormsAppbdd
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.labelPASS = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labelUSER = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelEMAIL = new System.Windows.Forms.Label();
            this.labelDATEN = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelPRENOM = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelNOM = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 281);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(900, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.labelPASS);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.labelUSER);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.labelEMAIL);
            this.panel1.Controls.Add(this.labelDATEN);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.labelPRENOM);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.labelNOM);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 272);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 220);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 29);
            this.button2.TabIndex = 17;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(618, 220);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(112, 26);
            this.textBox8.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(506, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "CONFPASS :";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(618, 160);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(112, 26);
            this.textBox7.TabIndex = 13;
            // 
            // labelPASS
            // 
            this.labelPASS.AutoSize = true;
            this.labelPASS.Location = new System.Drawing.Point(507, 164);
            this.labelPASS.Name = "labelPASS";
            this.labelPASS.Size = new System.Drawing.Size(111, 20);
            this.labelPASS.TabIndex = 12;
            this.labelPASS.Text = "PASSWORD :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(618, 101);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(112, 26);
            this.textBox6.TabIndex = 11;
            // 
            // labelUSER
            // 
            this.labelUSER.AutoSize = true;
            this.labelUSER.Location = new System.Drawing.Point(507, 105);
            this.labelUSER.Name = "labelUSER";
            this.labelUSER.Size = new System.Drawing.Size(63, 20);
            this.labelUSER.TabIndex = 10;
            this.labelUSER.Text = "USER :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(618, 49);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 26);
            this.textBox5.TabIndex = 9;
            // 
            // labelEMAIL
            // 
            this.labelEMAIL.AutoSize = true;
            this.labelEMAIL.Location = new System.Drawing.Point(506, 49);
            this.labelEMAIL.Name = "labelEMAIL";
            this.labelEMAIL.Size = new System.Drawing.Size(66, 20);
            this.labelEMAIL.TabIndex = 8;
            this.labelEMAIL.Text = "EMAIL :";
            // 
            // labelDATEN
            // 
            this.labelDATEN.AutoSize = true;
            this.labelDATEN.Location = new System.Drawing.Point(7, 215);
            this.labelDATEN.Name = "labelDATEN";
            this.labelDATEN.Size = new System.Drawing.Size(102, 20);
            this.labelDATEN.TabIndex = 6;
            this.labelDATEN.Text = "DATE NAIS :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(178, 160);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 26);
            this.textBox3.TabIndex = 5;
            // 
            // labelPRENOM
            // 
            this.labelPRENOM.AutoSize = true;
            this.labelPRENOM.Location = new System.Drawing.Point(75, 160);
            this.labelPRENOM.Name = "labelPRENOM";
            this.labelPRENOM.Size = new System.Drawing.Size(86, 20);
            this.labelPRENOM.TabIndex = 4;
            this.labelPRENOM.Text = "PRENOM :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 101);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 26);
            this.textBox2.TabIndex = 3;
            // 
            // labelNOM
            // 
            this.labelNOM.AutoSize = true;
            this.labelNOM.Location = new System.Drawing.Point(75, 101);
            this.labelNOM.Name = "labelNOM";
            this.labelNOM.Size = new System.Drawing.Size(53, 20);
            this.labelNOM.TabIndex = 2;
            this.labelNOM.Text = "NOM :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 26);
            this.textBox1.TabIndex = 1;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(75, 49);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(34, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID :";
            this.labelID.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 26);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label labelPASS;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label labelUSER;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labelEMAIL;
        private System.Windows.Forms.Label labelDATEN;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelPRENOM;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelNOM;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

