namespace Demo1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.checkBoxInscrit = new System.Windows.Forms.CheckBox();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelDemoByMylan = new System.Windows.Forms.Label();
            this.labelInscrit = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(35, 53);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(204, 23);
            this.textBoxNom.TabIndex = 0;
            this.textBoxNom.Text = "Nom";
            // 
            // checkBoxInscrit
            // 
            this.checkBoxInscrit.AutoSize = true;
            this.checkBoxInscrit.Location = new System.Drawing.Point(35, 92);
            this.checkBoxInscrit.Name = "checkBoxInscrit";
            this.checkBoxInscrit.Size = new System.Drawing.Size(84, 19);
            this.checkBoxInscrit.TabIndex = 1;
            this.checkBoxInscrit.Text = "Déjà inscrit";
            this.checkBoxInscrit.UseVisualStyleBackColor = true;
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(35, 135);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(204, 46);
            this.buttonEnregistrer.TabIndex = 2;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(35, 215);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(669, 199);
            this.listBox1.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(302, 92);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(402, 39);
            this.progressBar1.TabIndex = 4;
            // 
            // labelDemoByMylan
            // 
            this.labelDemoByMylan.AutoSize = true;
            this.labelDemoByMylan.Location = new System.Drawing.Point(603, 483);
            this.labelDemoByMylan.Name = "labelDemoByMylan";
            this.labelDemoByMylan.Size = new System.Drawing.Size(128, 15);
            this.labelDemoByMylan.TabIndex = 5;
            this.labelDemoByMylan.Text = "Demo By Mylan Maizel";
            // 
            // labelInscrit
            // 
            this.labelInscrit.AutoSize = true;
            this.labelInscrit.ForeColor = System.Drawing.Color.Red;
            this.labelInscrit.Location = new System.Drawing.Point(434, 175);
            this.labelInscrit.Name = "labelInscrit";
            this.labelInscrit.Size = new System.Drawing.Size(125, 15);
            this.labelInscrit.TabIndex = 6;
            this.labelInscrit.Text = "Vous êtes déjà inscrit...";
            this.labelInscrit.Visible = false;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.ForeColor = System.Drawing.Color.Red;
            this.labelMax.Location = new System.Drawing.Point(302, 443);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(146, 15);
            this.labelMax.TabIndex = 7;
            this.labelMax.Text = "Nombre maximum atteint";
            this.labelMax.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 507);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelInscrit);
            this.Controls.Add(this.labelDemoByMylan);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.checkBoxInscrit);
            this.Controls.Add(this.textBoxNom);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNom;
        private CheckBox checkBoxInscrit;
        private Button buttonEnregistrer;
        private ListBox listBox1;
        private ProgressBar progressBar1;
        private Label labelDemoByMylan;
        private Label labelInscrit;
        private Label labelMax;
    }
}