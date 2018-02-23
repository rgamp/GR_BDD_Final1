namespace GR_BDD_Final1
{
    partial class F_listClient
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
            this.cb_listClient = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_listClient
            // 
            this.cb_listClient.FormattingEnabled = true;
            this.cb_listClient.Location = new System.Drawing.Point(13, 13);
            this.cb_listClient.Name = "cb_listClient";
            this.cb_listClient.Size = new System.Drawing.Size(259, 21);
            this.cb_listClient.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_listClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_listClient);
            this.Name = "F_listClient";
            this.Text = "Liste Client";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_listClient;
        private System.Windows.Forms.Button button1;
    }
}