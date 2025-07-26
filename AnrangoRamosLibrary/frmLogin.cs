using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnrangoRamosLibrary
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            ResetEmailPassword();
        }
        public frmLogin(string guideText)
        {
            lblGuide.Text = guideText;
            ResetEmailPassword();
        }
        private string email;
        private string password;
        private bool validCredentials = false;
        public string Email { get => email; }
        //public string Password { get => password;}
        public bool ValidCredentials { get => validCredentials; }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (RegexUtilities.IsValidEmail(txtEmail.Text.Trim())) email = txtEmail.Text.Trim();
                else throw new Exception("Email non formata Correttamente");
                if (RegexUtilities.IsSafePassword(txtPassword.Text)) password = txtPassword.Text;
                else throw new Exception("Password non Sicura");
                if (ValidateCredentials(email, password))
                {
                    validCredentials = true;
                    MessageBox.Show("Login Effettuato con Successo!");
                }
                else throw new Exception("Email e Password non Corrispondono");

            }
            catch (Exception ex)
            {
                ResetEmailPassword();
                MessageBox.Show(ex.Message);
            }
        }

        virtual public bool ValidateCredentials(string email, string password) { return false; }

        private void ResetEmailPassword()
        {
            email = "";
            password = "";
            txtPassword.Text = "";
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsKeyLocked(Keys.CapsLock)) lblCapsLock.Visible = true;
            else lblCapsLock.Visible = false;
        }
    }
}
