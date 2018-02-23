namespace GR_BDD_Final1
{
    partial class F_ajoutProduit
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
            this.btn_SendItem = new System.Windows.Forms.Button();
            this.tb_Stock = new System.Windows.Forms.TextBox();
            this.tb_Prix = new System.Windows.Forms.TextBox();
            this.tb_Libelle = new System.Windows.Forms.TextBox();
            this.tb_Npro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_SendItem
            // 
            this.btn_SendItem.Location = new System.Drawing.Point(197, 207);
            this.btn_SendItem.Name = "btn_SendItem";
            this.btn_SendItem.Size = new System.Drawing.Size(75, 41);
            this.btn_SendItem.TabIndex = 9;
            this.btn_SendItem.Text = "Ajouter a la BDD";
            this.btn_SendItem.UseVisualStyleBackColor = true;
            this.btn_SendItem.Click += new System.EventHandler(this.btn_SendItem_Click);
            // 
            // tb_Stock
            // 
            this.tb_Stock.Location = new System.Drawing.Point(13, 92);
            this.tb_Stock.Name = "tb_Stock";
            this.tb_Stock.Size = new System.Drawing.Size(100, 20);
            this.tb_Stock.TabIndex = 8;
            this.tb_Stock.Text = "Stock";
            // 
            // tb_Prix
            // 
            this.tb_Prix.Location = new System.Drawing.Point(13, 65);
            this.tb_Prix.Name = "tb_Prix";
            this.tb_Prix.Size = new System.Drawing.Size(100, 20);
            this.tb_Prix.TabIndex = 7;
            this.tb_Prix.Text = "Prix";
            // 
            // tb_Libelle
            // 
            this.tb_Libelle.Location = new System.Drawing.Point(12, 38);
            this.tb_Libelle.Name = "tb_Libelle";
            this.tb_Libelle.Size = new System.Drawing.Size(100, 20);
            this.tb_Libelle.TabIndex = 6;
            this.tb_Libelle.Text = "Libelle";
            // 
            // tb_Npro
            // 
            this.tb_Npro.Location = new System.Drawing.Point(13, 12);
            this.tb_Npro.Name = "tb_Npro";
            this.tb_Npro.Size = new System.Drawing.Size(100, 20);
            this.tb_Npro.TabIndex = 5;
            this.tb_Npro.Text = "Num Produit";
            // 
            // F_ajoutProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_SendItem);
            this.Controls.Add(this.tb_Stock);
            this.Controls.Add(this.tb_Prix);
            this.Controls.Add(this.tb_Libelle);
            this.Controls.Add(this.tb_Npro);
            this.Name = "F_ajoutProduit";
            this.Text = "F_ajoutProduit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SendItem;
        private System.Windows.Forms.TextBox tb_Stock;
        private System.Windows.Forms.TextBox tb_Prix;
        private System.Windows.Forms.TextBox tb_Libelle;
        private System.Windows.Forms.TextBox tb_Npro;
    }
}