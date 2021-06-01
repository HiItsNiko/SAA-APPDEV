
namespace forgot_pass
{
    partial class FormLandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLandingPage));
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.buttonAbUs = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.groupBoxHeader = new System.Windows.Forms.GroupBox();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkLabelContact = new System.Windows.Forms.LinkLabel();
            this.linkLabelHome = new System.Windows.Forms.LinkLabel();
            this.panelWelcome.SuspendLayout();
            this.groupBoxHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWelcome
            // 
            this.panelWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelWelcome.AutoSize = true;
            this.panelWelcome.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelWelcome.Controls.Add(this.buttonAbUs);
            this.panelWelcome.Controls.Add(this.labelWelcome);
            this.panelWelcome.Location = new System.Drawing.Point(180, 155);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(441, 189);
            this.panelWelcome.TabIndex = 2;
            // 
            // buttonAbUs
            // 
            this.buttonAbUs.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAbUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAbUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbUs.ForeColor = System.Drawing.Color.White;
            this.buttonAbUs.Location = new System.Drawing.Point(167, 115);
            this.buttonAbUs.Name = "buttonAbUs";
            this.buttonAbUs.Size = new System.Drawing.Size(102, 41);
            this.buttonAbUs.TabIndex = 4;
            this.buttonAbUs.Text = "About Us";
            this.buttonAbUs.UseVisualStyleBackColor = false;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(49, 48);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(353, 31);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome to E-Bike Rental";
            // 
            // groupBoxHeader
            // 
            this.groupBoxHeader.AutoSize = true;
            this.groupBoxHeader.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBoxHeader.Controls.Add(this.buttonSignup);
            this.groupBoxHeader.Controls.Add(this.buttonLogin);
            this.groupBoxHeader.Controls.Add(this.linkLabelContact);
            this.groupBoxHeader.Controls.Add(this.linkLabelHome);
            this.groupBoxHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxHeader.Location = new System.Drawing.Point(0, 0);
            this.groupBoxHeader.Name = "groupBoxHeader";
            this.groupBoxHeader.Size = new System.Drawing.Size(800, 82);
            this.groupBoxHeader.TabIndex = 3;
            this.groupBoxHeader.TabStop = false;
            // 
            // buttonSignup
            // 
            this.buttonSignup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSignup.AutoSize = true;
            this.buttonSignup.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignup.ForeColor = System.Drawing.Color.White;
            this.buttonSignup.Location = new System.Drawing.Point(675, 22);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(102, 41);
            this.buttonSignup.TabIndex = 3;
            this.buttonSignup.Text = "Sign Up";
            this.buttonSignup.UseVisualStyleBackColor = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(532, 22);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(102, 41);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // linkLabelContact
            // 
            this.linkLabelContact.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelContact.AutoSize = true;
            this.linkLabelContact.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelContact.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.linkLabelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelContact.LinkColor = System.Drawing.Color.White;
            this.linkLabelContact.Location = new System.Drawing.Point(175, 28);
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
            this.linkLabelHome.Location = new System.Drawing.Point(52, 28);
            this.linkLabelHome.Name = "linkLabelHome";
            this.linkLabelHome.Size = new System.Drawing.Size(72, 25);
            this.linkLabelHome.TabIndex = 0;
            this.linkLabelHome.TabStop = true;
            this.linkLabelHome.Text = "Home";
            // 
            // FormLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxHeader);
            this.Controls.Add(this.panelWelcome);
            this.Name = "FormLandingPage";
            this.Text = "Landing Page";
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.groupBoxHeader.ResumeLayout(false);
            this.groupBoxHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Button buttonAbUs;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.GroupBox groupBoxHeader;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.LinkLabel linkLabelContact;
        private System.Windows.Forms.LinkLabel linkLabelHome;
    }
}