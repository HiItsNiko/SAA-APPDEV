
namespace Project_SAA
{
    partial class FormLogin
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
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.groupBoxHeader = new System.Windows.Forms.GroupBox();
            this.linkLabelContact = new System.Windows.Forms.LinkLabel();
            this.linkLabelHome = new System.Windows.Forms.LinkLabel();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            this.groupBoxHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(48, 134);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(244, 26);
            this.textBoxPass.TabIndex = 0;
            // 
            // panelLogin
            // 
            this.panelLogin.AutoSize = true;
            this.panelLogin.BackColor = System.Drawing.Color.Silver;
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.buttonSignup);
            this.panelLogin.Controls.Add(this.linkLabel1);
            this.panelLogin.Controls.Add(this.labelPass);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.textBoxEmail);
            this.panelLogin.Controls.Add(this.textBoxPass);
            this.panelLogin.Controls.Add(this.pictureBoxShow);
            this.panelLogin.Location = new System.Drawing.Point(223, 136);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(364, 289);
            this.panelLogin.TabIndex = 2;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(212, 200);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(80, 40);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // buttonSignup
            // 
            this.buttonSignup.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignup.ForeColor = System.Drawing.Color.White;
            this.buttonSignup.Location = new System.Drawing.Point(48, 200);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(80, 40);
            this.buttonSignup.TabIndex = 6;
            this.buttonSignup.Text = "Sign Up";
            this.buttonSignup.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(45, 163);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forget Password?";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.Transparent;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(45, 115);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(76, 16);
            this.labelPass.TabIndex = 4;
            this.labelPass.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email / Username";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(48, 55);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(244, 26);
            this.textBoxEmail.TabIndex = 2;
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.Image = global::Project_SAA.Properties.Resources.Hide;
            this.pictureBoxShow.Location = new System.Drawing.Point(298, 134);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(29, 26);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShow.TabIndex = 1;
            this.pictureBoxShow.TabStop = false;
            this.pictureBoxShow.Click += new System.EventHandler(this.pictureBoxShow_Click);
            // 
            // groupBoxHeader
            // 
            this.groupBoxHeader.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBoxHeader.Controls.Add(this.linkLabelContact);
            this.groupBoxHeader.Controls.Add(this.linkLabelHome);
            this.groupBoxHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxHeader.Location = new System.Drawing.Point(0, 0);
            this.groupBoxHeader.Name = "groupBoxHeader";
            this.groupBoxHeader.Size = new System.Drawing.Size(799, 100);
            this.groupBoxHeader.TabIndex = 3;
            this.groupBoxHeader.TabStop = false;
            // 
            // linkLabelContact
            // 
            this.linkLabelContact.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelContact.AutoSize = true;
            this.linkLabelContact.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelContact.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.linkLabelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelContact.LinkColor = System.Drawing.Color.White;
            this.linkLabelContact.Location = new System.Drawing.Point(205, 40);
            this.linkLabelContact.Name = "linkLabelContact";
            this.linkLabelContact.Size = new System.Drawing.Size(93, 25);
            this.linkLabelContact.TabIndex = 1;
            this.linkLabelContact.TabStop = true;
            this.linkLabelContact.Text = "Contact";
            // 
            // linkLabelHome
            // 
            this.linkLabelHome.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelHome.AutoSize = true;
            this.linkLabelHome.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelHome.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.linkLabelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelHome.LinkColor = System.Drawing.Color.White;
            this.linkLabelHome.Location = new System.Drawing.Point(55, 40);
            this.linkLabelHome.Name = "linkLabelHome";
            this.linkLabelHome.Size = new System.Drawing.Size(72, 25);
            this.linkLabelHome.TabIndex = 0;
            this.linkLabelHome.TabStop = true;
            this.linkLabelHome.Text = "Home";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.groupBoxHeader);
            this.Controls.Add(this.panelLogin);
            this.Name = "FormLogin";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            this.groupBoxHeader.ResumeLayout(false);
            this.groupBoxHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.GroupBox groupBoxHeader;
        private System.Windows.Forms.LinkLabel linkLabelContact;
        private System.Windows.Forms.LinkLabel linkLabelHome;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.Button buttonLogin;
    }
}