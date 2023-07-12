namespace RecipeWinsForms
{
    partial class frmSingleRecipe
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
            lblRecipePic = new Label();
            lstCuisineName = new ComboBox();
            lblCaptionCalories = new Label();
            lblCaptionDateDrafted = new Label();
            lblCaptionDatePublished = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionRecipeStatus = new Label();
            lblCaptionPictureFile = new Label();
            lblCaptionRecipeName = new Label();
            txtRecipeName = new TextBox();
            txtCalories = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            lblCaptionUser = new Label();
            lblCaptionCuisine = new Label();
            flpButtons = new FlowLayoutPanel();
            btnDelete = new Button();
            btnSave = new Button();
            lstUserName = new ComboBox();
            dtpDateDrafted = new DateTimePicker();
            lblRecipeStatus = new Label();
            tblMain.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblRecipePic, 1, 8);
            tblMain.Controls.Add(lstCuisineName, 1, 2);
            tblMain.Controls.Add(lblCaptionCalories, 0, 3);
            tblMain.Controls.Add(lblCaptionDateDrafted, 0, 4);
            tblMain.Controls.Add(lblCaptionDatePublished, 0, 5);
            tblMain.Controls.Add(lblCaptionDateArchived, 0, 6);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 7);
            tblMain.Controls.Add(lblCaptionPictureFile, 0, 8);
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 0);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(txtCalories, 1, 3);
            tblMain.Controls.Add(txtDatePublished, 1, 5);
            tblMain.Controls.Add(txtDateArchived, 1, 6);
            tblMain.Controls.Add(lblCaptionUser, 0, 1);
            tblMain.Controls.Add(lblCaptionCuisine, 0, 2);
            tblMain.Controls.Add(flpButtons, 0, 9);
            tblMain.Controls.Add(lstUserName, 1, 1);
            tblMain.Controls.Add(dtpDateDrafted, 1, 4);
            tblMain.Controls.Add(lblRecipeStatus, 1, 7);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 10;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(542, 412);
            tblMain.TabIndex = 0;
            // 
            // lblRecipePic
            // 
            lblRecipePic.AutoSize = true;
            lblRecipePic.BackColor = SystemColors.ControlLightLight;
            lblRecipePic.Dock = DockStyle.Fill;
            lblRecipePic.Location = new Point(126, 336);
            lblRecipePic.Margin = new Padding(6, 8, 6, 6);
            lblRecipePic.Name = "lblRecipePic";
            lblRecipePic.Size = new Size(410, 27);
            lblRecipePic.TabIndex = 25;
            lblRecipePic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstCuisineName
            // 
            lstCuisineName.Anchor = AnchorStyles.Left;
            lstCuisineName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.ItemHeight = 21;
            lstCuisineName.Location = new Point(123, 88);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(208, 29);
            lstCuisineName.TabIndex = 22;
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionCalories.Location = new Point(3, 133);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(66, 21);
            lblCaptionCalories.TabIndex = 1;
            lblCaptionCalories.Text = "Calories";
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.Anchor = AnchorStyles.Left;
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionDateDrafted.Location = new Point(3, 174);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(98, 21);
            lblCaptionDateDrafted.TabIndex = 2;
            lblCaptionDateDrafted.Text = "Date Drafted";
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.Anchor = AnchorStyles.Left;
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionDatePublished.Location = new Point(3, 215);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(114, 21);
            lblCaptionDatePublished.TabIndex = 3;
            lblCaptionDatePublished.Text = "Date Published";
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.Anchor = AnchorStyles.Left;
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionDateArchived.Location = new Point(3, 256);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(107, 21);
            lblCaptionDateArchived.TabIndex = 4;
            lblCaptionDateArchived.Text = "Date Archived";
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.Anchor = AnchorStyles.Left;
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionRecipeStatus.Location = new Point(3, 297);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(109, 21);
            lblCaptionRecipeStatus.TabIndex = 5;
            lblCaptionRecipeStatus.Text = "Current Status";
            // 
            // lblCaptionPictureFile
            // 
            lblCaptionPictureFile.Anchor = AnchorStyles.Left;
            lblCaptionPictureFile.AutoSize = true;
            lblCaptionPictureFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionPictureFile.Location = new Point(3, 338);
            lblCaptionPictureFile.Name = "lblCaptionPictureFile";
            lblCaptionPictureFile.Size = new Size(96, 21);
            lblCaptionPictureFile.TabIndex = 6;
            lblCaptionPictureFile.Text = "Picture (File)";
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionRecipeName.Location = new Point(3, 10);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(56, 21);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Bottom;
            txtRecipeName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipeName.Location = new Point(123, 7);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(416, 31);
            txtRecipeName.TabIndex = 7;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Bottom;
            txtCalories.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtCalories.Location = new Point(123, 130);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(416, 31);
            txtCalories.TabIndex = 8;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Bottom;
            txtDatePublished.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtDatePublished.Location = new Point(123, 212);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(416, 31);
            txtDatePublished.TabIndex = 10;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Bottom;
            txtDateArchived.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateArchived.Location = new Point(123, 253);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(416, 31);
            txtDateArchived.TabIndex = 11;
            // 
            // lblCaptionUser
            // 
            lblCaptionUser.Anchor = AnchorStyles.Left;
            lblCaptionUser.AutoSize = true;
            lblCaptionUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionUser.Location = new Point(3, 51);
            lblCaptionUser.Name = "lblCaptionUser";
            lblCaptionUser.Size = new Size(88, 21);
            lblCaptionUser.TabIndex = 14;
            lblCaptionUser.Text = "User Name";
            lblCaptionUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionCuisine
            // 
            lblCaptionCuisine.Anchor = AnchorStyles.Left;
            lblCaptionCuisine.AutoSize = true;
            lblCaptionCuisine.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionCuisine.Location = new Point(3, 92);
            lblCaptionCuisine.Name = "lblCaptionCuisine";
            lblCaptionCuisine.Size = new Size(61, 21);
            lblCaptionCuisine.TabIndex = 15;
            lblCaptionCuisine.Text = "Cuisine";
            lblCaptionCuisine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpButtons
            // 
            tblMain.SetColumnSpan(flpButtons, 2);
            flpButtons.Controls.Add(btnDelete);
            flpButtons.Controls.Add(btnSave);
            flpButtons.Dock = DockStyle.Fill;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            flpButtons.Location = new Point(3, 372);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(536, 37);
            flpButtons.TabIndex = 20;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Right;
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Red;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDelete.Location = new Point(447, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 34);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.BackColor = Color.LimeGreen;
            btnSave.FlatAppearance.BorderColor = Color.LimeGreen;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnSave.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnSave.Location = new Point(355, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Left;
            lstUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstUserName.FormattingEnabled = true;
            lstUserName.ItemHeight = 21;
            lstUserName.Location = new Point(123, 47);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(208, 29);
            lstUserName.TabIndex = 21;
            // 
            // dtpDateDrafted
            // 
            dtpDateDrafted.Anchor = AnchorStyles.Left;
            dtpDateDrafted.CalendarFont = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateDrafted.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateDrafted.Format = DateTimePickerFormat.Short;
            dtpDateDrafted.Location = new Point(123, 170);
            dtpDateDrafted.MinimumSize = new Size(120, 32);
            dtpDateDrafted.Name = "dtpDateDrafted";
            dtpDateDrafted.Size = new Size(132, 32);
            dtpDateDrafted.TabIndex = 23;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.BackColor = SystemColors.ControlLightLight;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(126, 295);
            lblRecipeStatus.Margin = new Padding(6, 8, 6, 6);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(410, 27);
            lblRecipeStatus.TabIndex = 24;
            lblRecipeStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmSingleRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 412);
            Controls.Add(tblMain);
            Name = "frmSingleRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionRecipeName;
        private Label lblCaptionCalories;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateArchived;
        private Label lblCaptionRecipeStatus;
        private Label lblCaptionPictureFile;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private Label lblCaptionUser;
        private Label lblCaptionCuisine;
        private FlowLayoutPanel flpButtons;
        private Button btnDelete;
        private Button btnSave;
        private ComboBox lstUserName;
        private ComboBox lstCuisineName;
        private DateTimePicker dtpDateDrafted;
        private Label lblRecipeStatus;
        private Label lblRecipePic;
    }
}