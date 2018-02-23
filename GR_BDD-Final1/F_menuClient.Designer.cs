namespace GR_BDD_Final1
{
    partial class F_menuClient
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
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_cherch = new System.Windows.Forms.Button();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(12, 13);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(75, 23);
            this.btn_list.TabIndex = 0;
            this.btn_list.Text = "Lister";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btn_cherch
            // 
            this.btn_cherch.Location = new System.Drawing.Point(12, 42);
            this.btn_cherch.Name = "btn_cherch";
            this.btn_cherch.Size = new System.Drawing.Size(75, 23);
            this.btn_cherch.TabIndex = 1;
            this.btn_cherch.Text = "Rechercher";
            this.btn_cherch.UseVisualStyleBackColor = true;
            this.btn_cherch.Click += new System.EventHandler(this.btn_cherch_Click);
            // 
            // btn_ajout
            // 
            this.btn_ajout.Location = new System.Drawing.Point(12, 71);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(75, 23);
            this.btn_ajout.TabIndex = 2;
            this.btn_ajout.Text = "Ajouter";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // F_menuClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.btn_cherch);
            this.Controls.Add(this.btn_list);
            this.IsMdiContainer = true;
            this.Name = "F_menuClient";
            this.Text = "Menu Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Button btn_cherch;
        private System.Windows.Forms.Button btn_ajout;
    }
}