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
            lstCuisineName = new ComboBox();
            lblCaptionCalories = new Label();
            txtCalories = new TextBox();
            lblCaptionCuisine = new Label();
            lblCaptionRecipeName = new Label();
            txtRecipeName = new TextBox();
            lblCaptionRecipeStatus = new Label();
            lblRecipeStatus = new Label();
            tblButtons = new TableLayoutPanel();
            btnDelete = new Button();
            btnSave = new Button();
            btnChangeStatus = new Button();
            lblDates = new Label();
            tblDateLabels = new TableLayoutPanel();
            lblArchived = new Label();
            lblPublished = new Label();
            lblDrafted = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtDateArchived = new TextBox();
            txtDatePublished = new TextBox();
            txtDateDrafted = new TextBox();
            tbChildRecords = new TabControl();
            tbIngredients = new TabPage();
            tblIngredients = new TableLayoutPanel();
            btnSaveIngredients = new Button();
            gIngredients = new DataGridView();
            tbSteps = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnSaveSteps = new Button();
            gSteps = new DataGridView();
            lblUser = new Label();
            lstUserName = new ComboBox();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            tblDateLabels.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tbChildRecords.SuspendLayout();
            tbIngredients.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tbSteps.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.08084F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.8282433F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tblMain.Controls.Add(lstCuisineName, 1, 3);
            tblMain.Controls.Add(lblCaptionCalories, 0, 4);
            tblMain.Controls.Add(txtCalories, 1, 4);
            tblMain.Controls.Add(lblCaptionCuisine, 0, 3);
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 2);
            tblMain.Controls.Add(txtRecipeName, 1, 2);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 5);
            tblMain.Controls.Add(lblRecipeStatus, 1, 5);
            tblMain.Controls.Add(tblButtons, 0, 0);
            tblMain.Controls.Add(lblDates, 0, 7);
            tblMain.Controls.Add(tblDateLabels, 1, 6);
            tblMain.Controls.Add(tableLayoutPanel1, 1, 7);
            tblMain.Controls.Add(tbChildRecords, 0, 8);
            tblMain.Controls.Add(lblUser, 0, 1);
            tblMain.Controls.Add(lstUserName, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 12;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.298807F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.298807F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.298807F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.298807F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.298807F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.298807F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.298807F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.298807F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.298807F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.298807F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 27.0119343F));
            tblMain.Size = new Size(499, 486);
            tblMain.TabIndex = 0;
            // 
            // lstCuisineName
            // 
            lstCuisineName.AutoCompleteMode = AutoCompleteMode.Suggest;
            lstCuisineName.AutoCompleteSource = AutoCompleteSource.ListItems;
            lstCuisineName.Dock = DockStyle.Fill;
            lstCuisineName.DropDownStyle = ComboBoxStyle.DropDownList;
            lstCuisineName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.ItemHeight = 21;
            lstCuisineName.Location = new Point(198, 102);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(252, 29);
            lstCuisineName.TabIndex = 2;
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionCalories.Location = new Point(30, 138);
            lblCaptionCalories.Margin = new Padding(30, 0, 3, 0);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(105, 21);
            lblCaptionCalories.TabIndex = 1;
            lblCaptionCalories.Text = "Num Calories";
            // 
            // txtCalories
            // 
            txtCalories.CausesValidation = false;
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtCalories.Location = new Point(198, 135);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(252, 31);
            txtCalories.TabIndex = 3;
            // 
            // lblCaptionCuisine
            // 
            lblCaptionCuisine.Anchor = AnchorStyles.Left;
            lblCaptionCuisine.AutoSize = true;
            lblCaptionCuisine.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionCuisine.Location = new Point(30, 105);
            lblCaptionCuisine.Margin = new Padding(30, 0, 3, 0);
            lblCaptionCuisine.Name = "lblCaptionCuisine";
            lblCaptionCuisine.Size = new Size(61, 21);
            lblCaptionCuisine.TabIndex = 15;
            lblCaptionCuisine.Text = "Cuisine";
            lblCaptionCuisine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionRecipeName.Location = new Point(30, 72);
            lblCaptionRecipeName.Margin = new Padding(30, 0, 3, 0);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(102, 21);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipeName.Location = new Point(198, 69);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(252, 31);
            txtRecipeName.TabIndex = 1;
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.Anchor = AnchorStyles.Left;
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionRecipeStatus.Location = new Point(30, 171);
            lblCaptionRecipeStatus.Margin = new Padding(30, 0, 3, 0);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(109, 21);
            lblCaptionRecipeStatus.TabIndex = 5;
            lblCaptionRecipeStatus.Text = "Current Status";
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.BackColor = SystemColors.ActiveBorder;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(197, 167);
            lblRecipeStatus.Margin = new Padding(2);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(254, 29);
            lblRecipeStatus.TabIndex = 7;
            lblRecipeStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 4;
            tblMain.SetColumnSpan(tblButtons, 3);
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7777786F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7777786F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7777786F));
            tblButtons.Controls.Add(btnDelete, 0, 0);
            tblButtons.Controls.Add(btnSave, 0, 0);
            tblButtons.Controls.Add(btnChangeStatus, 3, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 3);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.Size = new Size(493, 27);
            tblButtons.TabIndex = 16;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Red;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDelete.Location = new Point(82, 0);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 26);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.BackColor = Color.LimeGreen;
            btnSave.FlatAppearance.BorderColor = Color.LimeGreen;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnSave.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnSave.Location = new Point(0, 0);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 26);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Anchor = AnchorStyles.Top;
            btnChangeStatus.AutoSize = true;
            btnChangeStatus.BackColor = SystemColors.Info;
            btnChangeStatus.FlatAppearance.BorderColor = Color.Red;
            btnChangeStatus.FlatAppearance.BorderSize = 0;
            btnChangeStatus.FlatAppearance.MouseDownBackColor = Color.Red;
            btnChangeStatus.FlatAppearance.MouseOverBackColor = Color.Red;
            btnChangeStatus.Location = new Point(375, 0);
            btnChangeStatus.Margin = new Padding(0);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(97, 26);
            btnChangeStatus.TabIndex = 1;
            btnChangeStatus.Text = "&Change Status";
            btnChangeStatus.UseVisualStyleBackColor = false;
            // 
            // lblDates
            // 
            lblDates.Anchor = AnchorStyles.Left;
            lblDates.AutoSize = true;
            lblDates.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDates.Location = new Point(30, 237);
            lblDates.Margin = new Padding(30, 0, 3, 0);
            lblDates.Name = "lblDates";
            lblDates.Size = new Size(95, 21);
            lblDates.TabIndex = 17;
            lblDates.Text = "Status Dates";
            // 
            // tblDateLabels
            // 
            tblDateLabels.ColumnCount = 3;
            tblDateLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblDateLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblDateLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblDateLabels.Controls.Add(lblArchived, 2, 0);
            tblDateLabels.Controls.Add(lblPublished, 1, 0);
            tblDateLabels.Controls.Add(lblDrafted, 0, 0);
            tblDateLabels.Dock = DockStyle.Fill;
            tblDateLabels.Location = new Point(198, 201);
            tblDateLabels.Name = "tblDateLabels";
            tblDateLabels.RowCount = 1;
            tblDateLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblDateLabels.Size = new Size(252, 27);
            tblDateLabels.TabIndex = 18;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Dock = DockStyle.Fill;
            lblArchived.Location = new Point(171, 0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(78, 27);
            lblArchived.TabIndex = 2;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Dock = DockStyle.Fill;
            lblPublished.Location = new Point(87, 0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(78, 27);
            lblPublished.TabIndex = 1;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Dock = DockStyle.Fill;
            lblDrafted.Location = new Point(3, 0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(78, 27);
            lblDrafted.TabIndex = 0;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(txtDateArchived, 2, 0);
            tableLayoutPanel1.Controls.Add(txtDatePublished, 1, 0);
            tableLayoutPanel1.Controls.Add(txtDateDrafted, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(198, 234);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(252, 27);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // txtDateArchived
            // 
            txtDateArchived.BackColor = SystemColors.ActiveBorder;
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(169, 0);
            txtDateArchived.Margin = new Padding(1, 0, 1, 0);
            txtDateArchived.Multiline = true;
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(82, 27);
            txtDateArchived.TabIndex = 2;
            txtDateArchived.TabStop = false;
            txtDateArchived.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDatePublished
            // 
            txtDatePublished.BackColor = SystemColors.ActiveBorder;
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(85, 0);
            txtDatePublished.Margin = new Padding(1, 0, 1, 0);
            txtDatePublished.Multiline = true;
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(82, 27);
            txtDatePublished.TabIndex = 1;
            txtDatePublished.TabStop = false;
            txtDatePublished.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.BackColor = SystemColors.ActiveBorder;
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Location = new Point(1, 0);
            txtDateDrafted.Margin = new Padding(1, 0, 1, 0);
            txtDateDrafted.Multiline = true;
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.ReadOnly = true;
            txtDateDrafted.Size = new Size(82, 27);
            txtDateDrafted.TabIndex = 0;
            txtDateDrafted.TabStop = false;
            txtDateDrafted.TextAlign = HorizontalAlignment.Center;
            // 
            // tbChildRecords
            // 
            tblMain.SetColumnSpan(tbChildRecords, 3);
            tbChildRecords.Controls.Add(tbIngredients);
            tbChildRecords.Controls.Add(tbSteps);
            tbChildRecords.Dock = DockStyle.Fill;
            tbChildRecords.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbChildRecords.Location = new Point(3, 267);
            tbChildRecords.Name = "tbChildRecords";
            tblMain.SetRowSpan(tbChildRecords, 4);
            tbChildRecords.SelectedIndex = 0;
            tbChildRecords.Size = new Size(493, 216);
            tbChildRecords.TabIndex = 5;
            // 
            // tbIngredients
            // 
            tbIngredients.Controls.Add(tblIngredients);
            tbIngredients.Location = new Point(4, 30);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(3);
            tbIngredients.Size = new Size(485, 182);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblIngredients.Controls.Add(btnSaveIngredients, 0, 0);
            tblIngredients.Controls.Add(gIngredients, 0, 1);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblIngredients.Size = new Size(479, 176);
            tblIngredients.TabIndex = 0;
            // 
            // btnSaveIngredients
            // 
            btnSaveIngredients.AutoSize = true;
            btnSaveIngredients.BackColor = Color.LimeGreen;
            btnSaveIngredients.Location = new Point(3, 3);
            btnSaveIngredients.Name = "btnSaveIngredients";
            btnSaveIngredients.Size = new Size(75, 31);
            btnSaveIngredients.TabIndex = 0;
            btnSaveIngredients.Text = "S&ave";
            btnSaveIngredients.UseVisualStyleBackColor = false;
            // 
            // gIngredients
            // 
            gIngredients.BackgroundColor = SystemColors.Control;
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 40);
            gIngredients.Name = "gIngredients";
            gIngredients.RowTemplate.Height = 25;
            gIngredients.Size = new Size(473, 133);
            gIngredients.TabIndex = 1;
            // 
            // tbSteps
            // 
            tbSteps.Controls.Add(tableLayoutPanel2);
            tbSteps.Location = new Point(4, 30);
            tbSteps.Name = "tbSteps";
            tbSteps.Padding = new Padding(3);
            tbSteps.Size = new Size(485, 182);
            tbSteps.TabIndex = 1;
            tbSteps.Text = "Steps";
            tbSteps.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnSaveSteps, 0, 0);
            tableLayoutPanel2.Controls.Add(gSteps, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(479, 176);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnSaveSteps
            // 
            btnSaveSteps.AutoSize = true;
            btnSaveSteps.BackColor = Color.LimeGreen;
            btnSaveSteps.Location = new Point(3, 3);
            btnSaveSteps.Name = "btnSaveSteps";
            btnSaveSteps.Size = new Size(75, 31);
            btnSaveSteps.TabIndex = 0;
            btnSaveSteps.Text = "Save";
            btnSaveSteps.UseVisualStyleBackColor = false;
            // 
            // gSteps
            // 
            gSteps.BackgroundColor = SystemColors.Control;
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 40);
            gSteps.Name = "gSteps";
            gSteps.Size = new Size(473, 133);
            gSteps.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(30, 39);
            lblUser.Margin = new Padding(30, 0, 3, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(42, 21);
            lblUser.TabIndex = 21;
            lblUser.Text = "User";
            // 
            // lstUserName
            // 
            lstUserName.AutoCompleteMode = AutoCompleteMode.Suggest;
            lstUserName.AutoCompleteSource = AutoCompleteSource.ListItems;
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.DropDownStyle = ComboBoxStyle.DropDownList;
            lstUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstUserName.FormattingEnabled = true;
            lstUserName.ItemHeight = 21;
            lstUserName.Location = new Point(198, 39);
            lstUserName.Margin = new Padding(3, 6, 3, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(252, 29);
            lstUserName.TabIndex = 0;
            // 
            // frmSingleRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 486);
            Controls.Add(tblMain);
            Name = "frmSingleRecipe";
            Text = "Recipe - ";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            tblDateLabels.ResumeLayout(false);
            tblDateLabels.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tbChildRecords.ResumeLayout(false);
            tbIngredients.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            tblIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tbSteps.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionRecipeName;
        private Label lblCaptionCalories;
        private Label lblCaptionRecipeStatus;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private Label lblCaptionCuisine;
        private Button btnChangeStatus;
        private Button btnSave;
        private ComboBox lstCuisineName;
        private Label lblRecipeStatus;
        private TableLayoutPanel tblButtons;
        private Label lblDates;
        private TableLayoutPanel tblDateLabels;
        private Label lblArchived;
        private Label lblPublished;
        private Label lblDrafted;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtDateArchived;
        private TextBox txtDatePublished;
        private TextBox txtDateDrafted;
        private TabControl tbChildRecords;
        private TabPage tbIngredients;
        private TabPage tbSteps;
        private TableLayoutPanel tblIngredients;
        private Button btnSaveIngredients;
        private DataGridView gIngredients;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnSaveSteps;
        private DataGridView gSteps;
        private Label lblUser;
        private ComboBox lstUserName;
        private Button btnDelete;
    }
}