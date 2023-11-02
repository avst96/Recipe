namespace RecipeWinsForms
{
    partial class frmSingleCookbook
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
            btnSave = new Button();
            btnDelete = new Button();
            lblName = new Label();
            lblUser = new Label();
            lblPrice = new Label();
            lblActive = new Label();
            lblDate = new Label();
            txtBookName = new TextBox();
            lstUserName = new ComboBox();
            txtPrice = new TextBox();
            txtDateCreated = new TextBox();
            chkActive = new CheckBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tblMain.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMain.Controls.Add(btnDelete, 1, 0);
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(lblName, 0, 1);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lblPrice, 0, 4);
            tblMain.Controls.Add(lblActive, 0, 5);
            tblMain.Controls.Add(lblDate, 2, 3);
            tblMain.Controls.Add(txtBookName, 1, 1);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(txtPrice, 1, 4);
            tblMain.Controls.Add(txtDateCreated, 2, 4);
            tblMain.Controls.Add(chkActive, 1, 5);
            tblMain.Controls.Add(groupBox1, 0, 6);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.Size = new Size(522, 493);
            tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Location = new Point(20, 10);
            btnSave.Margin = new Padding(20, 10, 10, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 31);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Left;
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(177, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 31);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 63);
            lblName.Margin = new Padding(20, 10, 10, 10);
            lblName.Name = "lblName";
            lblName.Size = new Size(127, 21);
            lblName.TabIndex = 2;
            lblName.Text = "Cookbook Name";
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(20, 121);
            lblUser.Margin = new Padding(20, 10, 10, 10);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(42, 21);
            lblUser.TabIndex = 3;
            lblUser.Text = "User";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(20, 221);
            lblPrice.Margin = new Padding(20, 10, 10, 10);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 21);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // lblActive
            // 
            lblActive.Anchor = AnchorStyles.Left;
            lblActive.AutoSize = true;
            lblActive.Location = new Point(20, 264);
            lblActive.Margin = new Padding(20, 10, 10, 10);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(52, 21);
            lblActive.TabIndex = 5;
            lblActive.Text = "Active";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Bottom;
            lblDate.AutoSize = true;
            lblDate.Location = new Point(390, 178);
            lblDate.Margin = new Padding(20, 10, 10, 10);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 21);
            lblDate.TabIndex = 6;
            lblDate.Text = "Date created:";
            lblDate.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtBookName
            // 
            txtBookName.Anchor = AnchorStyles.Left;
            tblMain.SetColumnSpan(txtBookName, 2);
            txtBookName.Location = new Point(177, 59);
            txtBookName.Margin = new Padding(3, 8, 3, 8);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(310, 29);
            txtBookName.TabIndex = 7;
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Left;
            tblMain.SetColumnSpan(lstUserName, 2);
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(177, 107);
            lstUserName.Margin = new Padding(3, 11, 3, 32);
            lstUserName.MaxDropDownItems = 20;
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(310, 29);
            lstUserName.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Left;
            txtPrice.Location = new Point(177, 217);
            txtPrice.Margin = new Padding(3, 8, 3, 8);
            txtPrice.MaxLength = 11;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 29);
            txtPrice.TabIndex = 9;
            // 
            // txtDateCreated
            // 
            txtDateCreated.Anchor = AnchorStyles.Top;
            txtDateCreated.BackColor = SystemColors.ActiveBorder;
            txtDateCreated.Location = new Point(375, 217);
            txtDateCreated.Margin = new Padding(3, 8, 3, 8);
            txtDateCreated.MaxLength = 11;
            txtDateCreated.Name = "txtDateCreated";
            txtDateCreated.ReadOnly = true;
            txtDateCreated.Size = new Size(120, 29);
            txtDateCreated.TabIndex = 10;
            // 
            // chkActive
            // 
            chkActive.Anchor = AnchorStyles.Left;
            chkActive.AutoSize = true;
            chkActive.BackColor = SystemColors.Control;
            chkActive.CheckAlign = ContentAlignment.BottomLeft;
            chkActive.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            chkActive.Location = new Point(177, 267);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(15, 14);
            chkActive.TabIndex = 11;
            chkActive.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            tblMain.SetColumnSpan(groupBox1, 3);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 298);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 192);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Location = new Point(3, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(510, 164);
            dataGridView1.TabIndex = 1;
            // 
            // frmSingleCookbook
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 493);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmSingleCookbook";
            Text = "Cookbook - ";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnDelete;
        private Button btnSave;
        private Label lblName;
        private Label lblUser;
        private Label lblPrice;
        private Label lblActive;
        private Label lblDate;
        private TextBox txtBookName;
        private ComboBox lstUserName;
        private TextBox txtPrice;
        private TextBox txtDateCreated;
        private CheckBox chkActive;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button1;
    }
}