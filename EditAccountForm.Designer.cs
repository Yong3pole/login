namespace login
{
    partial class EditAccountForm
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
            passwordtxt = new TextBox();
            SuspendLayout();
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(339, 196);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(100, 23);
            passwordtxt.TabIndex = 0;
            // 
            // EditAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passwordtxt);
            Name = "EditAccountForm";
            Text = "Account";
            Load += EditAccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordtxt;
    }
}