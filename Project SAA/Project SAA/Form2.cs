using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SAA
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            groupBoxHeader.BackColor = Color.FromArgb(200, Color.DarkSlateBlue);
            panelLogin.BackColor = Color.FromArgb(200, Color.Silver);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = true;
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            if (textBoxPass.UseSystemPasswordChar == true)
            {
                textBoxPass.UseSystemPasswordChar = false;
                pictureBoxShow.Image = Project_SAA.Properties.Resources.View;
            }
            else
            {
                textBoxPass.UseSystemPasswordChar = true;
                pictureBoxShow.Image = Project_SAA.Properties.Resources.Hide;
            }
        }
    }
}
