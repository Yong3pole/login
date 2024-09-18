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
                    // Updated query to join medicine and inventory tables and select additional quantity field
                    string query = @"
                SELECT 
                    m.med_id AS 'Product ID',
                    m.med_name AS 'Product Name',
                    m.med_brand AS 'Brand',
                    m.med_manufacturer AS 'Manufacturer',
                    m.med_category AS 'Category',
                    m.med_form AS 'Form',
                    m.med_dosage AS 'Dosage',
                    m.med_price AS 'Price',
                    i.quantity AS 'Stock Quantity'
                FROM 
                    medicine m
                JOIN 
                    inventory i
                ON 
                    m.med_id = i.med_id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable productTable = new DataTable();
                        adapter.Fill(productTable);

                        // Bind the DataGridView to the DataTable to show the products
                        dataGridViewProducts.DataSource = productTable;

                        // Make the header text bold for specific columns
                        foreach (DataGridViewColumn column in dataGridViewProducts.Columns)
                        {
                            column.HeaderCell.Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        }

                        // Optionally, you can also change header text
                        dataGridViewProducts.Columns["Product ID"].HeaderText = "Product ID";
                        dataGridViewProducts.Columns["Product Name"].HeaderText = "Product Name";
                        dataGridViewProducts.Columns["Brand"].HeaderText = "Brand";
                        dataGridViewProducts.Columns["Manufacturer"].HeaderText = "Manufacturer";
                        dataGridViewProducts.Columns["Category"].HeaderText = "Category";
                        dataGridViewProducts.Columns["Form"].HeaderText = "Form";
                        dataGridViewProducts.Columns["Dosage"].HeaderText = "Dosage";
                        dataGridViewProducts.Columns["Price"].HeaderText = "Price";
                        dataGridViewProducts.Columns["Stock Quantity"].HeaderText = "Stock Quantity";
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
            welcome_dash.Visible = false;
            btnDash_Users.Visible = false;
            btnDash_expiry.Visible = false;
            btnDash_restock.Visible = false;
            btnDash_sales.Visible = false;

            quickaccess_labelusers.Visible = false;
            quickaccess_labelexp.Visible = false;
            quickaccess_labelrestock.Visible = false;
            quickaccess_labelsales.Visible = false;
            // Make them visible when the button is clicked
            dataGridViewProducts.Visible = true;
            search_product.Visible = true;

            LoadProducts();  // Load products when button3 is clicked
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            EditAccountForm editAccountForm = new EditAccountForm();
            editAccountForm.ShowDialog();
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
            welcome_dash.Visible = true;
            // show dash buttons
            btnDash_Users.Visible = true; btnDash_expiry.Visible = true; btnDash_restock.Visible = true; btnDash_sales.Visible = true;
            quickaccess_labelusers.Visible = true;
            quickaccess_labelexp.Visible = true;
            quickaccess_labelrestock.Visible = true;
            quickaccess_labelsales.Visible = true;
            // Hide them when button1 is clicked
            dataGridViewProducts.Visible = false;
            search_product.Visible = false;
        }

        private void btnDash_Users_Click(object sender, EventArgs e)
        {
            EditAccountForm editAccountForm = new EditAccountForm();
            editAccountForm.ShowDialog();
        }

        private void btnDash_expiry_Click(object sender, EventArgs e)
        {
            ExpiryMonitor expiryMonitor = new ExpiryMonitor();
            expiryMonitor.ShowDialog();
        }

        private void btnDash_restock_Click(object sender, EventArgs e)
        {

        }

        private void btnDash_sales_Click(object sender, EventArgs e)
        {

        }
    }
}
