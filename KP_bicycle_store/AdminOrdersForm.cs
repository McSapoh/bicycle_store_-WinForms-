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
    public partial class AdminOrdersForm : Form
    {
        private string query = "";
        public AdminOrdersForm()
        {
            InitializeComponent();
            GetOrderTable();
            GetBicycleOrderTable();
        }
        private void GetBicycleOrderTable ()
        {
            query = "select * from bicycle_orders;";
            List<string[]> ResulOrder = DataBaseWorker.ExecuteQuery(query, 5);
            if (ResulOrder != null)
            {
                foreach (string[] s in ResulOrder)
                    BicycleOrderTable.Rows.Add(s);
            }
            DataBaseWorker.SetGridStyle(BicycleOrderTable);
        }
        private void GetOrderTable()
        {
            query = "select * from orders;";
            List<string[]> ResulOrder = DataBaseWorker.ExecuteQuery(query, 3);
            if (ResulOrder != null)
            {
                foreach (string[] s in ResulOrder)
                    OrderTable.Rows.Add(s);
            }
            DataBaseWorker.SetGridStyle(OrderTable);
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainFormButton_Click(object sender, EventArgs e)
        {
            Hide();
            var mainForm = new AdminMainForm();
            mainForm.Show();
        }

        private void ClientsFormButton_Click(object sender, EventArgs e)
        {
            Hide();
            var clientsForm = new AdminClientsForm();
            clientsForm.Show();
        }

        private void EditButtonButton_Click(object sender, EventArgs e)
        {
            Hide();
            var editForm = new AdminTypesProducersCountriesForm();
            editForm.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            var logoutForm = new LoginForm();
            logoutForm.Show();
        }

        private void UserPicture_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible == true)
                menuPanel.Visible = false;
            else
                menuPanel.Visible = true;
        }
    }
}
