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
    public partial class AdminTypesProducersCountriesForm : Form
    {
        private string TypeId = "", ProducerId = "", CountryId = "", query;
        private int responseNum;
        public AdminTypesProducersCountriesForm()
        {
            InitializeComponent();
            GetTypesTable();
            GetProducersTable();
            GetCountriesTable();
        }
        private void GetTypesTable()
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

        private void TypesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TypeId = (string)TypesTable.CurrentRow.Cells[0].Value;
            TypeNameTextBox.Text = (string)TypesTable.CurrentRow.Cells[1].Value;
        }
        private void ProducersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProducerId = (string)ProducersTable.CurrentRow.Cells[0].Value;
            ProducerNameTextBox.Text = (string)ProducersTable.CurrentRow.Cells[1].Value;
        }
        private void CountriesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CountryId = (string)CountriesTable.CurrentRow.Cells[0].Value;
            CountryNameTextBox.Text = (string)CountriesTable.CurrentRow.Cells[1].Value;
        }

        private void SaveTypeButton_Click(object sender, EventArgs e)
        {
            if (TypeNameTextBox.Text != "")
            {
                if (TypeId == "")
                {
                    query = $"insert into bicycle_types(bicycle_type_name) values ('{TypeNameTextBox.Text}');";
                    responseNum = DataBaseWorker.ExecuteQueryWithoutResponse(query);
                    if (responseNum == 1)
                    {
                        MessageBox.Show("Тип створено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TypesTable.Rows.Clear();
                        GetTypesTable();
                        TypeId = "";
                        TypeNameTextBox.Text = "";
                    }
                    else if (responseNum == 0)
                        MessageBox.Show("Тип не створено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (responseNum == -1)
                        MessageBox.Show("Помилка з базою даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = $"update bicycle_types set bicycle_type_name='{TypeNameTextBox.Text}' " +
                        $"where bicycle_type_id='{TypeId}';";
                    responseNum = DataBaseWorker.ExecuteQueryWithoutResponse(query);
                    if (responseNum == 1)
                    {
                        MessageBox.Show("Тип оновлено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TypesTable.Rows.Clear();
                        GetTypesTable();
                        TypeNameTextBox.Text = "";
                        TypeId = "";
                    }
                    else if (responseNum == 0)
                        MessageBox.Show("Тип не оновлено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (responseNum == -1)
                        MessageBox.Show("Помилка з базою даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
                MessageBox.Show("Тип повинен мати ім'я!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SaveProducerButton_Click(object sender, EventArgs e)
        {
            if (ProducerNameTextBox.Text != "")
            {
                if (ProducerId == "")
                {
                    query = $"insert into producers(producer_name) values ('{ProducerNameTextBox.Text}');";
                    responseNum = DataBaseWorker.ExecuteQueryWithoutResponse(query);
                    if (responseNum == 1)
                    {
                        MessageBox.Show("Виробника створено створено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ProducersTable.Rows.Clear();
                        GetProducersTable();
                        ProducerId = "";
                        ProducerNameTextBox.Text = "";
                    }
                    else if (responseNum == 0)
                        MessageBox.Show("Виробника не створено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (responseNum == -1)
                        MessageBox.Show("Помилка з базою даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = $"update producers set producer_name='{ProducerNameTextBox.Text}' " +
                        $"where producer_name_id='{ProducerId}';";
                    responseNum = DataBaseWorker.ExecuteQueryWithoutResponse(query);
                    if (responseNum == 1)
                    {
                        MessageBox.Show("Виробника оновлено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TypesTable.Rows.Clear();
                        GetTypesTable();
                        TypeId = "";
                        ProducerNameTextBox.Text = "";
                    }
                    else if (responseNum == 0)
                        MessageBox.Show("Виробника не оновлено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (responseNum == -1)
                        MessageBox.Show("Помилка з базою даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Виробник повинен мати ім'я!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SaveCountryButton_Click(object sender, EventArgs e)
        {
            if (CountryNameTextBox.Text != "")
            {
                if (CountryId == "")
                {
                    query = $"insert into producer_countries(producer_country_name) values ('{CountryNameTextBox.Text}');";
                    responseNum = DataBaseWorker.ExecuteQueryWithoutResponse(query);
                    if (responseNum == 1)
                    {
                        MessageBox.Show("Країну створено створено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CountriesTable.Rows.Clear();
                        GetCountriesTable();
                        CountryId = "";
                        CountryNameTextBox.Text = "";
                    }
                    else if (responseNum == 0)
                        MessageBox.Show("Країну не створено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (responseNum == -1)
                        MessageBox.Show("Помилка з базою даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = $"update producer_countries set producer_country_name='{CountryNameTextBox.Text}' " +
                        $"where producer_country_id='{CountryId}';";
                    responseNum = DataBaseWorker.ExecuteQueryWithoutResponse(query);
                    if (responseNum == 1)
                    {
                        MessageBox.Show("Країну оновлено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CountriesTable.Rows.Clear();
                        GetCountriesTable();
                        CountryId = "";
                        CountryNameTextBox.Text = "";
                    }
                    else if (responseNum == 0)
                        MessageBox.Show("Країну не оновлено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (responseNum == -1)
                        MessageBox.Show("Помилка з базою даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
                MessageBox.Show("Країна повинна мати ім'я!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void MainFormButton_Click(object sender, EventArgs e)
        {
            Hide();
            var mainForm = new AdminMainForm();
            mainForm.Show();
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

        private void ResetCountry_Click(object sender, EventArgs e)
        {
            CountryId = "";
            CountryNameTextBox.Text = "";
        }

        private void ResetProducer_Click(object sender, EventArgs e)
        {
            ProducerId = "";
            ProducerNameTextBox.Text = "";
        }

        private void ResetType_Click(object sender, EventArgs e)
        {
            TypeId = "";
            TypeNameTextBox.Text = "";
        }

        private void RemoveTypeButton_Click(object sender, EventArgs e)
        {
            if (TypeId == "")
            {
                MessageBox.Show("Такого типу не існує", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Точно бажаєте видалити цей тип?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    query = $"delete from bicycle_types where bicycle_type_id='{TypeId}';";
                    responseNum = DataBaseWorker.ExecuteQueryWithoutResponse(query);
                    if (responseNum == 1)
                    {
                        MessageBox.Show("Тип видалено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TypesTable.Rows.Clear();
                        GetTypesTable();
                        TypeId = "";
                        TypeNameTextBox.Text = "";
                    }
                    else if (responseNum == 0)
                        MessageBox.Show("Тип не видалено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (responseNum == -1)
                        MessageBox.Show("Помилка з базою даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void RemoveProducerButton_Click(object sender, EventArgs e)
        {
            if (ProducerId == "")
            {
                MessageBox.Show("Такого виробника не існує", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Точно бажаєте видалити цього виробника?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    query = $"delete from producers where producer_name_id='{ProducerId}';";
                    responseNum = DataBaseWorker.ExecuteQueryWithoutResponse(query);
                    if (responseNum == 1)
                    {
                        MessageBox.Show("Виробника видалено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ProducersTable.Rows.Clear();
                        GetProducersTable();
                        ProducerId = "";
                        ProducerNameTextBox.Text = "";
                    }
                    else if (responseNum == 0)
                        MessageBox.Show("Виробника не видалено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (responseNum == -1)
                        MessageBox.Show("Помилка з базою даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void RemoveCountryButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Точно бажаєте видалити цю країну?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                query = $"delete from producer_countries where producer_country_id='{CountryId}';";
                responseNum = DataBaseWorker.ExecuteQueryWithoutResponse(query);
                if (responseNum == 1)
                {
                    MessageBox.Show("Країну видалено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CountriesTable.Rows.Clear();
                    GetCountriesTable();
                    CountryId = "";
                    CountryNameTextBox.Text = "";
                }
                else if (responseNum == 0)
                    MessageBox.Show("Країну не видалено!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (responseNum == -1)
                    MessageBox.Show("Помилка з базою даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
