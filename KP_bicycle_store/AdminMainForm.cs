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
    public partial class AdminMainForm : Form
    {
        private string query, res = "";
        public AdminMainForm()
        {
            InitializeComponent();
            GetBicycleTable();
            GetTypesTable();
            GetProducersTable();
            GetCountriesTable();
        }
        private bool IsExist()
        {
            if (TypeIdExist()==false)
            {
                MessageBox.Show("Не існує такого коду типу!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ProducerIdExist() == false)
            {
                MessageBox.Show("Не існує такого коду виробника!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (CountryIdExist() == false)
            {
                MessageBox.Show("Не існує такого коду країни!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool TypeIdExist()
        {
            query = $"select bicycle_type_name from bicycle_types where bicycle_type_id={TypeIdTextBox.Text};";
            res = DataBaseWorker.ExecuteQuery(query);
            if (res == null)
                return false;
            else
                return true;
        }
        private bool ProducerIdExist()
        {
            query = $"select producer_name from producers where producer_name_id={ProducerIdTextBox.Text};";
            res = DataBaseWorker.ExecuteQuery(query);
            if (res == null)
                return false;
            else
                return true;
        }
        private bool CountryIdExist()
        {
            query = $"select producer_country_name from producer_countries where producer_country_id={CountryIdTextBox.Text};";
            res = DataBaseWorker.ExecuteQuery(query);
            if (res == null)
                return false;
            else
                return true;
        }
        private void GetBicycleTable ()
        {
            string query = $"select * from bicycles;";
            List<string[]> ResulOrder = DataBaseWorker.ExecuteQuery(query, 8);
            if (ResulOrder != null)
            {
                foreach (string[] s in ResulOrder)
                    BicyclesTable.Rows.Add(s);
            }
            DataBaseWorker.SetGridStyle(BicyclesTable);
        }
        private void GetTypesTable ()
        {
            string query = $"select * from bicycle_types;";
            List<string[]> ResulOrder = DataBaseWorker.ExecuteQuery(query, 2);
            if (ResulOrder != null)
            {
                foreach (string[] s in ResulOrder)
                    TypesTable.Rows.Add(s);
            }
            DataBaseWorker.SetGridStyle(TypesTable);
        }
        private void GetProducersTable()
        {
            string query = $"select * from producers;";
            List<string[]> ResulOrder = DataBaseWorker.ExecuteQuery(query, 2);
            if (ResulOrder != null)
            {
                foreach (string[] s in ResulOrder)
                    ProducersTable.Rows.Add(s);
            }
            DataBaseWorker.SetGridStyle(ProducersTable);
        }
        private void GetCountriesTable()
        {
            string query = $"select * from producer_countries;";
            List<string[]> ResulOrder = DataBaseWorker.ExecuteQuery(query, 2);
            if (ResulOrder != null)
            {
                foreach (string[] s in ResulOrder)
                    CountriesTable.Rows.Add(s);
            }
            DataBaseWorker.SetGridStyle(CountriesTable);
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BicyclesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BicycleIdLabel.Text = (string)BicyclesTable.CurrentRow.Cells[0].Value;
            BicycleNameTextBox.Text = (string)BicyclesTable.CurrentRow.Cells[1].Value;
            WheelDiameterTextBox.Text = (string)BicyclesTable.CurrentRow.Cells[2].Value;
            PriceTextBox.Text = (string)BicyclesTable.CurrentRow.Cells[3].Value;
            QuantityTextBox.Text = (string)BicyclesTable.CurrentRow.Cells[4].Value;
            TypeIdTextBox.Text = (string)BicyclesTable.CurrentRow.Cells[5].Value;
            ProducerIdTextBox.Text = (string)BicyclesTable.CurrentRow.Cells[6].Value;
            CountryIdTextBox.Text = (string)BicyclesTable.CurrentRow.Cells[7].Value;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            BicycleIdLabel.Text = "";
            BicycleNameTextBox.Text = "";
            WheelDiameterTextBox.Text = "";
            PriceTextBox.Text = "";
            QuantityTextBox.Text = "";
            TypeIdTextBox.Text = "";
            ProducerIdTextBox.Text = "";
            CountryIdTextBox.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (BicycleIdLabel.Text == "")
            {
                query = "select max(bicycle_id) from bicycles;";
                BicycleIdLabel.Text = (int.Parse(DataBaseWorker.ExecuteQuery(query)) + 1).ToString();
            }
            query = "select max(bicycle_id) from bicycles;";
            if (int.Parse(BicycleIdLabel.Text) > int.Parse(DataBaseWorker.ExecuteQuery(query)))
            {
                if (BicycleNameTextBox.Text == "" || WheelDiameterTextBox.Text == "" ||
                PriceTextBox.Text == "" || QuantityTextBox.Text == "" || TypeIdTextBox.Text == "" ||
                ProducerIdTextBox.Text == "" || CountryIdTextBox.Text == "")
                {
                    MessageBox.Show("Заповніть всі поля!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (int.TryParse(WheelDiameterTextBox.Text, out int r1) == false ||
                    int.TryParse(PriceTextBox.Text, out int r2) == false ||
                    int.TryParse(QuantityTextBox.Text, out int r3) == false ||
                    int.TryParse(TypeIdTextBox.Text, out int r4) == false ||
                    int.TryParse(ProducerIdTextBox.Text, out int r5) == false ||
                    int.TryParse(CountryIdTextBox.Text, out int r6) == false)
                {
                    MessageBox.Show("Деякі поля повинні бути числами!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (IsExist() == true)
                    {
                        query = $"insert into bicycles (bicycle_name, wheel_diameter, " +
                        $"price, quantity, bicycle_type_id, producer_name_id, producer_country_id) " +
                        $"values ('{BicycleNameTextBox.Text}', '{WheelDiameterTextBox.Text}', " +
                        $"'{PriceTextBox.Text}', '{QuantityTextBox.Text}', '{TypeIdTextBox.Text}', " +
                        $"'{ProducerIdTextBox.Text}', '{CountryIdTextBox.Text}');";
                        int responseNum = DataBaseWorker.ExecuteQueryWithoutResponse(query);
                        if (responseNum == 1)
                        {
                            MessageBox.Show("Велосипед створено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BicyclesTable.Rows.Clear();
                            GetBicycleTable();
                        }
                        else if (responseNum == 0)
                            MessageBox.Show("Велосипед не створено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (responseNum == -1)
                            MessageBox.Show("Помилка з базою даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (BicycleNameTextBox.Text == "" || WheelDiameterTextBox.Text == "" ||
                PriceTextBox.Text == "" || QuantityTextBox.Text == "" || TypeIdTextBox.Text == "" ||
                ProducerIdTextBox.Text == "" || CountryIdTextBox.Text == "")
                {
                    MessageBox.Show("Заповніть всі поля!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    query = $"update bicycles set bicycle_name='{BicycleNameTextBox.Text}', " +
                        $"wheel_diameter='{WheelDiameterTextBox.Text}', " +
                        $"price='{PriceTextBox.Text}', quantity='{QuantityTextBox.Text}', " +
                        $"bicycle_type_id='{TypeIdTextBox.Text}', " +
                        $"producer_name_id='{ProducerIdTextBox.Text}', " +
                        $"producer_country_id='{CountryIdTextBox.Text}' where bicycle_id={int.Parse(BicycleIdLabel.Text)};";
                    int responseNum = DataBaseWorker.ExecuteQueryWithoutResponse(query);
                    if (responseNum == 1)
                    {
                        MessageBox.Show("Дані успішно збережені!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BicyclesTable.Rows.Clear();
                        GetBicycleTable();
                    }
                    else if (responseNum == 0)
                        MessageBox.Show("Дані не збережено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (responseNum == -1)
                        MessageBox.Show("Помилка з базою даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Точно бажаєте видалити цей велосипед?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string query = $"delete from bicycles where bicycle_id='{BicycleIdLabel.Text}';";
                int responseNum = DataBaseWorker.ExecuteQueryWithoutResponse(query);
                if (responseNum == 1)
                {
                    MessageBox.Show("Велосипед успішно видалено", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BicyclesTable.Rows.Clear();
                    GetBicycleTable();
                    ResetButton_Click(sender, e);
                }
                else if (responseNum == 0)
                    MessageBox.Show("Велосипед не видалено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (responseNum == -1)
                    MessageBox.Show("Помилка з базою даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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

        private void ClientsFormButton_Click(object sender, EventArgs e)
        {
            Hide();
            var clientsForm = new AdminClientsForm();
            clientsForm.Show();
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
