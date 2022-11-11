using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KP_bicycle_store
{
    public partial class UserMainForm : Form
    {
        private int responseNum, removeIn = -1;
        private string query, searchPlaceholder = "Введіть запит", bicycleOrderId = "0", orderId = "";
        public UserMainForm(string username)
        {
            InitializeComponent();
            GetBicycleTable();
            userNameLabel.Text = username;
            GetBicycleOrdersTable();
            GetOrderId();
        }
        private void GetOrderId()
        {
            query = "select max(bicycle_order_id) from bicycle_orders;";
            string s = DataBaseWorker.ExecuteQuery(query);
            if (s == "")
                bicycleOrderId = "0";
            else
                bicycleOrderId = s;
        }
        private void GetBicycleOrdersTable()
        {
            DataBaseWorker.SetGridStyle(BicycleOrderTable);
        }
        private void GetBicycleTable()
        {
            query = "select * from user_order;";
            List<string[]> ResultBicycle = DataBaseWorker.ExecuteQuery(query, 8);
            if (ResultBicycle == null)
                MessageBox.Show("Нічого не знайдено", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach(string[] s in ResultBicycle)
                {
                    BicycleTable.Rows.Add(s);
                }
                DataBaseWorker.SetGridStyle(BicycleTable);
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void ResetButton_Click(object sender, EventArgs e)
        {
            BicycleOrderTable.Rows.Clear();
            DataBaseWorker.SetGridStyle(BicycleOrderTable);
            bicycleOrderId = "";
        }
        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            if (BicycleIdTextBox.Text == "" ||
            BicycleNameTextBox.Text == "" ||
            PriceTextBox.Text == "" ||
            CostTextBox.Text == "")
                MessageBox.Show("Виберіть модель велосипеда", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bicycleOrderId = (int.Parse(bicycleOrderId) + 1).ToString();
                BicycleOrderTable.Rows.Add(bicycleOrderId, BicycleIdTextBox.Text, QuantityTextBox.Text, PriceTextBox.Text, CostTextBox.Text);
                DataBaseWorker.SetGridStyle(BicycleOrderTable);
            }
        }
        private void QuantityTextBox_Leave(object sender, EventArgs e)
        {
            if (QuantityTextBox.Text != null)
            {
                if (int.TryParse(QuantityTextBox.Text, out int parsedQuantity))
                {
                    query = $"select quantity from user_order where bicycle_id={BicycleIdTextBox.Text}";
                    if (parsedQuantity > int.Parse(DataBaseWorker.ExecuteQuery(query)))
                    {
                        MessageBox.Show("Такої кількості велосипедів нема в наявності", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        QuantityTextBox.Text = null;
                    }
                    else
                    {
                        PriceTextBox.Text = (string)BicycleTable.CurrentRow.Cells[3].Value;
                        CostTextBox.Text = (int.Parse(QuantityTextBox.Text) * int.Parse(PriceTextBox.Text)).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Кількість велосипедів повинна бути числом", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QuantityTextBox.Text = null;
                }
            }
        }
        private void BicycleTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            removeIn = -1;
            BicycleIdTextBox.Text = (string)BicycleTable.CurrentRow.Cells[0].Value;
            BicycleNameTextBox.Text = (string)BicycleTable.CurrentRow.Cells[1].Value;
            QuantityTextBox.Text = "1";
            PriceTextBox.Text = (string)BicycleTable.CurrentRow.Cells[3].Value;
            CostTextBox.Text = (int.Parse(QuantityTextBox.Text) * int.Parse(PriceTextBox.Text)).ToString();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (BicycleOrderTable.Rows[0].Cells[1].Value == null)
                MessageBox.Show("Додайте в замовелння хоча б один велосипед", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                query = $"select client_id from clients where username = '{userNameLabel.Text}'";
                string client_id = DataBaseWorker.ExecuteQuery(query);
                int cost = 0;
                for (int i = 0; i < (BicycleOrderTable.RowCount)-1; i++)
                {
                    cost += int.Parse(BicycleOrderTable[4, i].Value.ToString());
                }
                query = "insert into orders(client_id, cost) values" +
                    $"({client_id}, {cost});";
                responseNum = DataBaseWorker.ExecuteQueryWithoutResponse(query);
                query = "select max(order_id) from orders;";
                orderId = DataBaseWorker.ExecuteQuery(query);
                for (int i = 0; i < BicycleOrderTable.RowCount-1; i++)
                {
                    string s = $"('{BicycleOrderTable[1, i]}', '{BicycleOrderTable[2, i]}', '{BicycleOrderTable[3, i]}', '{BicycleOrderTable[4, i]}')";
                    query = $"insert into bicycle_orders(bicycle_id, quantity, bicycle_price, order_id) values " +
                        $"('{BicycleOrderTable[1, i].Value}', '{BicycleOrderTable[2, i].Value}', " +
                        $"'{BicycleOrderTable[3, i].Value}', '{orderId}');";
                    responseNum = DataBaseWorker.ExecuteQueryWithoutResponse(query);
                }
                if (responseNum == 1)
                {
                    BicycleOrderTable.Rows.Clear();
                    GetBicycleOrdersTable();
                    MessageBox.Show("Замовлення відправлено в обробку", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (responseNum == 0)
                    MessageBox.Show("Замовлення не відправлено в обробку!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (responseNum == -1)
                    MessageBox.Show("Помилка з базою даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataBaseWorker.SetGridStyle(BicycleOrderTable);
            }
        }

        private void SearchTextBox_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == searchPlaceholder)
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = Color.Black;
                SearchTextBox.Font = new Font("Times New Roman", 14.2F);
            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                SearchTextBox.Text = searchPlaceholder;
                SearchTextBox.ForeColor = Color.Gray;
                SearchTextBox.Font = new Font("Times New Roman", 16.2F);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string query = $"select * from user_order where bicycle_name like '%{SearchTextBox.Text}%'" +
                $"or wheel_diameter like '%{SearchTextBox.Text}%'" +
                $"or bicycle_type_name like '%{SearchTextBox.Text}%'" +
                $"or producer_name like '%{SearchTextBox.Text}%'" +
                $"or producer_country_name like '%{SearchTextBox.Text}%';";
            List<string[]> ResultBicycle = DataBaseWorker.ExecuteQuery(query, 8);
            if (ResultBicycle != null)
            {
                BicycleTable.Rows.Clear();
                foreach (string[] s in ResultBicycle)
                    BicycleTable.Rows.Add(s);
                DataBaseWorker.SetGridStyle(BicycleTable);
            }
            else
                MessageBox.Show("Нічого не знайдено", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void RemoveFromOrderButton_Click(object sender, EventArgs e)
        {
            if (removeIn != -1)
            {
                BicycleOrderTable.Rows.RemoveAt(removeIn);
                BicycleOrderTable.Refresh();
            }
        }

        private void BicycleOrderTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            removeIn = BicycleOrderTable.CurrentCell.RowIndex;
            query = $"select bicycle_name from bicycles where bicycle_id = {(string)BicycleOrderTable.CurrentRow.Cells[1].Value};";
            BicycleNameTextBox.Text = DataBaseWorker.ExecuteQuery(query);
            BicycleIdTextBox.Text = (string)BicycleOrderTable.CurrentRow.Cells[1].Value;
            QuantityTextBox.Text = (string)BicycleOrderTable.CurrentRow.Cells[2].Value; ;
            CostTextBox.Text = (string)BicycleOrderTable.CurrentRow.Cells[3].Value;
            PriceTextBox.Text = (int.Parse(CostTextBox.Text) / int.Parse(QuantityTextBox.Text)).ToString();
            bicycleOrderId = (string)BicycleOrderTable.CurrentRow.Cells[0].Value;
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            Hide();
            var editProfileForm = new UserEditProfileForm(userNameLabel.Text);
            editProfileForm.Show();
        }
    }
}
