namespace RecipeWinsForms
{
    partial class frmLogin
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
            tblMain = new TableLayoutPanel();
            lblUserId = new Label();
            lblPassword = new Label();
            txtUserId = new TextBox();
            txtPassword = new TextBox();
            btnCancel = new Button();
            btnLogin = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.Controls.Add(txtPassword, 1, 1);
            tblMain.Controls.Add(lblUserId, 0, 0);
            tblMain.Controls.Add(lblPassword, 0, 1);
            tblMain.Controls.Add(txtUserId, 1, 0);
            tblMain.Controls.Add(btnCancel, 2, 2);
            tblMain.Controls.Add(btnLogin, 1, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tblMain.Size = new Size(388, 127);
            tblMain.TabIndex = 0;
            // 
            // lblUserId
            // 
            lblUserId.Anchor = AnchorStyles.Right;
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(18, 7);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(61, 21);
            lblUserId.TabIndex = 0;
            lblUserId.Text = "User ID";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(3, 42);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtUserId
            // 
            txtUserId.Anchor = AnchorStyles.Left;
            tblMain.SetColumnSpan(txtUserId, 2);
            txtUserId.Location = new Point(85, 3);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(291, 29);
            txtUserId.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left;
            tblMain.SetColumnSpan(txtPassword, 2);
            txtPassword.Location = new Point(85, 38);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(291, 29);
            txtPassword.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Right;
            btnCancel.AutoSize = true;
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.Location = new Point(295, 73);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 31);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Right;
            btnLogin.AutoSize = true;
            btnLogin.BackColor = Color.LightGreen;
            btnLogin.Location = new Point(199, 73);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 31);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 127);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmLogin";
            Text = "Hearty Hearth Login";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblUserId;
        private Label lblPassword;
        private TextBox txtUserId;
        private TextBox txtPassword;
        private Button btnCancel;
        private Button btnLogin;
    }
}