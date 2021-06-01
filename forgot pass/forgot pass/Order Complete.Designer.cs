namespace forgot_pass
{
    partial class Order_Complete
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
            this.labeldate = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelduration = new System.Windows.Forms.Label();
            this.labeldurationvalue = new System.Windows.Forms.Label();
            this.labeltotal = new System.Windows.Forms.Label();
            this.labeltotalvalue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttonok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Location = new System.Drawing.Point(381, 32);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(59, 13);
            this.labeldate.TabIndex = 0;
            this.labeldate.Text = "Order Date";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(206, 132);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(44, 13);
            this.labelid.TabIndex = 1;
            this.labelid.Text = "OrderID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TRANSACTION SUCCESSFUL";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Location = new System.Drawing.Point(206, 178);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(55, 13);
            this.labelusername.TabIndex = 3;
            this.labelusername.Text = "Username";
            // 
            // labelduration
            // 
            this.labelduration.AutoSize = true;
            this.labelduration.Location = new System.Drawing.Point(150, 223);
            this.labelduration.Name = "labelduration";
            this.labelduration.Size = new System.Drawing.Size(47, 13);
            this.labelduration.TabIndex = 4;
            this.labelduration.Text = "Duration";
            // 
            // labeldurationvalue
            // 
            this.labeldurationvalue.AutoSize = true;
            this.labeldurationvalue.Location = new System.Drawing.Point(279, 223);
            this.labeldurationvalue.Name = "labeldurationvalue";
            this.labeldurationvalue.Size = new System.Drawing.Size(16, 13);
            this.labeldurationvalue.TabIndex = 5;
            this.labeldurationvalue.Text = "...";
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Location = new System.Drawing.Point(150, 249);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(31, 13);
            this.labeltotal.TabIndex = 6;
            this.labeltotal.Text = "Total";
            // 
            // labeltotalvalue
            // 
            this.labeltotalvalue.AutoSize = true;
            this.labeltotalvalue.Location = new System.Drawing.Point(279, 249);
            this.labeltotalvalue.Name = "labeltotalvalue";
            this.labeltotalvalue.Size = new System.Drawing.Size(40, 13);
            this.labeltotalvalue.TabIndex = 7;
            this.labeltotalvalue.Text = "RP. ....";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(183, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(109, 387);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(75, 61);
            this.buttonsave.TabIndex = 9;
            this.buttonsave.Text = "Save Picture to Device";
            this.buttonsave.UseVisualStyleBackColor = true;
            // 
            // buttonok
            // 
            this.buttonok.Location = new System.Drawing.Point(282, 387);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(75, 61);
            this.buttonok.TabIndex = 10;
            this.buttonok.Text = "OK";
            this.buttonok.UseVisualStyleBackColor = true;
            // 
            // Order_Complete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 498);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labeltotalvalue);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.labeldurationvalue);
            this.Controls.Add(this.labelduration);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.labeldate);
            this.Name = "Order_Complete";
            this.Text = "Order_Complete";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelduration;
        private System.Windows.Forms.Label labeldurationvalue;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Label labeltotalvalue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttonok;
    }
}