namespace praktikum_week_13_appdev_Erick_Gautama
{
    partial class Formhome
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
            this.checkBoxtanggal = new System.Windows.Forms.CheckBox();
            this.checkBoxteam = new System.Windows.Forms.CheckBox();
            this.checkBoxnama = new System.Windows.Forms.CheckBox();
            this.dataGridtabel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtabel)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxtanggal
            // 
            this.checkBoxtanggal.AutoSize = true;
            this.checkBoxtanggal.Location = new System.Drawing.Point(46, 29);
            this.checkBoxtanggal.Name = "checkBoxtanggal";
            this.checkBoxtanggal.Size = new System.Drawing.Size(65, 17);
            this.checkBoxtanggal.TabIndex = 0;
            this.checkBoxtanggal.Text = "Tanggal";
            this.checkBoxtanggal.UseVisualStyleBackColor = true;
            this.checkBoxtanggal.CheckedChanged += new System.EventHandler(this.checkBoxtanggal_CheckedChanged);
            // 
            // checkBoxteam
            // 
            this.checkBoxteam.AutoSize = true;
            this.checkBoxteam.Location = new System.Drawing.Point(183, 29);
            this.checkBoxteam.Name = "checkBoxteam";
            this.checkBoxteam.Size = new System.Drawing.Size(84, 17);
            this.checkBoxteam.TabIndex = 1;
            this.checkBoxteam.Text = "Team Name";
            this.checkBoxteam.UseVisualStyleBackColor = true;
            this.checkBoxteam.CheckedChanged += new System.EventHandler(this.checkBoxteam_CheckedChanged);
            // 
            // checkBoxnama
            // 
            this.checkBoxnama.AutoSize = true;
            this.checkBoxnama.Location = new System.Drawing.Point(308, 29);
            this.checkBoxnama.Name = "checkBoxnama";
            this.checkBoxnama.Size = new System.Drawing.Size(86, 17);
            this.checkBoxnama.TabIndex = 2;
            this.checkBoxnama.Text = "Player Name";
            this.checkBoxnama.UseVisualStyleBackColor = true;
            this.checkBoxnama.CheckedChanged += new System.EventHandler(this.checkBoxnama_CheckedChanged);
            // 
            // dataGridtabel
            // 
            this.dataGridtabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridtabel.Location = new System.Drawing.Point(12, 52);
            this.dataGridtabel.Name = "dataGridtabel";
            this.dataGridtabel.Size = new System.Drawing.Size(776, 397);
            this.dataGridtabel.TabIndex = 3;
            // 
            // Formhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridtabel);
            this.Controls.Add(this.checkBoxnama);
            this.Controls.Add(this.checkBoxteam);
            this.Controls.Add(this.checkBoxtanggal);
            this.Name = "Formhome";
            this.Text = "THE Form";
            this.Load += new System.EventHandler(this.Formhome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxtanggal;
        private System.Windows.Forms.CheckBox checkBoxteam;
        private System.Windows.Forms.CheckBox checkBoxnama;
        private System.Windows.Forms.DataGridView dataGridtabel;
    }
}

