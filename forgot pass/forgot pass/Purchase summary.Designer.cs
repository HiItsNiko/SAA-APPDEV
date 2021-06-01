namespace forgot_pass
{
    partial class Purchase_summary
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
            this.labelcost = new System.Windows.Forms.Label();
            this.labeldurasi = new System.Windows.Forms.Label();
            this.labeltotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.buttonfinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelhome
            // 
            this.labelhome.AutoSize = true;
            this.labelhome.Location = new System.Drawing.Point(145, 26);
            this.labelhome.Name = "labelhome";
            this.labelhome.Size = new System.Drawing.Size(35, 13);
            this.labelhome.TabIndex = 0;
            this.labelhome.Text = "Home";
            // 
            // labelcontact
            // 
            this.labelcontact.AutoSize = true;
            this.labelcontact.Location = new System.Drawing.Point(264, 26);
            this.labelcontact.Name = "labelcontact";
            this.labelcontact.Size = new System.Drawing.Size(44, 13);
            this.labelcontact.TabIndex = 2;
            this.labelcontact.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Purchase summary";
            // 
            // labelcost
            // 
            this.labelcost.AutoSize = true;
            this.labelcost.Location = new System.Drawing.Point(264, 188);
            this.labelcost.Name = "labelcost";
            this.labelcost.Size = new System.Drawing.Size(56, 13);
            this.labelcost.TabIndex = 4;
            this.labelcost.Text = "Cost/Hour";
            // 
            // labeldurasi
            // 
            this.labeldurasi.AutoSize = true;
            this.labeldurasi.Location = new System.Drawing.Point(264, 253);
            this.labeldurasi.Name = "labeldurasi";
            this.labeldurasi.Size = new System.Drawing.Size(47, 13);
            this.labeldurasi.TabIndex = 5;
            this.labeldurasi.Text = "Duration";
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Location = new System.Drawing.Point(264, 309);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(55, 13);
            this.labeltotal.TabIndex = 6;
            this.labeltotal.Text = "Total Cost";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(331, 250);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(331, 309);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(201, 406);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(75, 23);
            this.buttoncancel.TabIndex = 10;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            // 
            // buttonfinish
            // 
            this.buttonfinish.Location = new System.Drawing.Point(497, 406);
            this.buttonfinish.Name = "buttonfinish";
            this.buttonfinish.Size = new System.Drawing.Size(75, 23);
            this.buttonfinish.TabIndex = 11;
            this.buttonfinish.Text = "Finish Order";
            this.buttonfinish.UseVisualStyleBackColor = true;
            // 
            // Purchase_summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonfinish);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.labeldurasi);
            this.Controls.Add(this.labelcost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelcontact);
            this.Controls.Add(this.labelhome);
            this.Name = "Purchase_summary";
            this.Text = "Purchase_summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelhome;
        private System.Windows.Forms.Label labelcontact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelcost;
        private System.Windows.Forms.Label labeldurasi;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Button buttonfinish;
    }
}