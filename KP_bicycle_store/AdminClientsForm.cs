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
    public partial class AdminClientsForm : Form
    {
        public AdminClientsForm()
        {
            InitializeComponent();
            GetClientsTable();
        }

        private void GetClientsTable ()
        {
            string query = $"select * from clients;";
            List<string[]> ResulOrder = DataBaseWorker.ExecuteQuery(query, 7);
            if (ResulOrder != null)
            {
                foreach (string[] s in ResulOrder)
                    ClientsTable.Rows.Add(s);
            }
            DataBaseWorker.SetGridStyle(ClientsTable);
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void EditButtonButton_Click(object sender, EventArgs e)
        {
            Hide();
            var infoForm = new AdminTypesProducersCountriesForm();
            infoForm.Show();
        }

        private void OrdersFormButton_Click(object sender, EventArgs e)
        {
            Hide();
            var ordersForm = new AdminOrdersForm();
            ordersForm.Show();
        }

        private void UserPicture_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible == true)
                menuPanel.Visible = false;
            else
                menuPanel.Visible = true;
        }

        private void MainFormButton_Click(object sender, EventArgs e)
        {
            Hide();
            var mainForm = new AdminMainForm();
            mainForm.Show();
        }
    }
}
