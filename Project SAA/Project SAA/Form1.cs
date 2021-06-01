using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_SAA
{
    public partial class FormLandpage : Form
    {
        public FormLandpage()
        {
            InitializeComponent();
            groupBoxHeader.BackColor = Color.FromArgb(200, Color.DarkSlateBlue);
            panelWelcome.BackColor = Color.FromArgb(200, Color.DarkSlateBlue);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {

        }
    }
}
