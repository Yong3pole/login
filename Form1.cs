
using MySql.Data.MySqlClient;

namespace login
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        string connectionString = "Server=localhost;Database=vblogin;User ID=root;Password=;";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Fetch user data instead of just checking the count
                    string query = "SELECT user_id, username, first_name, role FROM user WHERE username = @username AND password = @password";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = Convert.ToInt32(reader["user_id"]);
                                string loggedInUsername = reader["username"].ToString();
                                string first_name = reader["first_name"].ToString();
                                string role = reader["role"].ToString();

                                MessageBox.Show("Login successful!");

                                // Pass userId and username to the Dashboard
                                Dashboard dashboard = new Dashboard(userId, loggedInUsername, first_name, role);
                                this.Hide();
                                dashboard.FormClosed += (s, args) => Application.Exit();
                                dashboard.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
