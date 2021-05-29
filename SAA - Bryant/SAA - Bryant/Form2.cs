using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAA___Bryant
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            tBoxPassword.UseSystemPasswordChar = true;
            tBoxConfirmPassword.UseSystemPasswordChar = true;
        }

        private void pBoxViewPassword_Click(object sender, EventArgs e)
        {
            if(tBoxPassword.UseSystemPasswordChar == true)
            {
                tBoxPassword.UseSystemPasswordChar = false;
                pBoxViewPassword.Image = SAA___Bryant.Properties.Resources.Hide_512;
            }
            else
            {
                tBoxPassword.UseSystemPasswordChar = true;
                pBoxViewPassword.Image = SAA___Bryant.Properties.Resources.view_512;
            }
        }

        private void pBoxViewConfirmPassword_Click(object sender, EventArgs e)
        {
            if(tBoxConfirmPassword.UseSystemPasswordChar == true)
            {
                tBoxConfirmPassword.UseSystemPasswordChar = false;
                pBoxViewConfirmPassword.Image = SAA___Bryant.Properties.Resources.Hide_512;
            }
            else
            {
                tBoxConfirmPassword.UseSystemPasswordChar = true;
                pBoxViewConfirmPassword.Image = SAA___Bryant.Properties.Resources.view_512;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 LandingPage = new Form1();
            LandingPage.Show();
            this.Close();
        }

        private void linkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 LandingPage = new Form1();
            LandingPage.Show();
            this.Close();
        }

        private void linkContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Ke Help Page
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string cekerror = "Good";
            //Cek Username sudah dipakai atau belum
            //Cek email sudah ada atau belum
            //Cek email sama atau tidak
            //Cek Pass sama atau tidak
            //Cek ada yang kosong atau tidak
            //Auto Generate ID
            //INSERT INTO

            if(cekerror == "Good")
            {
                MessageBox.Show("Data Successfully Created");
                //ke Home Page
            }

        }
    }
}
