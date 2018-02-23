namespace GR_BDD_Final1
{
    partial class F_ajoutCommande
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
            this.btn_SendComm = new System.Windows.Forms.Button();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.tb_nCli = new System.Windows.Forms.TextBox();
            this.tb_NumComm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_SendComm
            // 
            this.btn_SendComm.Location = new System.Drawing.Point(197, 207);
            this.btn_SendComm.Name = "btn_SendComm";
            this.btn_SendComm.Size = new System.Drawing.Size(75, 41);
            this.btn_SendComm.TabIndex = 13;
            this.btn_SendComm.Text = "Ajouter a la BDD";
            this.btn_SendComm.UseVisualStyleBackColor = true;
            this.btn_SendComm.Click += new System.EventHandler(this.btn_SendComm_Click);
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(13, 65);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(100, 20);
            this.tb_date.TabIndex = 12;
            this.tb_date.Text = "Date Comm";
            // 
            // tb_nCli
            // 
            this.tb_nCli.Location = new System.Drawing.Point(12, 38);
            this.tb_nCli.Name = "tb_nCli";
            this.tb_nCli.Size = new System.Drawing.Size(100, 20);
            this.tb_nCli.TabIndex = 11;
            this.tb_nCli.Text = "Ncli";
            // 
            // tb_NumComm
            // 
            this.tb_NumComm.Location = new System.Drawing.Point(13, 12);
            this.tb_NumComm.Name = "tb_NumComm";
            this.tb_NumComm.Size = new System.Drawing.Size(100, 20);
            this.tb_NumComm.TabIndex = 10;
            this.tb_NumComm.Text = "Num Comm";
            // 
            // F_ajoutCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_SendComm);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.tb_nCli);
            this.Controls.Add(this.tb_NumComm);
            this.Name = "F_ajoutCommande";
            this.Text = "Ajout Commande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SendComm;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.TextBox tb_nCli;
        private System.Windows.Forms.TextBox tb_NumComm;
    }
}