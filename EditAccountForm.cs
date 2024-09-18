using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace login
{


    public partial class EditAccountForm : Form
    {
        private int userId;
        string connectionString = "Server=localhost;Database=vblogin;User ID=root;Password=;";

        public EditAccountForm()
        {
            InitializeComponent();           

            // Call LoadUsers method to populate the DataGridView
            LoadUsers();
        }

        void LoadUsers()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Updated query to combine 'first_name' and 'last_name' into 'Full Name'
                    string query = @"
                SELECT 
                    user_id AS 'User ID',
                    CONCAT(first_name, ' ', last_name) AS 'Full Name',
                    birthday AS 'Birthday',
                    phone AS 'Phone',
                    email AS 'Email',
                    username AS 'Username',
                    role AS 'Role',
                    status AS 'Status'
                FROM 
                    `user`";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable userTable = new DataTable();
                        adapter.Fill(userTable);

                        // Bind the DataGridView to the DataTable to show the users
                        dataGridViewUsers.DataSource = userTable;

                        // Set the font size for data cells
                        dataGridViewUsers.DefaultCellStyle.Font = new Font("Segoe UI", 11);

                        // Make the header text bold
                        foreach (DataGridViewColumn column in dataGridViewUsers.Columns)
                        {
                            column.HeaderCell.Style.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                        }

                        // Adjust column widths to fit the content
                        dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }




        private void EditAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }
    }
}
