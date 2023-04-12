using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetOtpApp
{
    public partial class FormLogin : Form
    {
        private const string defaultUsername = "admin";
        private const string defaultPassword = "0123123";

        string? username;
        string? password;
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
                MessageBox.Show("Username or password is emtpy");
                return;
            }
            if (defaultUsername.Equals(this.username) && defaultPassword.Equals(this.password))
            {
                var otpForm = new FormGetOtp();
                otpForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorect");
            }
        }

        private void OnUsernameValidated(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.txtUsername.Text))
            {
                this.loginProvider.SetError(this.txtUsername, "Username is required.");
            }
            else
            {
                this.loginProvider.SetError(this.txtUsername, string.Empty);
            }
        }

        private void OnPasswordValidated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                this.loginProvider.SetError(this.txtPassword, "Password is required.");
            }
            else
            {
                this.loginProvider.SetError(this.txtPassword, string.Empty);
            }
        }
    }
}
