namespace GR_BDD_Final1
{
    partial class F_ReschClient
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
            this.l_serch = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_localite = new System.Windows.Forms.RadioButton();
            this.rb_adresse = new System.Windows.Forms.RadioButton();
            this.rb_nom = new System.Windows.Forms.RadioButton();
            this.rb_ncli = new System.Windows.Forms.RadioButton();
            this.tb_serchCli = new System.Windows.Forms.TextBox();
            this.btn_serch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_serch
            // 
            this.l_serch.AutoSize = true;
            this.l_serch.Location = new System.Drawing.Point(13, 13);
            this.l_serch.Name = "l_serch";
            this.l_serch.Size = new System.Drawing.Size(84, 13);
            this.l_serch.TabIndex = 0;
            this.l_serch.Text = "Recherche par :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_localite);
            this.groupBox1.Controls.Add(this.rb_adresse);
            this.groupBox1.Controls.Add(this.rb_nom);
            this.groupBox1.Controls.Add(this.rb_ncli);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rb_localite
            // 
            this.rb_localite.AutoSize = true;
            this.rb_localite.Location = new System.Drawing.Point(99, 44);
            this.rb_localite.Name = "rb_localite";
            this.rb_localite.Size = new System.Drawing.Size(62, 17);
            this.rb_localite.TabIndex = 3;
            this.rb_localite.TabStop = true;
            this.rb_localite.Text = "Localité";
            this.rb_localite.UseVisualStyleBackColor = true;
            // 
            // rb_adresse
            // 
            this.rb_adresse.AutoSize = true;
            this.rb_adresse.Location = new System.Drawing.Point(98, 20);
            this.rb_adresse.Name = "rb_adresse";
            this.rb_adresse.Size = new System.Drawing.Size(63, 17);
            this.rb_adresse.TabIndex = 2;
            this.rb_adresse.TabStop = true;
            this.rb_adresse.Text = "Adresse";
            this.rb_adresse.UseVisualStyleBackColor = true;
            // 
            // rb_nom
            // 
            this.rb_nom.AutoSize = true;
            this.rb_nom.Location = new System.Drawing.Point(7, 44);
            this.rb_nom.Name = "rb_nom";
            this.rb_nom.Size = new System.Drawing.Size(47, 17);
            this.rb_nom.TabIndex = 1;
            this.rb_nom.TabStop = true;
            this.rb_nom.Text = "Nom";
            this.rb_nom.UseVisualStyleBackColor = true;
            // 
            // rb_ncli
            // 
            this.rb_ncli.AutoSize = true;
            this.rb_ncli.Location = new System.Drawing.Point(7, 20);
            this.rb_ncli.Name = "rb_ncli";
            this.rb_ncli.Size = new System.Drawing.Size(49, 17);
            this.rb_ncli.TabIndex = 0;
            this.rb_ncli.TabStop = true;
            this.rb_ncli.Text = "NCLI";
            this.rb_ncli.UseVisualStyleBackColor = true;
            // 
            // tb_serchCli
            // 
            this.tb_serchCli.Location = new System.Drawing.Point(19, 105);
            this.tb_serchCli.Name = "tb_serchCli";
            this.tb_serchCli.Size = new System.Drawing.Size(100, 20);
            this.tb_serchCli.TabIndex = 2;
            // 
            // btn_serch
            // 
            this.btn_serch.Location = new System.Drawing.Point(197, 105);
            this.btn_serch.Name = "btn_serch";
            this.btn_serch.Size = new System.Drawing.Size(75, 23);
            this.btn_serch.TabIndex = 3;
            this.btn_serch.Text = "Chercher";
            this.btn_serch.UseVisualStyleBackColor = true;
            this.btn_serch.Click += new System.EventHandler(this.btn_serch_Click);
            // 
            // F_ReschClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_serch);
            this.Controls.Add(this.tb_serchCli);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.l_serch);
            this.Name = "F_ReschClient";
            this.Text = "Rechercher Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_serch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_adresse;
        private System.Windows.Forms.RadioButton rb_nom;
        private System.Windows.Forms.RadioButton rb_ncli;
        private System.Windows.Forms.RadioButton rb_localite;
        private System.Windows.Forms.TextBox tb_serchCli;
        private System.Windows.Forms.Button btn_serch;
    }
}