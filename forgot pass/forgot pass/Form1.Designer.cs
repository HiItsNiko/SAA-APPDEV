namespace forgot_pass
{
    partial class Forminfo
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
            this.linkLabelforgot = new System.Windows.Forms.LinkLabel();
            this.labelhome = new System.Windows.Forms.Label();
            this.labelcontact = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabelforgot
            // 
            this.linkLabelforgot.AutoSize = true;
            this.linkLabelforgot.Location = new System.Drawing.Point(315, 155);
            this.linkLabelforgot.Name = "linkLabelforgot";
            this.linkLabelforgot.Size = new System.Drawing.Size(148, 13);
            this.linkLabelforgot.TabIndex = 0;
            this.linkLabelforgot.TabStop = true;
            this.linkLabelforgot.Text = "Maukah Anda Melihat Surga?";
            this.linkLabelforgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelforgot_LinkClicked);
            // 
            // labelhome
            // 
            this.labelhome.AutoSize = true;
            this.labelhome.Location = new System.Drawing.Point(161, 46);
            this.labelhome.Name = "labelhome";
            this.labelhome.Size = new System.Drawing.Size(39, 13);
            this.labelhome.TabIndex = 1;
            this.labelhome.Text = "HOME";
            // 
            // labelcontact
            // 
            this.labelcontact.AutoSize = true;
            this.labelcontact.Location = new System.Drawing.Point(272, 46);
            this.labelcontact.Name = "labelcontact";
            this.labelcontact.Size = new System.Drawing.Size(44, 13);
            this.labelcontact.TabIndex = 2;
            this.labelcontact.Text = "Contact";
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(495, 300);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(75, 23);
            this.buttonlogin.TabIndex = 3;
            this.buttonlogin.Text = " LOGIN";
            this.buttonlogin.UseVisualStyleBackColor = true;
            // 
            // Forminfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.labelcontact);
            this.Controls.Add(this.labelhome);
            this.Controls.Add(this.linkLabelforgot);
            this.Name = "Forminfo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelforgot;
        private System.Windows.Forms.Label labelhome;
        private System.Windows.Forms.Label labelcontact;
        private System.Windows.Forms.Button buttonlogin;
    }
}

