namespace GR_BDD_Final1
{
    partial class F_menu
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
            this.btn_client = new System.Windows.Forms.Button();
            this.btn_prod = new System.Windows.Forms.Button();
            this.btn_comm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_client
            // 
            this.btn_client.Location = new System.Drawing.Point(13, 23);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(75, 23);
            this.btn_client.TabIndex = 0;
            this.btn_client.Text = "Client";
            this.btn_client.UseVisualStyleBackColor = true;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // btn_prod
            // 
            this.btn_prod.Location = new System.Drawing.Point(13, 88);
            this.btn_prod.Name = "btn_prod";
            this.btn_prod.Size = new System.Drawing.Size(75, 23);
            this.btn_prod.TabIndex = 1;
            this.btn_prod.Text = "Produit";
            this.btn_prod.UseVisualStyleBackColor = true;
            this.btn_prod.Click += new System.EventHandler(this.btn_prod_Click);
            // 
            // btn_comm
            // 
            this.btn_comm.Location = new System.Drawing.Point(13, 152);
            this.btn_comm.Name = "btn_comm";
            this.btn_comm.Size = new System.Drawing.Size(75, 23);
            this.btn_comm.TabIndex = 2;
            this.btn_comm.Text = "Commande";
            this.btn_comm.UseVisualStyleBackColor = true;
            this.btn_comm.Click += new System.EventHandler(this.btn_comm_Click);
            // 
            // F_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_comm);
            this.Controls.Add(this.btn_prod);
            this.Controls.Add(this.btn_client);
            this.IsMdiContainer = true;
            this.Name = "F_menu";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.Button btn_prod;
        private System.Windows.Forms.Button btn_comm;
    }
}

