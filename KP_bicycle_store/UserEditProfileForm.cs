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
    public partial class UserEditProfileForm : Form
    {
        private string userFullName;
        private string userPhone;
        private string userEmail;
        private string userAdress;
        private string userUsername;
        private string userPassword;
        private string userConfirmedPassword;
        public UserEditProfileForm(string username)
        {
            InitializeComponent();
            userNameLabel.Text = username;
            ResetChanges();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetChanges ()
        {
            string query = "select client_name, phone, email, adress, password from clients where" +
                $" username='{userNameLabel.Text}';";
            List<string[]> userInformation = DataBaseWorker.ExecuteQuery(query, 5);

            userFullName = userInformation[0][0];
            userPhone = userInformation[0][1];
            userEmail = userInformation[0][2];
            userAdress = userInformation[0][3];
            userUsername = userNameLabel.Text;
            userPassword = userInformation[0][4];
            userConfirmedPassword = userInformation[0][4];

            FullNameTextBox.Text = userFullName;
            PhoneTextBox.Text = userPhone;
            EmailTextBox.Text = userEmail;
            AdressTextBox.Text = userAdress;
            UsernameTextBox.Text = userNameLabel.Text;
            PasswordTextBox.Text = userPassword;
            ConfirmedPasswordTextBox.Text = userConfirmedPassword;
        }

        private void ResetChangesButton_Click(object sender, EventArgs e)
        {
            ResetChanges();
        }
        private void FullNameTextBox_Leave(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text != userFullName)
                FullNameTextBox.Font = new Font("Times New Roman", 14.2F, FontStyle.Bold);
        }

        private void PhoneTextBox_Leave(object sender, EventArgs e)
        {
            if (PhoneTextBox.Text != userPhone)
                PhoneTextBox.Font = new Font("Times New Roman", 14.2F, FontStyle.Bold);
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            if (EmailTextBox.Text != userEmail)
                EmailTextBox.Font = new Font("Times New Roman", 14.2F, FontStyle.Bold);
        }

        private void AdressTextBox_Leave(object sender, EventArgs e)
        {
            if (AdressTextBox.Text != userAdress)
                AdressTextBox.Font = new Font("Times New Roman", 14.2F, FontStyle.Bold);
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text != userUsername)
                UsernameTextBox.Font = new Font("Times New Roman", 14.2F, FontStyle.Bold);
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text != userPassword)
                PasswordTextBox.Font = new Font("Times New Roman", 14.2F, FontStyle.Bold);
        }

        private void ConfirmedPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (ConfirmedPasswordTextBox.Text != userConfirmedPassword)
                ConfirmedPasswordTextBox.Font = new Font("Times New Roman", 14.2F, FontStyle.Bold);
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text == "" ||
            PhoneTextBox.Text == "" ||
            EmailTextBox.Text == "" ||
            AdressTextBox.Text == "" ||
            UsernameTextBox.Text == "" ||
            PasswordTextBox.Text == "" ||
            ConfirmedPasswordTextBox.Text == "")
            {
                MessageBox.Show("Заповніть всі поля!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (DataBaseWorker.IsLogin(UsernameTextBox.Text) && userUsername != UsernameTextBox.Text)
                    MessageBox.Show("Користувач з таким іменем, вже зареєстрований.\n Введіь інший логін", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (PasswordTextBox.Text != ConfirmedPasswordTextBox.Text)
                    MessageBox.Show("Підтвердження паролю не співпадає з паролем", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (long.TryParse(PhoneTextBox.Text, out long res) == false) 
                    MessageBox.Show("Номер телефону повинен буди числом", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string query = $"update clients set client_name='{FullNameTextBox.Text}', phone=" +
                        $"'{PhoneTextBox.Text}', email='{EmailTextBox.Text}', adress='{AdressTextBox.Text}'," +
                        $" username='{UsernameTextBox.Text}', password='{PasswordTextBox.Text}'" +
                        $" where username='{userUsername}';";
                    DataBaseWorker.OpenConnection();
                    int responseNum = DataBaseWorker.ExecuteQueryWithoutResponse(query);
                    if (responseNum == 1)
                        MessageBox.Show("Зміни успішно внесені", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (responseNum == 0)
                        MessageBox.Show("Зміни не внесені!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (responseNum == -1)
                        MessageBox.Show("Помилка з базою даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataBaseWorker.CloseConnection();
                }
            }
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Точно бажаєте видалити цей акаунт", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string query = $"delete from clients where username='{userNameLabel.Text}';";
                int responseNum = DataBaseWorker.ExecuteQueryWithoutResponse(query);
                if (responseNum == 1)
                {
                    MessageBox.Show("Акаунт успішно видалено", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    var loginForm = new LoginForm();
                    loginForm.Show();
                }
                else if (responseNum == 0)
                    MessageBox.Show("Акаунт не видалено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (responseNum == -1)
                    MessageBox.Show("Помилка з базою даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void UserPicture_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible == true)
                menuPanel.Visible = false;
            else
                menuPanel.Visible = true;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            Hide();
            var ordersForm = new UserOrdersForm(userNameLabel.Text);
            ordersForm.Show();
        }

        private void MainFormButton_Click(object sender, EventArgs e)
        {
            Hide();
            var mainForm = new UserMainForm(userNameLabel.Text);
            mainForm.Show();
        }
    }
}
