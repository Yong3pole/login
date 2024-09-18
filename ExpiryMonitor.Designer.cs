namespace login
{
    partial class ExpiryMonitor
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
            med_expiry_grid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)med_expiry_grid).BeginInit();
            SuspendLayout();
            // 
            // med_expiry_grid
            // 
            med_expiry_grid.AllowUserToDeleteRows = false;
            med_expiry_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            med_expiry_grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            med_expiry_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            med_expiry_grid.Location = new Point(83, 156);
            med_expiry_grid.Name = "med_expiry_grid";
            med_expiry_grid.Size = new Size(995, 405);
            med_expiry_grid.TabIndex = 0;
            // 
            // ExpiryMonitor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(med_expiry_grid);
            Name = "ExpiryMonitor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monitor Expiry";
            ((System.ComponentModel.ISupportInitialize)med_expiry_grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView med_expiry_grid;
    }
}