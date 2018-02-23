namespace GR_BDD_Final1
{
    partial class F_menuProduit
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
            this.btn_ajout = new System.Windows.Forms.Button();
            this.btn_cherch = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ajout
            // 
            this.btn_ajout.Location = new System.Drawing.Point(12, 70);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(75, 23);
            this.btn_ajout.TabIndex = 5;
            this.btn_ajout.Text = "Ajouter";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // btn_cherch
            // 
            this.btn_cherch.Location = new System.Drawing.Point(12, 41);
            this.btn_cherch.Name = "btn_cherch";
            this.btn_cherch.Size = new System.Drawing.Size(75, 23);
            this.btn_cherch.TabIndex = 4;
            this.btn_cherch.Text = "Rechercher";
            this.btn_cherch.UseVisualStyleBackColor = true;
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(12, 12);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(75, 23);
            this.btn_list.TabIndex = 3;
            this.btn_list.Text = "Lister";
            this.btn_list.UseVisualStyleBackColor = true;
            // 
            // F_menuProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.btn_cherch);
            this.Controls.Add(this.btn_list);
            this.Name = "F_menuProduit";
            this.Text = "Menu Produit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.Button btn_cherch;
        private System.Windows.Forms.Button btn_list;
    }
}