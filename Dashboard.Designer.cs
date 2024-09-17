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
            button1 = new Button();
            accountBtn = new Button();
            button3 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridViewProducts = new DataGridView();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            nameUser = new Label();
            roleUser = new Label();
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dashboarddate);
            panel1.Controls.Add(logout);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 668);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 618);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 4;
            label2.Text = "© 2024 MediSync";
            // 
            // dashboarddate
            // 
            dashboarddate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dashboarddate.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dashboarddate.Location = new Point(98, 633);
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
            logout.Location = new Point(19, 610);
            logout.Name = "logout";
            logout.Size = new Size(40, 44);
            logout.SizeMode = PictureBoxSizeMode.StretchImage;
            logout.TabIndex = 2;
            logout.TabStop = false;
            logout.Click += logout_Click_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(accountBtn);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Location = new Point(19, 123);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 354);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(197, 43);
            button1.TabIndex = 3;
            button1.Text = "DASHBOARD";
            button1.UseVisualStyleBackColor = false;
            // 
            // accountBtn
            // 
            accountBtn.BackColor = Color.Ivory;
            accountBtn.Cursor = Cursors.Hand;
            accountBtn.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountBtn.ForeColor = SystemColors.ActiveCaptionText;
            accountBtn.Location = new Point(3, 52);
            accountBtn.Name = "accountBtn";
            accountBtn.Size = new Size(197, 43);
            accountBtn.TabIndex = 4;
            accountBtn.Text = "ACCOUNT";
            accountBtn.UseVisualStyleBackColor = false;
            accountBtn.Click += accountBtn_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Ivory;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(3, 101);
            button3.Name = "button3";
            button3.Size = new Size(197, 43);
            button3.TabIndex = 5;
            button3.Text = "STOCK LEVEL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Ivory;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(3, 150);
            button4.Name = "button4";
            button4.Size = new Size(197, 43);
            button4.TabIndex = 6;
            button4.Text = "MED. MONITORING";
            button4.UseVisualStyleBackColor = false;
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
            label1.Font = new Font("Lucida Console", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(106, 25);
            label1.Name = "label1";
            label1.Size = new Size(117, 45);
            label1.TabIndex = 4;
            label1.Text = "MEDICINE\r\nMONITORING \r\nSYSTEM\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.BorderStyle = BorderStyle.None;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(321, 123);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(917, 510);
            dataGridViewProducts.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.CadetBlue;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(nameUser);
            panel3.Controls.Add(roleUser);
            panel3.Location = new Point(231, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1094, 85);
            panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1041, 27);
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
            nameUser.Location = new Point(831, 22);
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
            roleUser.Location = new Point(900, 46);
            roleUser.Name = "roleUser";
            roleUser.Size = new Size(134, 20);
            roleUser.TabIndex = 2;
            roleUser.Text = "roleUser";
            roleUser.TextAlign = ContentAlignment.MiddleRight;
            roleUser.Click += roleUser_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1323, 668);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(dataGridViewProducts);
            Name = "Dashboard";
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
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button accountBtn;
        private Button button3;
        private Button button4;
        private DataGridView dataGridViewProducts;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label roleUser;
        private Label nameUser;
        private PictureBox logout;
        private Label dashboarddate;
        private Label label2;
    }
}