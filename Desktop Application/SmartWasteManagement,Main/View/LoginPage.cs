using SmartWasteManagement.Main.Database.Model;
using SmartWasteManagement.Main.Database.Query;
using SmartWasteManagement.Main.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWasteManagement.Main.View
{
    public partial class LoginPage : Form
    {
        public MongoDBHandler db_handler;
        public UserCredentialQuery user_query { get; set; }
        public UserCredentialModel LoggedInUser { get; set; }
        private HomePage homePage;

        public LoginPage(HomePage homePage, MongoDBHandler db_handler)
        {
            InitializeComponent();

            this.homePage = homePage;
            this.db_handler = db_handler;
            this.user_query = new UserCredentialQuery(db_handler);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserIDTxtBox.Text == "" || PasswordTxtBox.Text == "")
            {
                // Show fields required message box
                LoginLbl.Text = "Both User ID and Password fields must be filled out.";
                LoginLbl.ForeColor = Color.Red;
                return;
            }
            else
            {
                var login_result = AttemptLogin();
                if (login_result)
                {
                    // Show login successful message box
                    LoginLbl.Text = "Login Successful";
                    LoginLbl.ForeColor = Color.Blue;

                    // Emit logged in user details
                    EmitUserDetails();

                    // Update last user login date time
                    user_query.UpdateLoginTime(LoggedInUser.UserID);

                    // Close this window
                    this.Close();
                }
                else
                {
                    // Show login unsuccessful message
                    LoginLbl.Text = "Invalid credentials \nLogin Unsuccessful";
                    LoginLbl.ForeColor = Color.Red;

                    return;
                }
            }
        }

        private bool AttemptLogin()
        {
            var user = user_query.GetUserInfo(UserIDTxtBox.Text);
            if (user.UserID != UserIDTxtBox.Text ||
                user.Password != PasswordTxtBox.Text
                )
            {
                return false;
            }
            else
            {
                LoggedInUser = user;
                return true;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            RegisterUserPage registerPage = new RegisterUserPage(db_handler, user_query);
            registerPage.Show();
            Enabled = false;
            registerPage.FormClosed += (sender, e) =>
            {
                Enabled = true;
                registerPage.Dispose();
            };
        }

        private void EmitUserDetails()
        {
            homePage.Invoke(() =>
            {
                homePage.setLoggedInUser(LoggedInUser);
            });
        }
    }
}
