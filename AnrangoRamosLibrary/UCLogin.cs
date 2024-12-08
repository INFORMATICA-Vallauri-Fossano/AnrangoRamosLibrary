using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AnrangoRamosLibrary
{
    public partial class UCLogin: UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
            ResetEmailPassword();
        }
        private string email;
        private string password;
        private bool validCredentials=false;
        public UCLogin(string guideText)
        {
            lblGuide.Text = guideText;
            ResetEmailPassword();
        }
        public string Email { get => email;}
        //public string Password { get => password;}
        public bool ValidCredentials { get => validCredentials; }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (RegexUtilities.IsValidEmail(txtEmail.Text.Trim())) email = txtEmail.Text.Trim();
                else throw new Exception("Email non formata Correttamente");
                password = txtPassword.Text;
                //if (ValidateCredentials(email, password)) {
                validCredentials = true;
                MessageBox.Show("Login Effettuato con Successo!");
                //}
                //else throw new Exception("Email e Password non Corrispondono");

            }
            catch (Exception ex)
            {
                ResetEmailPassword();
                MessageBox.Show(ex.Message);
            }
        }
        
        private void ResetEmailPassword()
        {
            email = "";
            password = "";
            txtPassword.Text = "";
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(IsKeyLocked(Keys.CapsLock)) lblCapsLock.Visible = true;
                else lblCapsLock.Visible = false;
        }
    }
}
