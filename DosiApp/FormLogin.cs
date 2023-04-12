using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DosiApp
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        private const string defaultUsername = "admin";
        private const string defaultPassword = "0123123";

        string username;
        string password;
        public FormLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            this.Login();
        }

        private void OnEnter(object sender, EventArgs e)
        {
            this.Login();
        }

        private void Login()
        {
            this.username = this.txtUsername.Text.Trim();
            this.password = this.txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(this.username) || string.IsNullOrEmpty(this.password))
            {
                XtraMessageBox.Show("Username or password is emtpy");
                return;
            }
            if (defaultUsername.Equals(this.username) && defaultPassword.Equals(this.password))
            {
            }
            else
            {
                XtraMessageBox.Show("Username or password is incorect");
            }
        }


        private void OnUsernameValidated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUsername.Text))
            {
                this.loginValidator.SetError(this.txtUsername, "Username is required.");
            }
            else
            {
                this.loginValidator.SetError(this.txtUsername, string.Empty);
            }
        }

        private void OnPasswordValidated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                this.loginValidator.SetError(this.txtPassword, "Password is required.");
            }
            else
            {
                this.loginValidator.SetError(this.txtPassword, string.Empty);
            }
        }

        private void OnLoginKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
                var handle = SplashScreenManager.ShowOverlayForm(this);
                var home = new FormHome();
                home.Show();
                this.Hide();
                SplashScreenManager.CloseOverlayForm(handle);
            }
        }

        private void OnLoginKeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
