using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KP_bicycle_store
{
    static class DataBaseWorker
    {
        public static string connectionString;
        public static string MySQLServerName = "localhost";     // потрібно змінити
        public static string MySQLDataBaseName = "kp_bicycle_store";
        public static string MySQLUserId = "root";              // потрібно змінити
        public static string MySQLPassword = "badyadya2004";    // потрібно змінити
        public static MySqlConnection myConnection;

        public static void OpenConnection ()
        {
            connectionString = $"Database={MySQLDataBaseName};Data Source={MySQLServerName};User Id={MySQLUserId};Password={MySQLPassword}";
            myConnection = new MySqlConnection(connectionString);
            myConnection.Open();
        }

        public static bool IsLogin(string username)
        {
            OpenConnection();
            string query = $"select username from clients where username = '{username}';";
            string response = ExecuteQuery(query);
            CloseConnection();
            if (response != null)
                return true;
            else
                return false;
        }

        public static int ExecuteQueryWithoutResponse(string query)
        {
            OpenConnection();
            MySqlCommand command = new MySqlCommand(query, myConnection);
            try
            {
                return command.ExecuteNonQuery();
            }
            catch(Exception)
            {
                return -1;
            }
        }
        public static string ExecuteQuery (string query)
        {
            OpenConnection();
            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            string response = null;
            while (reader.Read())
                response = reader[0].ToString();
            reader.Close();
            CloseConnection();
            return response;
        }
        public static List<string[]> ExecuteQuery(string query, int col)
        {
            OpenConnection();
            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            var response = new List<string[]>();

            while (reader.Read())
            {
                response.Add(new string[col]);

                for (int i = 0; i < col; i++)
                {
                    response[response.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            CloseConnection();
            if (response.Count != 0)
                return response;
            else
                return null;
        }
        public static void CloseConnection()
        {
            myConnection.Close();
        }
        public static void SetGridStyle (DataGridView GridName)
        {
            GridName.ReadOnly = true;
            GridName.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridName.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            GridName.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GridName.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(110, 110, 110);
            GridName.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 87, 87, 87);
            GridName.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;            GridName.EnableHeadersVisualStyles = false;
            GridName.RowHeadersVisible = false;
            GridName.CellBorderStyle = DataGridViewCellBorderStyle.None;
            GridName.BorderStyle = BorderStyle.None;
            GridName.AllowUserToResizeColumns = false;
            GridName.AllowUserToResizeRows = false;
            foreach (DataGridViewRow row in GridName.Rows)
                row.DefaultCellStyle.BackColor = Color.DarkGray;
        }
    }
}
