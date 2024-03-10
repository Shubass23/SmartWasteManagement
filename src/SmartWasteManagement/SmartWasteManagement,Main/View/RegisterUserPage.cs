using SmartWasteManagement.Main.Database;
using SmartWasteManagement.Main.Database.Model;
using SmartWasteManagement.Main.Database.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SmartWasteManagement.Main.View
{
    public partial class RegisterUserPage : Form
    {
        public MongoDBHandler db_handler { get; set; }
        public UserCredentialQuery user_query { get; set; }

        public RegisterUserPage(MongoDBHandler db_handler, UserCredentialQuery user_query)
        {
            InitializeComponent();
            this.db_handler = db_handler;
            this.user_query = user_query;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            FirstNameTxtBox.Text = string.Empty;
            LastNameTxtBox.Text = string.Empty;
            UserIDTxtBox.Text = string.Empty;
            PasswordTxtBox.Text = string.Empty;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (
                FirstNameTxtBox.Text != string.Empty ||
                LastNameTxtBox.Text != string.Empty ||
                UserIDTxtBox.Text != string.Empty ||
                PasswordTxtBox.Text != string.Empty
                )
            {
                // Fill in details into data model
                UserCredentialModel user_details = new UserCredentialModel
                {
                    UserID = UserIDTxtBox.Text.ToString(),
                    FirstName = FirstNameTxtBox.Text.ToString(),
                    LastName = LastNameTxtBox.Text.ToString(),
                    Password = PasswordTxtBox.Text.ToString(),
                    CreationDate = DateTime.Now,
                    LastLogin = DateTime.Now,
                    LastLogout = DateTime.Now
                };

                bool push_result;
                bool NewUserRegistration = user_query.UserExistByID(user_details.UserID);

                if (!NewUserRegistration)
                {
                    // Push new user data to the database
                    push_result = user_query.AddNewUser(user_details);
                    if (push_result)
                    {
                        MessageBox.Show("New user registered successfully!", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unable to register new user! User ID probably has registered.1", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Push edited user data to the database
                    push_result = user_query.EditUser(user_details);
                    if (push_result)
                    {
                        MessageBox.Show("User details edited successfully!", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unable to register new user! User ID probably has registered.2", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Please fill in all required fields",
                    "User Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );

                return;
            }
        }
    }
}