namespace forgot_pass
{
    partial class MyInfo
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
            this.labelhome = new System.Windows.Forms.Label();
            this.labelcontact = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelhome
            // 
            this.labelhome.AutoSize = true;
            this.labelhome.Location = new System.Drawing.Point(144, 29);
            this.labelhome.Name = "labelhome";
            this.labelhome.Size = new System.Drawing.Size(35, 13);
            this.labelhome.TabIndex = 0;
            this.labelhome.Text = "Home";
            this.labelhome.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelcontact
            // 
            this.labelcontact.AutoSize = true;
            this.labelcontact.Location = new System.Drawing.Point(280, 29);
            this.labelcontact.Name = "labelcontact";
            this.labelcontact.Size = new System.Drawing.Size(44, 13);
            this.labelcontact.TabIndex = 1;
            this.labelcontact.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // MyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelcontact);
            this.Controls.Add(this.labelhome);
            this.Name = "MyInfo";
            this.Text = "MyInfo";
            this.Load += new System.EventHandler(this.MyInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelhome;
        private System.Windows.Forms.Label labelcontact;
        private System.Windows.Forms.Label label3;
    }
}