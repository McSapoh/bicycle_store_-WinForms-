using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP_bicycle_store
{
    public partial class RegistrationForm : Form
    {
        private string fullnamePlaceholder = "Введіть повне ім'я";
        private string phonePlaceholder = "Введіть номер телефону";
        private string emailPlaceholder = "Введіть email";
        private string adressPlaceholder = "Введіть адресу";
        private string usernamePlaceholder = "Введіть ім'я користувача";
        private string passwordPlaceholder = "Введіть пароль";
        private string confirmedPasswordPlaceholder = "Повторіть пароль";
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            FullNameTextBox.ForeColor = Color.DimGray;
            PhoneTextBox.ForeColor = Color.DimGray;
            EmailTextBox.ForeColor = Color.DimGray;
            AdressTextBox.ForeColor = Color.DimGray;
            UsernameTextBox.ForeColor = Color.DimGray;
            PasswordTextBox.ForeColor = Color.DimGray;
            ConfirmedPasswordTextBox.ForeColor = Color.DimGray;

            FullNameTextBox.Text = fullnamePlaceholder;
            PhoneTextBox.Text = phonePlaceholder;
            EmailTextBox.Text = emailPlaceholder;
            AdressTextBox.Text = adressPlaceholder;
            UsernameTextBox.Text = usernamePlaceholder;
            PasswordTextBox.Text = passwordPlaceholder;
            ConfirmedPasswordTextBox.Text = confirmedPasswordPlaceholder;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LogInButton_Click(object sender, EventArgs e)
        {
            Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void FullNameTextBox_Enter(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text == fullnamePlaceholder)
            {
                FullNameTextBox.Text = "";
                FullNameTextBox.ForeColor = Color.Black;
                FullNameTextBox.Font = new Font("Times New Roman", 14.2F);
            }
        }

        private void PhoneTextBox_Enter(object sender, EventArgs e)
        {
            if (PhoneTextBox.Text == phonePlaceholder)
            {
                PhoneTextBox.Text = "";
                PhoneTextBox.ForeColor = Color.Black;
                PhoneTextBox.Font = new Font("Times New Roman", 14.2F);
            }
        }

        private void EmailTextBox_Enter(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == emailPlaceholder)
            {
                EmailTextBox.Text = "";
                EmailTextBox.ForeColor = Color.Black;
                EmailTextBox.Font = new Font("Times New Roman", 14.2F);
            }
        }

        private void AdressTextBox_Enter(object sender, EventArgs e)
        {
            if (AdressTextBox.Text == adressPlaceholder)
            {
                AdressTextBox.Text = "";
                AdressTextBox.ForeColor = Color.Black;
                AdressTextBox.Font = new Font("Times New Roman", 14.2F);
            }
        }

        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == usernamePlaceholder)
            {
                UsernameTextBox.Text = "";
                UsernameTextBox.ForeColor = Color.Black;
                UsernameTextBox.Font = new Font("Times New Roman", 14.2F);
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == passwordPlaceholder)
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.ForeColor = Color.Black;
                PasswordTextBox.Font = new Font("Times New Roman", 14.2F);
            }
        }

        private void ConfirmedPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (ConfirmedPasswordTextBox.Text == confirmedPasswordPlaceholder)
            {
                ConfirmedPasswordTextBox.Text = "";
                ConfirmedPasswordTextBox.ForeColor = Color.Black;
                ConfirmedPasswordTextBox.Font = new Font("Times New Roman", 14.2F);
            }
        }

        private void FullNameTextBox_Leave(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text == "")
            {
                FullNameTextBox.Text = fullnamePlaceholder;
                FullNameTextBox.ForeColor = Color.Gray;
                FullNameTextBox.Font = new Font("Times New Roman", 16.2F);
            }
        }

        private void PhoneTextBox_Leave(object sender, EventArgs e)
        {
            if (PhoneTextBox.Text == "")
            {
                PhoneTextBox.Text = phonePlaceholder;
                PhoneTextBox.ForeColor = Color.Gray;
                PhoneTextBox.Font = new Font("Times New Roman", 16.2F);
            }
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == "")
            {
                EmailTextBox.Text = emailPlaceholder;
                EmailTextBox.ForeColor = Color.Gray;
                EmailTextBox.Font = new Font("Times New Roman", 16.2F);
            }
        }

        private void AdressTextBox_Leave(object sender, EventArgs e)
        {
            if (AdressTextBox.Text == "")
            {
                AdressTextBox.Text = adressPlaceholder;
                AdressTextBox.ForeColor = Color.Gray;
                AdressTextBox.Font = new Font("Times New Roman", 16.2F);
            }
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "")
            {
                UsernameTextBox.Text = usernamePlaceholder;
                UsernameTextBox.ForeColor = Color.Gray;
                UsernameTextBox.Font = new Font("Times New Roman", 16.2F);
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

        private void ConfirmedPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (ConfirmedPasswordTextBox.Text == "")
            {
                ConfirmedPasswordTextBox.Text = confirmedPasswordPlaceholder;
                ConfirmedPasswordTextBox.ForeColor = Color.Gray;
            }
            else
                ConfirmedPasswordTextBox.PasswordChar = '*';
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text == fullnamePlaceholder || 
            PhoneTextBox.Text == phonePlaceholder || 
            EmailTextBox.Text == emailPlaceholder ||
            AdressTextBox.Text == adressPlaceholder ||
            UsernameTextBox.Text == usernamePlaceholder ||
            PasswordTextBox.Text == passwordPlaceholder ||
            ConfirmedPasswordTextBox.Text == confirmedPasswordPlaceholder)
            {
                MessageBox.Show("Заповніть всі поля!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool IsNumber = int.TryParse(PhoneTextBox.Text, out int res);
                if (DataBaseWorker.IsLogin(UsernameTextBox.Text))
                    MessageBox.Show("Користувач з таким іменем, вже зареєстрований.\n Введіь інший логін", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (PasswordTextBox.Text != ConfirmedPasswordTextBox.Text)
                    MessageBox.Show("Підтвердження паролю не співпадає з паролем", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (IsNumber == false)
                    MessageBox.Show("Номер телефону повинен буди числом", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    //insert into clients(client_name, phone, email, adress, username, password) values('Petrenko Petro', '0123456789', 'ppetrenko@gmail.com', 'Ukraine, Kiev', 'ppetrenko', '0000');
                    string query = "insert into clients (client_name, phone, email, adress, " +
                        $"username, password) values ('{FullNameTextBox.Text}', '{PhoneTextBox.Text}'," +
                        $"'{EmailTextBox.Text}', '{AdressTextBox.Text}', '{UsernameTextBox.Text}', " +
                        $"'{PasswordTextBox.Text}');";
                    DataBaseWorker.OpenConnection();
                    int responseNum = DataBaseWorker.ExecuteQueryWithoutResponse(query);
                    if (responseNum == 1)
                        MessageBox.Show("Акаунт успішно створено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (responseNum == 0)
                        MessageBox.Show("Акаунт не створено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (responseNum == -1)
                        MessageBox.Show("Помилка з базою даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataBaseWorker.CloseConnection();
                    Hide();
                    var usermainForm = new UserMainForm(UsernameTextBox.Text);
                    usermainForm.Show();
                }
            }
        }
    }
}
