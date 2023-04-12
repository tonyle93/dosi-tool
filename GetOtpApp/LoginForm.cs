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
    public partial class LoginForm : Form
    {
        private const string defaultUsername = "admin";
        private const string defaultPassword = "0123123";

        string username;
        string password;
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            this.username = this.txtUsername.Text.Trim();
            this.password = this.txtPassword.Text.Trim();
            if(string.IsNullOrEmpty(this.username) || string.IsNullOrEmpty(this.password))
            {
                MessageBox.Show("Username or password is emtpy");
                return;
            }
            if(defaultUsername.Equals(this.username) && defaultPassword.Equals(this.password))
            {
                var otpForm = new GetViOtpForm();
                otpForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorect");
            }
        }
    }
}
