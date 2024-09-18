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
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridViewProducts = new DataGridView();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            nameUser = new Label();
            roleUser = new Label();
            search_product = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            welcome_dash = new Label();
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
            panel1.Size = new Size(241, 681);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 629);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 4;
            label2.Text = "© 2024 MediSync";
            // 
            // dashboarddate
            // 
            dashboarddate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dashboarddate.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dashboarddate.Location = new Point(100, 644);
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
            logout.Location = new Point(21, 621);
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
            flowLayoutPanel1.Location = new Point(19, 215);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 216);
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
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AllowUserToResizeColumns = false;
            dataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(280, 137);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(943, 496);
            dataGridViewProducts.StandardTab = true;
            dataGridViewProducts.TabIndex = 3;
            dataGridViewProducts.Visible = false;
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
            panel3.Size = new Size(1035, 85);
            panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(980, 27);
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
            nameUser.Location = new Point(770, 22);
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
            roleUser.Location = new Point(839, 46);
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
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Lime;
            button1.FlatAppearance.BorderSize = 20;
            button1.Location = new Point(331, 237);
            button1.Name = "button1";
            button1.Size = new Size(173, 159);
            button1.TabIndex = 5;
            button1.Text = "Users";
            button1.TextImageRelation = TextImageRelation.TextAboveImage;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(543, 237);
            button2.Name = "button2";
            button2.Size = new Size(173, 159);
            button2.TabIndex = 6;
            button2.Text = "Near Expiry";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(755, 237);
            button3.Name = "button3";
            button3.Size = new Size(173, 159);
            button3.TabIndex = 7;
            button3.Text = "Restock";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(967, 237);
            button4.Name = "button4";
            button4.Size = new Size(173, 159);
            button4.TabIndex = 8;
            button4.Text = "Sales";
            button4.UseVisualStyleBackColor = true;
            // 
            // welcome_dash
            // 
            welcome_dash.AutoSize = true;
            welcome_dash.Font = new Font("Candara", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            welcome_dash.Location = new Point(564, 166);
            welcome_dash.Name = "welcome_dash";
            welcome_dash.Size = new Size(341, 42);
            welcome_dash.TabIndex = 9;
            welcome_dash.Text = "Welcome to MediSync";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(welcome_dash);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(search_product);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(dataGridViewProducts);
            Name = "Dashboard";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label welcome_dash;
    }
}