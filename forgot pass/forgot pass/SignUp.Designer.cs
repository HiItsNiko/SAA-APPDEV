
namespace forgot_pass
{
    partial class SignUp
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
            this.tBoxFirstName = new System.Windows.Forms.TextBox();
            this.tBoxLastName = new System.Windows.Forms.TextBox();
            this.tBoxUsername = new System.Windows.Forms.TextBox();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.tBoxPhone = new System.Windows.Forms.TextBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.tBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.linkLabelHome = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBoxFirstName
            // 
            this.tBoxFirstName.Location = new System.Drawing.Point(39, 54);
            this.tBoxFirstName.Name = "tBoxFirstName";
            this.tBoxFirstName.Size = new System.Drawing.Size(115, 20);
            this.tBoxFirstName.TabIndex = 0;
            // 
            // tBoxLastName
            // 
            this.tBoxLastName.Location = new System.Drawing.Point(160, 54);
            this.tBoxLastName.Name = "tBoxLastName";
            this.tBoxLastName.Size = new System.Drawing.Size(115, 20);
            this.tBoxLastName.TabIndex = 1;
            // 
            // tBoxUsername
            // 
            this.tBoxUsername.Location = new System.Drawing.Point(39, 100);
            this.tBoxUsername.Name = "tBoxUsername";
            this.tBoxUsername.Size = new System.Drawing.Size(236, 20);
            this.tBoxUsername.TabIndex = 2;
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Location = new System.Drawing.Point(39, 145);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(236, 20);
            this.tBoxEmail.TabIndex = 3;
            // 
            // tBoxPhone
            // 
            this.tBoxPhone.Location = new System.Drawing.Point(39, 190);
            this.tBoxPhone.Name = "tBoxPhone";
            this.tBoxPhone.Size = new System.Drawing.Size(236, 20);
            this.tBoxPhone.TabIndex = 4;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(39, 237);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(236, 20);
            this.tBoxPassword.TabIndex = 5;
            // 
            // tBoxConfirmPassword
            // 
            this.tBoxConfirmPassword.Location = new System.Drawing.Point(39, 285);
            this.tBoxConfirmPassword.Name = "tBoxConfirmPassword";
            this.tBoxConfirmPassword.Size = new System.Drawing.Size(236, 20);
            this.tBoxConfirmPassword.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBoxConfirmPassword);
            this.groupBox1.Controls.Add(this.tBoxFirstName);
            this.groupBox1.Controls.Add(this.tBoxPassword);
            this.groupBox1.Controls.Add(this.tBoxLastName);
            this.groupBox1.Controls.Add(this.tBoxPhone);
            this.groupBox1.Controls.Add(this.tBoxUsername);
            this.groupBox1.Controls.Add(this.tBoxEmail);
            this.groupBox1.Location = new System.Drawing.Point(47, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 376);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign-Up";
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.linkLabelHome);
            this.groupBoxMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMenu.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(421, 100);
            this.groupBoxMenu.TabIndex = 8;
            this.groupBoxMenu.TabStop = false;
            // 
            // linkLabelHome
            // 
            this.linkLabelHome.AutoSize = true;
            this.linkLabelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelHome.LinkColor = System.Drawing.Color.Black;
            this.linkLabelHome.Location = new System.Drawing.Point(53, 39);
            this.linkLabelHome.Name = "linkLabelHome";
            this.linkLabelHome.Size = new System.Drawing.Size(66, 24);
            this.linkLabelHome.TabIndex = 0;
            this.linkLabelHome.TabStop = true;
            this.linkLabelHome.Text = "Home";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 522);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.groupBox1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxFirstName;
        private System.Windows.Forms.TextBox tBoxLastName;
        private System.Windows.Forms.TextBox tBoxUsername;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.TextBox tBoxPhone;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.TextBox tBoxConfirmPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.LinkLabel linkLabelHome;
    }
}