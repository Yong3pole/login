using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace login
{
    public partial class EditAccountForm : Form
    {
        private int userId;

        public EditAccountForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void EditAccountForm_Load(object sender, EventArgs e)
        {

        }
    }
}
