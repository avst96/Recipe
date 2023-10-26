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
            btnSave = new Button();
            btnDelete = new Button();
            btnChangeStatus = new Button();
            lblDates = new Label();
            tblDateLabels = new TableLayoutPanel();
            lblArchived = new Label();
            lblPublished = new Label();
            lblDrafted = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtArchivedDates = new TextBox();
            txtPublishedDates = new TextBox();
            txtDraftedDates = new TextBox();
            tbChildRecords = new TabControl();
            tbIngredients = new TabPage();
            tblIngredients = new TableLayoutPanel();
            btSaveIngredients = new Button();
            gIngredients = new DataGridView();
            tbSteps = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnSaveSteps = new Button();
            gSteps = new DataGridView();
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
            tblMain.Controls.Add(lstCuisineName, 1, 2);
            tblMain.Controls.Add(lblCaptionCalories, 0, 3);
            tblMain.Controls.Add(txtCalories, 1, 3);
            tblMain.Controls.Add(lblCaptionCuisine, 0, 2);
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 1);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 4);
            tblMain.Controls.Add(lblRecipeStatus, 1, 4);
            tblMain.Controls.Add(tblButtons, 0, 0);
            tblMain.Controls.Add(lblDates, 0, 6);
            tblMain.Controls.Add(tblDateLabels, 1, 5);
            tblMain.Controls.Add(tableLayoutPanel1, 1, 6);
            tblMain.Controls.Add(tbChildRecords, 0, 7);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 11;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 13.043478F));
            tblMain.Size = new Size(551, 461);
            tblMain.TabIndex = 0;
            // 
            // lstCuisineName
            // 
            lstCuisineName.Dock = DockStyle.Fill;
            lstCuisineName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.ItemHeight = 21;
            lstCuisineName.Location = new Point(218, 83);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(279, 29);
            lstCuisineName.TabIndex = 2;
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionCalories.Location = new Point(30, 129);
            lblCaptionCalories.Margin = new Padding(30, 0, 3, 0);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(105, 21);
            lblCaptionCalories.TabIndex = 1;
            lblCaptionCalories.Text = "Num Calories";
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtCalories.Location = new Point(218, 123);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(279, 31);
            txtCalories.TabIndex = 3;
            // 
            // lblCaptionCuisine
            // 
            lblCaptionCuisine.Anchor = AnchorStyles.Left;
            lblCaptionCuisine.AutoSize = true;
            lblCaptionCuisine.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionCuisine.Location = new Point(30, 89);
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
            lblCaptionRecipeName.Location = new Point(30, 49);
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
            txtRecipeName.Location = new Point(218, 43);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(279, 31);
            txtRecipeName.TabIndex = 0;
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.Anchor = AnchorStyles.Left;
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionRecipeStatus.Location = new Point(30, 169);
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
            lblRecipeStatus.Location = new Point(221, 168);
            lblRecipeStatus.Margin = new Padding(6, 8, 6, 6);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(273, 26);
            lblRecipeStatus.TabIndex = 7;
            lblRecipeStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 4;
            tblMain.SetColumnSpan(tblButtons, 2);
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblButtons.Controls.Add(btnSave, 0, 0);
            tblButtons.Controls.Add(btnDelete, 1, 0);
            tblButtons.Controls.Add(btnChangeStatus, 3, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 3);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(494, 34);
            tblButtons.TabIndex = 16;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.BackColor = Color.LimeGreen;
            btnSave.FlatAppearance.BorderColor = Color.LimeGreen;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnSave.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnSave.Location = new Point(13, 0);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Left;
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Red;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDelete.Location = new Point(123, 0);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 34);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.AutoSize = true;
            btnChangeStatus.BackColor = SystemColors.Info;
            btnChangeStatus.Location = new Point(372, 3);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(102, 27);
            btnChangeStatus.TabIndex = 3;
            btnChangeStatus.Text = "Change Status...";
            btnChangeStatus.UseVisualStyleBackColor = false;
            // 
            // lblDates
            // 
            lblDates.Anchor = AnchorStyles.Left;
            lblDates.AutoSize = true;
            lblDates.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDates.Location = new Point(30, 249);
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
            tblDateLabels.Location = new Point(218, 203);
            tblDateLabels.Name = "tblDateLabels";
            tblDateLabels.RowCount = 1;
            tblDateLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblDateLabels.Size = new Size(279, 34);
            tblDateLabels.TabIndex = 18;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Dock = DockStyle.Fill;
            lblArchived.Location = new Point(189, 0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(87, 34);
            lblArchived.TabIndex = 2;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Dock = DockStyle.Fill;
            lblPublished.Location = new Point(96, 0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(87, 34);
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
            lblDrafted.Size = new Size(87, 34);
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
            tableLayoutPanel1.Controls.Add(txtArchivedDates, 2, 0);
            tableLayoutPanel1.Controls.Add(txtPublishedDates, 1, 0);
            tableLayoutPanel1.Controls.Add(txtDraftedDates, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(218, 243);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(279, 34);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // txtArchivedDates
            // 
            txtArchivedDates.BackColor = SystemColors.ActiveBorder;
            txtArchivedDates.Dock = DockStyle.Fill;
            txtArchivedDates.Location = new Point(187, 0);
            txtArchivedDates.Margin = new Padding(1, 0, 1, 0);
            txtArchivedDates.Multiline = true;
            txtArchivedDates.Name = "txtArchivedDates";
            txtArchivedDates.ReadOnly = true;
            txtArchivedDates.Size = new Size(91, 34);
            txtArchivedDates.TabIndex = 2;
            txtArchivedDates.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPublishedDates
            // 
            txtPublishedDates.BackColor = SystemColors.ActiveBorder;
            txtPublishedDates.Dock = DockStyle.Fill;
            txtPublishedDates.Location = new Point(94, 0);
            txtPublishedDates.Margin = new Padding(1, 0, 1, 0);
            txtPublishedDates.Multiline = true;
            txtPublishedDates.Name = "txtPublishedDates";
            txtPublishedDates.ReadOnly = true;
            txtPublishedDates.Size = new Size(91, 34);
            txtPublishedDates.TabIndex = 1;
            txtPublishedDates.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDraftedDates
            // 
            txtDraftedDates.BackColor = SystemColors.ActiveBorder;
            txtDraftedDates.Dock = DockStyle.Fill;
            txtDraftedDates.Location = new Point(1, 0);
            txtDraftedDates.Margin = new Padding(1, 0, 1, 0);
            txtDraftedDates.Multiline = true;
            txtDraftedDates.Name = "txtDraftedDates";
            txtDraftedDates.ReadOnly = true;
            txtDraftedDates.Size = new Size(91, 34);
            txtDraftedDates.TabIndex = 0;
            txtDraftedDates.TextAlign = HorizontalAlignment.Center;
            // 
            // tbChildRecords
            // 
            tblMain.SetColumnSpan(tbChildRecords, 3);
            tbChildRecords.Controls.Add(tbIngredients);
            tbChildRecords.Controls.Add(tbSteps);
            tbChildRecords.Dock = DockStyle.Fill;
            tbChildRecords.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbChildRecords.Location = new Point(3, 283);
            tbChildRecords.Name = "tbChildRecords";
            tblMain.SetRowSpan(tbChildRecords, 4);
            tbChildRecords.SelectedIndex = 0;
            tbChildRecords.Size = new Size(545, 175);
            tbChildRecords.TabIndex = 20;
            // 
            // tbIngredients
            // 
            tbIngredients.Controls.Add(tblIngredients);
            tbIngredients.Location = new Point(4, 30);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(3);
            tbIngredients.Size = new Size(537, 141);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblIngredients.Controls.Add(btSaveIngredients, 0, 0);
            tblIngredients.Controls.Add(gIngredients, 0, 1);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblIngredients.Size = new Size(531, 135);
            tblIngredients.TabIndex = 0;
            // 
            // btSaveIngredients
            // 
            btSaveIngredients.AutoSize = true;
            btSaveIngredients.BackColor = Color.LimeGreen;
            btSaveIngredients.Location = new Point(3, 3);
            btSaveIngredients.Name = "btSaveIngredients";
            btSaveIngredients.Size = new Size(75, 31);
            btSaveIngredients.TabIndex = 0;
            btSaveIngredients.Text = "Save";
            btSaveIngredients.UseVisualStyleBackColor = false;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 40);
            gIngredients.Name = "gIngredients";
            gIngredients.RowTemplate.Height = 25;
            gIngredients.Size = new Size(525, 92);
            gIngredients.TabIndex = 1;
            // 
            // tbSteps
            // 
            tbSteps.Controls.Add(tableLayoutPanel2);
            tbSteps.Location = new Point(4, 30);
            tbSteps.Name = "tbSteps";
            tbSteps.Padding = new Padding(3);
            tbSteps.Size = new Size(537, 141);
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
            tableLayoutPanel2.Size = new Size(531, 135);
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
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 40);
            gSteps.Name = "gSteps";
            gSteps.Size = new Size(525, 92);
            gSteps.TabIndex = 1;
            // 
            // frmSingleRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 461);
            Controls.Add(tblMain);
            Name = "frmSingleRecipe";
            Text = "Recipe";
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
        private Button btnDelete;
        private Button btnSave;
        private ComboBox lstCuisineName;
        private Label lblRecipeStatus;
        private TableLayoutPanel tblButtons;
        private Button btnChangeStatus;
        private Label lblDates;
        private TableLayoutPanel tblDateLabels;
        private Label lblArchived;
        private Label lblPublished;
        private Label lblDrafted;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtArchivedDates;
        private TextBox txtPublishedDates;
        private TextBox txtDraftedDates;
        private TabControl tbChildRecords;
        private TabPage tbIngredients;
        private TabPage tbSteps;
        private TableLayoutPanel tblIngredients;
        private Button btSaveIngredients;
        private DataGridView gIngredients;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnSaveSteps;
        private DataGridView gSteps;
    }
}