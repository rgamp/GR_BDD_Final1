namespace GR_BDD_Final1
{
    partial class F_ajoutClient
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
            this.btn_SendClient = new System.Windows.Forms.Button();
            this.tb_Compte = new System.Windows.Forms.TextBox();
            this.tb_Cat = new System.Windows.Forms.TextBox();
            this.tb_Localite = new System.Windows.Forms.TextBox();
            this.tb_Adresse = new System.Windows.Forms.TextBox();
            this.tb_Nom = new System.Windows.Forms.TextBox();
            this.tb_Ncli = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_SendClient
            // 
            this.btn_SendClient.BackColor = System.Drawing.Color.Red;
            this.btn_SendClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendClient.Location = new System.Drawing.Point(183, 184);
            this.btn_SendClient.Name = "btn_SendClient";
            this.btn_SendClient.Size = new System.Drawing.Size(89, 64);
            this.btn_SendClient.TabIndex = 20;
            this.btn_SendClient.Text = "Ajout a la BDD";
            this.btn_SendClient.UseVisualStyleBackColor = false;
            this.btn_SendClient.Click += new System.EventHandler(this.btn_SendClient_Click);
            // 
            // tb_Compte
            // 
            this.tb_Compte.Location = new System.Drawing.Point(13, 147);
            this.tb_Compte.Name = "tb_Compte";
            this.tb_Compte.Size = new System.Drawing.Size(100, 20);
            this.tb_Compte.TabIndex = 19;
            this.tb_Compte.Text = "Compte";
            // 
            // tb_Cat
            // 
            this.tb_Cat.Location = new System.Drawing.Point(13, 120);
            this.tb_Cat.Name = "tb_Cat";
            this.tb_Cat.Size = new System.Drawing.Size(100, 20);
            this.tb_Cat.TabIndex = 18;
            this.tb_Cat.Text = "Cat";
            // 
            // tb_Localite
            // 
            this.tb_Localite.Location = new System.Drawing.Point(13, 93);
            this.tb_Localite.Name = "tb_Localite";
            this.tb_Localite.Size = new System.Drawing.Size(100, 20);
            this.tb_Localite.TabIndex = 17;
            this.tb_Localite.Text = "Localite";
            // 
            // tb_Adresse
            // 
            this.tb_Adresse.Location = new System.Drawing.Point(13, 66);
            this.tb_Adresse.Name = "tb_Adresse";
            this.tb_Adresse.Size = new System.Drawing.Size(100, 20);
            this.tb_Adresse.TabIndex = 16;
            this.tb_Adresse.Text = "Adresse";
            // 
            // tb_Nom
            // 
            this.tb_Nom.Location = new System.Drawing.Point(13, 39);
            this.tb_Nom.Name = "tb_Nom";
            this.tb_Nom.Size = new System.Drawing.Size(100, 20);
            this.tb_Nom.TabIndex = 15;
            this.tb_Nom.Text = "Nom";
            // 
            // tb_Ncli
            // 
            this.tb_Ncli.Location = new System.Drawing.Point(13, 12);
            this.tb_Ncli.Name = "tb_Ncli";
            this.tb_Ncli.Size = new System.Drawing.Size(100, 20);
            this.tb_Ncli.TabIndex = 14;
            this.tb_Ncli.Text = "Nb Client";
            // 
            // F_ajoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_SendClient);
            this.Controls.Add(this.tb_Compte);
            this.Controls.Add(this.tb_Cat);
            this.Controls.Add(this.tb_Localite);
            this.Controls.Add(this.tb_Adresse);
            this.Controls.Add(this.tb_Nom);
            this.Controls.Add(this.tb_Ncli);
            this.Name = "F_ajoutClient";
            this.Text = "Ajouter Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SendClient;
        private System.Windows.Forms.TextBox tb_Compte;
        private System.Windows.Forms.TextBox tb_Cat;
        private System.Windows.Forms.TextBox tb_Localite;
        private System.Windows.Forms.TextBox tb_Adresse;
        private System.Windows.Forms.TextBox tb_Nom;
        private System.Windows.Forms.TextBox tb_Ncli;
    }
}