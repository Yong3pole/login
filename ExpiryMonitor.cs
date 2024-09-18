using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class ExpiryMonitor : Form
    {
        private string connectionString = "Server=localhost;Database=vblogin;User ID=root;Password=;";

        public ExpiryMonitor()
        {
            InitializeComponent();
            // Load data when the form initializes
            LoadBatchData();
        }

        private void LoadBatchData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // SQL query to join 'batch' and 'medicine' tables and fetch required data
                    string query = @"
                        SELECT 
                            m.med_name AS 'Medicine Name',
                            m.med_brand AS 'Brand',
                            b.batch_number AS 'Batch Number',
                            b.manufacture_date AS 'Manufacture Date',
                            b.expiry_date AS 'Expiry Date',
                            b.batch_quantity AS 'Total Quantity',
                            b.batch_left AS 'Quantity Left',
                            b.batch_status AS 'Status',
                            b.check_date AS 'Check Date'
                        FROM 
                            batch b
                        INNER JOIN 
                            medicine m 
                        ON 
                            b.med_id = m.med_id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable batchTable = new DataTable();
                        adapter.Fill(batchTable);

                        // Bind the DataGridView to the DataTable
                        med_expiry_grid.DataSource = batchTable;

                        // Optionally, format columns
                        foreach (DataGridViewColumn column in med_expiry_grid.Columns)
                        {
                            column.HeaderCell.Style.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
