using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forgot_pass
{
    public partial class FormLandingPage : Form
    {
        public FormLandingPage()
        {
            InitializeComponent();
            groupBoxHeader.BackColor = Color.FromArgb(200, Color.DarkSlateBlue);
            panelWelcome.BackColor = Color.FromArgb(200, Color.DarkSlateBlue);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
