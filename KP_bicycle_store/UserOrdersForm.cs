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
    public partial class UserOrdersForm : Form
    {
        private string query, clientId;
        public UserOrdersForm(string username)
        {
            InitializeComponent();
            userNameLabel.Text = username;
            GetBicycleOrderTable();
        }
        private void GetBicycleOrderTable()
        {
            query = $"select client_id from clients where username='{userNameLabel.Text}'";
            clientId = DataBaseWorker.ExecuteQuery(query);
            query = $"select order_id from orders where client_id={clientId};";
            List<string[]> OrderIdList = DataBaseWorker.ExecuteQuery(query, 1);
            for (int i = 0; i < OrderIdList.Count; i++)
            {
                query = $"select * from bicycle_orders where order_id={OrderIdList[i][0]};";
                List<string[]> ResulOrder = DataBaseWorker.ExecuteQuery(query, 5);
                if (ResulOrder != null)
                {
                    foreach (string[] s in ResulOrder)
                        BicycleOrderTable.Rows.Add(s);
                }
                DataBaseWorker.SetGridStyle(BicycleOrderTable);
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainFormButton_Click(object sender, EventArgs e)
        {
            Hide();
            var mainForm = new UserMainForm(userNameLabel.Text);
            mainForm.Show();
        }

        private void UserNameLabel_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible == true)
                menuPanel.Visible = false;
            else
                menuPanel.Visible = true;
        }

        private void UserPicture_Click(object sender, EventArgs e)
        {
            UserNameLabel_Click(sender, e);
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            Hide();
            var editProfileForm = new UserEditProfileForm(userNameLabel.Text);
            editProfileForm.Show();
        }
    }
}
