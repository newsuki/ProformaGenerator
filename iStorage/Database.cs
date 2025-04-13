using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Data;

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

        public void ExportToExcel(string tableName)
        {
            try
            {
                string query = $"SELECT * FROM {tableName}";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add(dt, tableName);
                        worksheet.Columns().AdjustToContents();

                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.Title = "Save Excel File";
                            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                            saveFileDialog.FileName = $"{tableName}_Export.xlsx";

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                workbook.SaveAs(saveFileDialog.FileName);
                                MessageBox.Show($"Exported to Excel successfully!\n{saveFileDialog.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void CreateProforma(RichTextBox sellerRichTextBox, RichTextBox buyerRichTextBox, ListBox itemsListBox, string expireDate, int invoiceNumber, double total)
        {
            if (sellerRichTextBox == null || buyerRichTextBox == null || itemsListBox.Items == null)
                return;

            string companyName = sellerRichTextBox.Text;
            string buyerName = buyerRichTextBox.Text;

            List<string> itemNames = new List<string>();

            // Step 1: Insert the proforma invoice
            using (SQLiteCommand com = new SQLiteCommand(@"
        INSERT INTO proforma_invoices (
            buyer_name,
            seller_name,
            purchase_time,
            expire_date,
            invoice_number,
            total
        )
        VALUES (
            @buyerName,
            @companyName,
            datetime('now'), 
            @expireDate,
            @invoiceNumber,
            @total
        );", conn))
            {
                com.Parameters.AddWithValue("@companyName", companyName);
                com.Parameters.AddWithValue("@buyerName", buyerName);
                com.Parameters.AddWithValue("@expireDate", expireDate);
                com.Parameters.AddWithValue("@invoiceNumber", invoiceNumber);
                com.Parameters.AddWithValue("@total", total);
                com.ExecuteNonQuery();
            }

            // Step 2: Get the last inserted proforma invoice ID
            long proformaId;
            using (SQLiteCommand getIdCommand = new SQLiteCommand("SELECT last_insert_rowid();", conn))
            {
                proformaId = (long)getIdCommand.ExecuteScalar();
            }

            // Step 3: Insert each item in the proforma
            foreach (var obj in itemsListBox.Items)
            {
                if (obj is InvoiceItem invoiceItem)
                {
                    string name = invoiceItem.ItemName;
                    int qty = invoiceItem.Quantity;
                    double price = invoiceItem.TotalPrice;

                    itemNames.Add(invoiceItem.ToString());

                    using (SQLiteCommand itemCommand = new SQLiteCommand(@"
                INSERT INTO items_proforma_invoices (items_id, proforma_invoices_id, quantity, totalprice)
                VALUES (
                    (SELECT id FROM items WHERE name = @itemname),
                    @proformaId,
                    @quantity,
                    @totalprice
                );", conn))
                    {
                        itemCommand.Parameters.AddWithValue("@itemname", name);
                        itemCommand.Parameters.AddWithValue("@proformaId", proformaId);
                        itemCommand.Parameters.AddWithValue("@quantity", qty);
                        itemCommand.Parameters.AddWithValue("@totalprice", price);
                        itemCommand.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Successfully created proforma invoice!");

            ProformaForm proformaForm = new ProformaForm(companyName, buyerName, itemNames, expireDate, invoiceNumber, total);
            proformaForm.Show();
        }

        public void LoadProformaInvoiceData(ListBox listBoxItems, RichTextBox richTextBoxSeller, RichTextBox richTextBoxBuyer, string invoiceNumber)
        {
            listBoxItems.Items.Clear();
            richTextBoxSeller.Clear();
            richTextBoxBuyer.Clear();

            int invoiceId = -1;

            // 1. Get invoice ID and seller/buyer info
            string getIdQuery = "SELECT id, seller_name, buyer_name FROM proforma_invoices WHERE invoice_number = @invoiceNumber;";
            using (SQLiteCommand cmd = new SQLiteCommand(getIdQuery, conn))
            {
                cmd.Parameters.AddWithValue("@invoiceNumber", invoiceNumber);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        invoiceId = Convert.ToInt32(reader["id"]);
                        richTextBoxSeller.Text = reader["seller_name"].ToString();
                        richTextBoxBuyer.Text = reader["buyer_name"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invoice not found.");
                        return;
                    }
                }
            }

            // 2. Get items from items_proforma_invoices + items
            string queryItems = @"
        SELECT i.name, i.description, ipi.quantity, ipi.totalprice
        FROM items_proforma_invoices ipi
        JOIN items i ON ipi.items_id = i.id
        WHERE ipi.proforma_invoices_id = @invoiceId;";

            using (SQLiteCommand cmd = new SQLiteCommand(queryItems, conn))
            {
                cmd.Parameters.AddWithValue("@invoiceId", invoiceId);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string itemName = reader["name"].ToString();
                        string itemDescription = reader["description"].ToString();
                        int quantity = Convert.ToInt32(reader["quantity"]);
                        double totalPrice = Convert.ToDouble(reader["totalprice"]);

                        InvoiceItem invoiceItem = new InvoiceItem
                        {
                            ItemName = itemName,
                            ItemDescription = itemDescription,
                            Quantity = quantity,
                            TotalPrice = totalPrice
                        };

                        listBoxItems.Items.Add(invoiceItem); // ← use the object, not a string
                    }
                }
            }
        }






        public void DeleteFrom(ListBox listBox, string tableName, string columnName)
        {
            if (listBox.SelectedItem == null)
                return;

            var selectedItem = listBox.SelectedItem;

            if (selectedItem is Item item)
            {
                using (SQLiteCommand com = new SQLiteCommand($"DELETE FROM {tableName} WHERE {columnName} = @value;", conn))
                {
                    com.Parameters.AddWithValue("@value", item.ItemName);
                    com.ExecuteNonQuery();
                }

                listBox.Items.Remove(selectedItem);
            }
            else
            {
                string selectedText = selectedItem.ToString().Split('|')[0].Trim();

                using (SQLiteCommand com = new SQLiteCommand($"DELETE FROM {tableName} WHERE {columnName} = @value;", conn))
                {
                    com.Parameters.AddWithValue("@value", selectedText);
                    com.ExecuteNonQuery();
                }

                listBox.Items.Remove(selectedItem);
            }
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

        public void SaveBuyer(string name, string address, string phone, string cityName)
        {
            using (SQLiteCommand com = new SQLiteCommand("INSERT INTO buyers (name, address, phone, cities_id) VALUES (@name, @address, @phone, (SELECT id FROM cities WHERE name = @cityName));", conn))
            {
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@address", address);
                com.Parameters.AddWithValue("@phone", phone);
                com.Parameters.AddWithValue("@cityName", cityName);
                com.ExecuteNonQuery();
            }
        }

        public void SaveSeller(string name, string address, string phone, string cityName)
        {
            using (SQLiteCommand com = new SQLiteCommand("INSERT INTO companies (name, address, phone, cities_id) VALUES (@name, @address, @phone, (SELECT id FROM cities WHERE name = @cityName));", conn))
            {
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@address", address);
                com.Parameters.AddWithValue("@phone", phone);
                com.Parameters.AddWithValue("@cityName", cityName);
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

        public void SaveItem(string name, double price, string description, string imageName)
        {
            using (SQLiteCommand com = new SQLiteCommand("INSERT INTO items (name, price, description, images_id) VALUES (@name, @price, @description, (SELECT id FROM images WHERE description = @imageName));", conn))
            {
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@price", price + "€");
                com.Parameters.AddWithValue("@description", description);
                com.Parameters.AddWithValue("@imageName", imageName);
                com.ExecuteNonQuery();
            }
        }

        public void SaveItemWithoutImage(string name, double price, string description)
        {
            using (SQLiteCommand com = new SQLiteCommand("INSERT INTO items (name, price, description) VALUES (@name, @price, @description);", conn))
            {
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@price", price + "€");
                com.Parameters.AddWithValue("@description", description);
                com.ExecuteNonQuery();
            }
        }

        public void LoadItemsData(ListBox listBox)
        {
            listBox.Items.Clear();

            string selectQuery = "SELECT name, description, price, images_id FROM items;";
            using (SQLiteCommand com = new SQLiteCommand(selectQuery, conn))
            {
                using (SQLiteDataReader dataReader = com.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        string name = dataReader["name"].ToString();
                        string desc = dataReader["description"].ToString();
                        double price = Convert.ToDouble(dataReader["price"]);
                        int imageId = dataReader["images_id"] != DBNull.Value ? Convert.ToInt32(dataReader["images_id"]) : 0;

                        Item item = new Item
                        {
                            ItemName = name,
                            ImageID = imageId,
                            ItemDescription = desc,
                            Price = price
                        };

                        listBox.Items.Add(item);
                    }
                }
            }
        }

        public void LoadCompaniesData(ListBox listBox)
        {
            listBox.Items.Clear();

            string query = @"
        SELECT companies.name, companies.address, companies.phone, cities.name as city_name
        FROM companies
        JOIN cities ON companies.cities_id = cities.id;
    ";

            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        string address = reader["address"].ToString();
                        string phone = reader["phone"].ToString();
                        string cityName = reader["city_name"].ToString();

                        listBox.Items.Add($"{name} | {address} | {phone} | {cityName}");
                    }
                }
            }
        }

        public void LoadBuyersData(ListBox listBox)
        {
            listBox.Items.Clear();

            string query = @"
        SELECT buyers.name, buyers.address, buyers.phone, cities.name as city_name
        FROM buyers
        JOIN cities ON buyers.cities_id = cities.id;
    ";

            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        string address = reader["address"].ToString();
                        string phone = reader["phone"].ToString();
                        string cityName = reader["city_name"].ToString();

                        listBox.Items.Add($"{name} | {address} | {phone} | {cityName}");
                    }
                }
            }
        }
        public int? GetImageIdByName(string name)
        {
            using (SQLiteCommand com = new SQLiteCommand("SELECT images_id FROM items WHERE name = @name;", conn))
            {
                com.Parameters.AddWithValue("@name", name);
                object result = com.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                    return id;
            }

            return null;
        }

        public string GetImageUrl(int id)
        {
            string url = string.Empty;

            using (SQLiteCommand com = new SQLiteCommand("SELECT url FROM images WHERE id = @id;", conn))
            {
                com.Parameters.AddWithValue("@id", id);
                object result = com.ExecuteScalar(); 

                if (result != null)
                {
                    url = result.ToString(); 
                }
            }

            return url;
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
