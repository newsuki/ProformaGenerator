using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace iStorage
{
    public class Database
    {
        private string path = "data source=proformainvoice.db";
        private SQLiteConnection conn;

        public Database()
        {
            conn = new SQLiteConnection(path);

            conn.Open();
        }

        public void DeleteFrom(ListBox listBox, string tableName, string columnName)
        {
            if (listBox.SelectedItem == null)
                return;

            string selectedText = listBox.SelectedItem.ToString();
            string firstColumnValue = selectedText.Split('|')[0].Trim();

            using (SQLiteCommand com = new SQLiteCommand($"DELETE FROM {tableName} WHERE {columnName} = @value;", conn))
            {
                com.Parameters.AddWithValue("@value", firstColumnValue);
                com.ExecuteNonQuery();
            }

            listBox.Items.Remove(selectedText);
        }

        public void LoadData(ListBox listBox, string tableName)
        {
            listBox.Items.Clear();

            string query = $"PRAGMA table_info({tableName});";
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    List<string> columnNames = new List<string>();
                    while (reader.Read())
                    {
                        string columnName = reader["name"].ToString();
                        if (columnName != "id") 
                        {
                            columnNames.Add(columnName);
                        }
                    }

                    string selectColumns = string.Join(", ", columnNames);
                    string selectQuery = $"SELECT {selectColumns} FROM {tableName};";

                    using (SQLiteCommand com = new SQLiteCommand(selectQuery, conn))
                    {
                        using (SQLiteDataReader dataReader = com.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                List<string> rowValues = new List<string>();

                                for (int i = 0; i < dataReader.FieldCount; i++)
                                {
                                    rowValues.Add(dataReader[i].ToString());
                                }

                                listBox.Items.Add(string.Join(" | ", rowValues));
                            }
                        }
                    }
                }
            }
        }

        public void LoadDataIntoComboBox(string tableName, string columnName, ComboBox comboBox)
        {
            string query = $"SELECT {columnName} FROM {tableName}";

            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    comboBox.Items.Clear();

                    while (reader.Read())
                    {
                        string item = reader[columnName].ToString();
                        comboBox.Items.Add(item);
                    }
                }
            }
        }

        public void SaveCountry(string countryName, string countryCode)
        {
            using (SQLiteCommand com = new SQLiteCommand("INSERT INTO countries (name, country_code) VALUES (@name, @code);", conn))
            {
                com.Parameters.AddWithValue("@name", countryName);
                com.Parameters.AddWithValue("@code", countryCode);
                com.ExecuteNonQuery();
            }
        }

        public void SaveCity(string cityName, string postalNumber, string countryName)
        {
            using (SQLiteCommand com = new SQLiteCommand("INSERT INTO cities (name, postal_number, countries_id) VALUES (@name, @postal, (SELECT id FROM countries WHERE name = @countryName));", conn))
            {
                com.Parameters.AddWithValue("@name", cityName); 
                com.Parameters.AddWithValue("@postal", postalNumber);
                com.Parameters.AddWithValue("@countryName", countryName); 
                com.ExecuteNonQuery();
            }
        }

        public void SaveImage(string imageUrl, string description)
        {
            using (SQLiteCommand com = new SQLiteCommand("INSERT INTO images (url, description) VALUES (@link, @desc);", conn))
            {
                com.Parameters.AddWithValue("@link", imageUrl);
                com.Parameters.AddWithValue("@desc", description);
                com.ExecuteNonQuery();
            }
        }

        public void Close()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void Open()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
    }
}
