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

namespace KP_bicycle_store
{
    public partial class LoginForm : Form
    {
        private string usernamePlaceholder = "Введіть ім'я користувача";
        private string passwordPlaceholder = "Введіть пароль";
        public LoginForm()
        {
            InitializeComponent();
            UsernameTextBox.ForeColor = Color.DimGray;
            PasswordTextBox.ForeColor = Color.DimGray;

            UsernameTextBox.Text = usernamePlaceholder;
            PasswordTextBox.Text = passwordPlaceholder;
        }
        private void UsernameTextBox_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == usernamePlaceholder)
            {
                UsernameTextBox.Text = "";
                UsernameTextBox.ForeColor = Color.Black;
            }
        }
        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == passwordPlaceholder)
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.ForeColor = Color.Black;
            }
        }
        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "")
            {
                UsernameTextBox.Text = usernamePlaceholder;
                UsernameTextBox.ForeColor = Color.Gray;
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.Text = passwordPlaceholder;
                PasswordTextBox.ForeColor = Color.Gray;
            }
            else
                PasswordTextBox.PasswordChar = '*';
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Hide();
            var registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterButton_MouseMove(object sender, MouseEventArgs e)
        {
            RegisterButton.ForeColor = UsernameTextBox.ForeColor;//Color.FromArgb(40, 40, 40);
        }

        private void RegisterButton_MouseLeave(object sender, EventArgs e)
        {
            RegisterButton.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == usernamePlaceholder || PasswordTextBox.Text == passwordPlaceholder)
            {
                MessageBox.Show("Заповніть всі поля!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (DataBaseWorker.IsLogin(UsernameTextBox.Text))
                {
                    string DBpassword = DataBaseWorker.ExecuteQuery($"select password from clients where username='{UsernameTextBox.Text}'");
                    if (DBpassword != PasswordTextBox.Text)
                        MessageBox.Show("Пароль невірний", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        Hide();
                        var userMainform = new UserMainForm(UsernameTextBox.Text);
                        userMainform.Show();
                    }
                }
                else if (UsernameTextBox.Text == "admin" && PasswordTextBox.Text == "admin")
                {
                    Hide();
                    var adminMainform = new AdminMainForm();
                    adminMainform.Show();
                }
                else
                    MessageBox.Show("Користувача з таким логіном нема в системі", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
