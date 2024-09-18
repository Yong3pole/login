namespace login
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            label2 = new Label();
            dashboarddate = new Label();
            logout = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttondashboard = new Button();
            buttonusers = new Button();
            buttonstock = new Button();
            buttonsales = new Button();
            buttonarchive = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridViewProducts = new DataGridView();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            nameUser = new Label();
            roleUser = new Label();
            search_product = new TextBox();
            btnDash_Users = new Button();
            btnDash_expiry = new Button();
            btnDash_restock = new Button();
            btnDash_sales = new Button();
            welcome_dash = new Label();
            quickaccess_labelusers = new Label();
            quickaccess_labelexp = new Label();
            quickaccess_labelrestock = new Label();
            quickaccess_labelsales = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dashboarddate);
            panel1.Controls.Add(logout);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 729);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 677);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 4;
            label2.Text = "© 2024 MediSync";
            // 
            // dashboarddate
            // 
            dashboarddate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dashboarddate.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dashboarddate.Location = new Point(100, 692);
            dashboarddate.Name = "dashboarddate";
            dashboarddate.Size = new Size(119, 21);
            dashboarddate.TabIndex = 3;
            dashboarddate.Text = "date";
            dashboarddate.TextAlign = ContentAlignment.MiddleRight;
            dashboarddate.UseMnemonic = false;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logout.Cursor = Cursors.Hand;
            logout.Image = (Image)resources.GetObject("logout.Image");
            logout.Location = new Point(21, 669);
            logout.Name = "logout";
            logout.Size = new Size(40, 44);
            logout.SizeMode = PictureBoxSizeMode.StretchImage;
            logout.TabIndex = 2;
            logout.TabStop = false;
            logout.Click += logout_Click_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttondashboard);
            flowLayoutPanel1.Controls.Add(buttonusers);
            flowLayoutPanel1.Controls.Add(buttonstock);
            flowLayoutPanel1.Controls.Add(buttonsales);
            flowLayoutPanel1.Controls.Add(buttonarchive);
            flowLayoutPanel1.Location = new Point(19, 215);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 273);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // buttondashboard
            // 
            buttondashboard.BackColor = Color.Ivory;
            buttondashboard.Cursor = Cursors.Hand;
            buttondashboard.FlatStyle = FlatStyle.Popup;
            buttondashboard.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttondashboard.ForeColor = SystemColors.ActiveCaptionText;
            buttondashboard.Location = new Point(3, 3);
            buttondashboard.Name = "buttondashboard";
            buttondashboard.Size = new Size(197, 43);
            buttondashboard.TabIndex = 3;
            buttondashboard.Text = "DASHBOARD";
            buttondashboard.UseVisualStyleBackColor = false;
            buttondashboard.Click += buttondashboard_Click;
            // 
            // buttonusers
            // 
            buttonusers.BackColor = Color.Ivory;
            buttonusers.Cursor = Cursors.Hand;
            buttonusers.FlatStyle = FlatStyle.Popup;
            buttonusers.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonusers.ForeColor = SystemColors.ActiveCaptionText;
            buttonusers.Location = new Point(3, 52);
            buttonusers.Name = "buttonusers";
            buttonusers.Size = new Size(197, 43);
            buttonusers.TabIndex = 4;
            buttonusers.Text = "MANAGE USERS";
            buttonusers.UseVisualStyleBackColor = false;
            buttonusers.Click += accountBtn_Click;
            // 
            // buttonstock
            // 
            buttonstock.BackColor = Color.Ivory;
            buttonstock.Cursor = Cursors.Hand;
            buttonstock.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            buttonstock.FlatStyle = FlatStyle.Popup;
            buttonstock.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonstock.ForeColor = SystemColors.ActiveCaptionText;
            buttonstock.Location = new Point(3, 101);
            buttonstock.Name = "buttonstock";
            buttonstock.Size = new Size(197, 43);
            buttonstock.TabIndex = 5;
            buttonstock.Text = "STOCK MONITOR";
            buttonstock.UseVisualStyleBackColor = false;
            buttonstock.Click += button3_Click;
            // 
            // buttonsales
            // 
            buttonsales.BackColor = Color.Ivory;
            buttonsales.Cursor = Cursors.Hand;
            buttonsales.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            buttonsales.FlatStyle = FlatStyle.Popup;
            buttonsales.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonsales.ForeColor = SystemColors.ActiveCaptionText;
            buttonsales.Location = new Point(3, 150);
            buttonsales.Name = "buttonsales";
            buttonsales.Size = new Size(197, 43);
            buttonsales.TabIndex = 6;
            buttonsales.Text = "SALES";
            buttonsales.UseVisualStyleBackColor = false;
            // 
            // buttonarchive
            // 
            buttonarchive.BackColor = Color.Ivory;
            buttonarchive.Cursor = Cursors.Hand;
            buttonarchive.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            buttonarchive.FlatStyle = FlatStyle.Popup;
            buttonarchive.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonarchive.ForeColor = SystemColors.ActiveCaptionText;
            buttonarchive.Location = new Point(3, 199);
            buttonarchive.Name = "buttonarchive";
            buttonarchive.Size = new Size(197, 43);
            buttonarchive.TabIndex = 7;
            buttonarchive.Text = "ARCHIVE";
            buttonarchive.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(241, 100);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(89, 22);
            label1.Name = "label1";
            label1.Size = new Size(141, 57);
            label1.TabIndex = 4;
            label1.Text = "MEDICINE\r\nMONITORING \r\nSYSTEM\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(280, 137);
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewProducts.Size = new Size(1029, 544);
            dataGridViewProducts.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.CadetBlue;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(nameUser);
            panel3.Controls.Add(roleUser);
            panel3.Location = new Point(231, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1121, 85);
            panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1066, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // nameUser
            // 
            nameUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nameUser.AutoEllipsis = true;
            nameUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameUser.Location = new Point(856, 22);
            nameUser.Name = "nameUser";
            nameUser.RightToLeft = RightToLeft.No;
            nameUser.Size = new Size(208, 30);
            nameUser.TabIndex = 1;
            nameUser.Text = "nameUser";
            nameUser.TextAlign = ContentAlignment.MiddleRight;
            nameUser.Click += label2_Click;
            // 
            // roleUser
            // 
            roleUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roleUser.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            roleUser.Location = new Point(925, 46);
            roleUser.Name = "roleUser";
            roleUser.Size = new Size(134, 20);
            roleUser.TabIndex = 2;
            roleUser.Text = "roleUser";
            roleUser.TextAlign = ContentAlignment.MiddleRight;
            roleUser.Click += roleUser_Click;
            // 
            // search_product
            // 
            search_product.Cursor = Cursors.IBeam;
            search_product.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_product.Location = new Point(280, 96);
            search_product.Name = "search_product";
            search_product.PlaceholderText = "Search Product...";
            search_product.Size = new Size(242, 29);
            search_product.TabIndex = 3;
            search_product.Visible = false;
            search_product.KeyPress += search_product_KeyPress;
            // 
            // btnDash_Users
            // 
            btnDash_Users.BackgroundImage = (Image)resources.GetObject("btnDash_Users.BackgroundImage");
            btnDash_Users.BackgroundImageLayout = ImageLayout.Zoom;
            btnDash_Users.Cursor = Cursors.Hand;
            btnDash_Users.FlatAppearance.BorderColor = Color.Lime;
            btnDash_Users.FlatAppearance.BorderSize = 20;
            btnDash_Users.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            btnDash_Users.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnDash_Users.Location = new Point(401, 273);
            btnDash_Users.Name = "btnDash_Users";
            btnDash_Users.Size = new Size(173, 159);
            btnDash_Users.TabIndex = 5;
            btnDash_Users.TextImageRelation = TextImageRelation.TextAboveImage;
            btnDash_Users.UseVisualStyleBackColor = true;
            btnDash_Users.Click += btnDash_Users_Click;
            // 
            // btnDash_expiry
            // 
            btnDash_expiry.BackgroundImage = (Image)resources.GetObject("btnDash_expiry.BackgroundImage");
            btnDash_expiry.BackgroundImageLayout = ImageLayout.Zoom;
            btnDash_expiry.Cursor = Cursors.Hand;
            btnDash_expiry.Location = new Point(613, 273);
            btnDash_expiry.Name = "btnDash_expiry";
            btnDash_expiry.Size = new Size(173, 159);
            btnDash_expiry.TabIndex = 6;
            btnDash_expiry.UseVisualStyleBackColor = true;
            btnDash_expiry.Click += btnDash_expiry_Click;
            // 
            // btnDash_restock
            // 
            btnDash_restock.BackgroundImage = (Image)resources.GetObject("btnDash_restock.BackgroundImage");
            btnDash_restock.BackgroundImageLayout = ImageLayout.Zoom;
            btnDash_restock.Cursor = Cursors.Hand;
            btnDash_restock.Location = new Point(825, 273);
            btnDash_restock.Name = "btnDash_restock";
            btnDash_restock.Size = new Size(173, 159);
            btnDash_restock.TabIndex = 7;
            btnDash_restock.UseVisualStyleBackColor = true;
            btnDash_restock.Click += btnDash_restock_Click;
            // 
            // btnDash_sales
            // 
            btnDash_sales.BackgroundImage = (Image)resources.GetObject("btnDash_sales.BackgroundImage");
            btnDash_sales.BackgroundImageLayout = ImageLayout.Zoom;
            btnDash_sales.Cursor = Cursors.Hand;
            btnDash_sales.Location = new Point(1037, 273);
            btnDash_sales.Name = "btnDash_sales";
            btnDash_sales.Size = new Size(173, 159);
            btnDash_sales.TabIndex = 8;
            btnDash_sales.UseVisualStyleBackColor = true;
            btnDash_sales.Click += btnDash_sales_Click;
            // 
            // welcome_dash
            // 
            welcome_dash.AutoSize = true;
            welcome_dash.Font = new Font("Candara", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            welcome_dash.ForeColor = Color.Black;
            welcome_dash.Location = new Point(638, 167);
            welcome_dash.Name = "welcome_dash";
            welcome_dash.Size = new Size(341, 42);
            welcome_dash.TabIndex = 9;
            welcome_dash.Text = "Welcome to MediSync";
            // 
            // quickaccess_labelusers
            // 
            quickaccess_labelusers.AutoSize = true;
            quickaccess_labelusers.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quickaccess_labelusers.ForeColor = Color.FromArgb(255, 128, 0);
            quickaccess_labelusers.Location = new Point(453, 447);
            quickaccess_labelusers.Name = "quickaccess_labelusers";
            quickaccess_labelusers.Size = new Size(70, 33);
            quickaccess_labelusers.TabIndex = 10;
            quickaccess_labelusers.Text = "USERS";
            // 
            // quickaccess_labelexp
            // 
            quickaccess_labelexp.AutoSize = true;
            quickaccess_labelexp.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quickaccess_labelexp.ForeColor = Color.FromArgb(255, 128, 0);
            quickaccess_labelexp.Location = new Point(638, 447);
            quickaccess_labelexp.Name = "quickaccess_labelexp";
            quickaccess_labelexp.Size = new Size(125, 33);
            quickaccess_labelexp.TabIndex = 11;
            quickaccess_labelexp.Text = "NEAR EXPIRY";
            // 
            // quickaccess_labelrestock
            // 
            quickaccess_labelrestock.AutoSize = true;
            quickaccess_labelrestock.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quickaccess_labelrestock.ForeColor = Color.FromArgb(255, 128, 0);
            quickaccess_labelrestock.Location = new Point(865, 447);
            quickaccess_labelrestock.Name = "quickaccess_labelrestock";
            quickaccess_labelrestock.Size = new Size(92, 33);
            quickaccess_labelrestock.TabIndex = 12;
            quickaccess_labelrestock.Text = "RESTOCK";
            // 
            // quickaccess_labelsales
            // 
            quickaccess_labelsales.AutoSize = true;
            quickaccess_labelsales.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quickaccess_labelsales.ForeColor = Color.FromArgb(255, 128, 0);
            quickaccess_labelsales.Location = new Point(1089, 447);
            quickaccess_labelsales.Name = "quickaccess_labelsales";
            quickaccess_labelsales.Size = new Size(71, 33);
            quickaccess_labelsales.TabIndex = 13;
            quickaccess_labelsales.Text = "SALES";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 729);
            Controls.Add(quickaccess_labelsales);
            Controls.Add(quickaccess_labelrestock);
            Controls.Add(quickaccess_labelexp);
            Controls.Add(quickaccess_labelusers);
            Controls.Add(welcome_dash);
            Controls.Add(btnDash_sales);
            Controls.Add(btnDash_restock);
            Controls.Add(btnDash_expiry);
            Controls.Add(btnDash_Users);
            Controls.Add(search_product);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(dataGridViewProducts);
            Name = "Dashboard";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logout).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttondashboard;
        private Button buttonusers;
        private Button buttonstock;
        private DataGridView dataGridViewProducts;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label roleUser;
        private Label nameUser;
        private PictureBox logout;
        private Label dashboarddate;
        private Label label2;
        private Button buttonsales;
        private TextBox search_product;
        private Button btnDash_Users;
        private Button btnDash_expiry;
        private Button btnDash_restock;
        private Button btnDash_sales;
        private Label welcome_dash;
        private Label quickaccess_labelusers;
        private Label quickaccess_labelexp;
        private Label quickaccess_labelrestock;
        private Label quickaccess_labelsales;
        private Button buttonarchive;
    }
}