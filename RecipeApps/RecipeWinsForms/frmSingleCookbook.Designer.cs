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
            btnDelete = new Button();
            btnSave = new Button();
            lblName = new Label();
            lblUser = new Label();
            lblPrice = new Label();
            lblActive = new Label();
            lblDate = new Label();
            txtBookName = new TextBox();
            txtPrice = new TextBox();
            txtDateCreated = new TextBox();
            chkIsActive = new CheckBox();
            label1 = new Label();
            btnSaveRecipe = new Button();
            gDataRecipe = new DataGridView();
            lstUserName = new ComboBox();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gDataRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(btnDelete, 1, 0);
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(lblName, 0, 1);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lblPrice, 0, 4);
            tblMain.Controls.Add(lblActive, 0, 5);
            tblMain.Controls.Add(lblDate, 2, 3);
            tblMain.Controls.Add(txtBookName, 1, 1);
            tblMain.Controls.Add(txtPrice, 1, 4);
            tblMain.Controls.Add(txtDateCreated, 2, 4);
            tblMain.Controls.Add(chkIsActive, 1, 5);
            tblMain.Controls.Add(label1, 0, 6);
            tblMain.Controls.Add(btnSaveRecipe, 0, 7);
            tblMain.Controls.Add(gDataRecipe, 0, 8);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(522, 493);
            tblMain.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Left;
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(160, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 31);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.BackColor = Color.LimeGreen;
            btnSave.Location = new Point(20, 10);
            btnSave.Margin = new Padding(20, 10, 10, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 31);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
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
            lblUser.TabIndex = 4;
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
            lblPrice.TabIndex = 6;
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
            lblActive.TabIndex = 8;
            lblActive.Text = "Active";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Bottom;
            lblDate.AutoSize = true;
            lblDate.Location = new Point(385, 178);
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
            txtBookName.Location = new Point(160, 59);
            txtBookName.Margin = new Padding(3, 8, 3, 8);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(310, 29);
            txtBookName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Left;
            txtPrice.CausesValidation = false;
            txtPrice.Location = new Point(160, 217);
            txtPrice.Margin = new Padding(3, 8, 3, 8);
            txtPrice.MaxLength = 11;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 29);
            txtPrice.TabIndex = 7;
            // 
            // txtDateCreated
            // 
            txtDateCreated.Anchor = AnchorStyles.Top;
            txtDateCreated.BackColor = SystemColors.ActiveBorder;
            txtDateCreated.Location = new Point(370, 217);
            txtDateCreated.Margin = new Padding(3, 8, 3, 8);
            txtDateCreated.MaxLength = 11;
            txtDateCreated.Name = "txtDateCreated";
            txtDateCreated.ReadOnly = true;
            txtDateCreated.Size = new Size(120, 29);
            txtDateCreated.TabIndex = 10;
            txtDateCreated.TabStop = false;
            // 
            // chkIsActive
            // 
            chkIsActive.Anchor = AnchorStyles.Left;
            chkIsActive.AutoSize = true;
            chkIsActive.BackColor = SystemColors.Control;
            chkIsActive.CheckAlign = ContentAlignment.BottomLeft;
            chkIsActive.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            chkIsActive.Location = new Point(160, 267);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(15, 14);
            chkIsActive.TabIndex = 9;
            chkIsActive.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            tblMain.SetColumnSpan(label1, 3);
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(3, 295);
            label1.Name = "label1";
            label1.Size = new Size(516, 2);
            label1.TabIndex = 12;
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.AutoSize = true;
            btnSaveRecipe.BackColor = Color.LimeGreen;
            btnSaveRecipe.Location = new Point(20, 307);
            btnSaveRecipe.Margin = new Padding(20, 10, 10, 10);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(100, 31);
            btnSaveRecipe.TabIndex = 10;
            btnSaveRecipe.Text = "S&ave";
            btnSaveRecipe.UseVisualStyleBackColor = false;
            // 
            // gDataRecipe
            // 
            gDataRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMain.SetColumnSpan(gDataRecipe, 3);
            gDataRecipe.Dock = DockStyle.Fill;
            gDataRecipe.Location = new Point(3, 351);
            gDataRecipe.Name = "gDataRecipe";
            gDataRecipe.RowTemplate.Height = 25;
            gDataRecipe.Size = new Size(516, 139);
            gDataRecipe.TabIndex = 11;
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Left;
            lstUserName.AutoCompleteMode = AutoCompleteMode.Suggest;
            lstUserName.AutoCompleteSource = AutoCompleteSource.ListItems;
            tblMain.SetColumnSpan(lstUserName, 2);
            lstUserName.DropDownStyle = ComboBoxStyle.DropDownList;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(160, 107);
            lstUserName.Margin = new Padding(3, 11, 3, 32);
            lstUserName.MaxDropDownItems = 20;
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(310, 29);
            lstUserName.TabIndex = 5;
            // 
            // frmSingleCookbook
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 493);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmSingleCookbook";
            Text = "Cookbook - ";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gDataRecipe).EndInit();
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
        private CheckBox chkIsActive;
        private Label label1;
        private Button btnSaveRecipe;
        private DataGridView gDataRecipe;
    }
}