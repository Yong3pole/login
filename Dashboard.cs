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
    public partial class Dashboard : Form
    {
        private int userId;
        private string username;
        private string first_name;

        public Dashboard(int userId, string username, string first_name, string role)
        {
            InitializeComponent();
            this.userId = userId;
            this.username = username;

            nameUser.Text = first_name.ToUpper();  // Convert the first name to uppercase
            roleUser.Text = role.ToUpper();
            dashboarddate.Text = DateTime.Now.ToString("MMM dd, yyyy");

            // Now you can use userId and username throughout this form
            // Display the username on the dashboard, for example
        }

        string connectionString = "Server=localhost;Database=vblogin;User ID=root;Password=;";

        void LoadProducts()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ID, name, stock, price FROM medicine";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable productTable = new DataTable();
                        adapter.Fill(productTable);

                        // Bind the DataGridView to the DataTable to show the products
                        dataGridViewProducts.DataSource = productTable;

                        // Make the header text bold for specific columns
                        dataGridViewProducts.Columns[0].HeaderCell.Style.Font = new Font("Segoe UI", 15, FontStyle.Bold); // First column
                        dataGridViewProducts.Columns[1].HeaderCell.Style.Font = new Font("Segoe UI", 15, FontStyle.Bold); // Second column
                        dataGridViewProducts.Columns[2].HeaderCell.Style.Font = new Font("Segoe UI", 15, FontStyle.Bold); // Third column
                        dataGridViewProducts.Columns[3].HeaderCell.Style.Font = new Font("Segoe UI", 15, FontStyle.Bold); // Fourth column

                        // Optionally, you can also change header text
                        dataGridViewProducts.Columns[0].HeaderText = "Product ID";
                        dataGridViewProducts.Columns[1].HeaderText = "Product Name";
                        dataGridViewProducts.Columns[2].HeaderText = "Stock Quantity";
                        dataGridViewProducts.Columns[3].HeaderText = "Price";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;

            // Make them visible when the button is clicked
            dataGridViewProducts.Visible = true;
            search_product.Visible = true;

            LoadProducts();  // Load products when button3 is clicked
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            EditAccountForm editAccountForm = new EditAccountForm(userId);
            editAccountForm.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void roleUser_Click(object sender, EventArgs e)
        {

        }


        private void logout_Click_1(object sender, EventArgs e)
        {
            // Instantiate the login form
            loginForm login = new loginForm();

            // Hide the current dashboard form
            this.Hide();

            // Show the login form
            login.FormClosed += (s, args) => this.Close(); // Ensure the application closes when login form is closed
            login.Show();
        }

        private void search_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

            }
        }

        private void buttondashboard_Click(object sender, EventArgs e)
        {
            // show dash buttons
            button1.Visible = true; button2.Visible = true; button3.Visible = true; button4.Visible = true; button5.Visible = true;

            // Hide them when button1 is clicked
            dataGridViewProducts.Visible = false;
            search_product.Visible = false;
        }
    }
}
