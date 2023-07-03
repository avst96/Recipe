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
            lblPictureFile = new Label();
            lblCurrentStatus = new Label();
            lblDateArchived = new Label();
            lblDatePublished = new Label();
            lblDateDrafted = new Label();
            lblCalories = new Label();
            lblCaptionCalories = new Label();
            lblCaptionDateDrafted = new Label();
            lblCaptionDatePublished = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionRecipeStatus = new Label();
            lblCaptionPictureFile = new Label();
            lblCaptionRecipeName = new Label();
            lblRecipe = new Label();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblPictureFile, 1, 6);
            tblMain.Controls.Add(lblCurrentStatus, 1, 5);
            tblMain.Controls.Add(lblDateArchived, 1, 4);
            tblMain.Controls.Add(lblDatePublished, 1, 3);
            tblMain.Controls.Add(lblDateDrafted, 1, 2);
            tblMain.Controls.Add(lblCalories, 1, 1);
            tblMain.Controls.Add(lblCaptionCalories, 0, 1);
            tblMain.Controls.Add(lblCaptionDateDrafted, 0, 2);
            tblMain.Controls.Add(lblCaptionDatePublished, 0, 3);
            tblMain.Controls.Add(lblCaptionDateArchived, 0, 4);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 5);
            tblMain.Controls.Add(lblCaptionPictureFile, 0, 6);
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 0);
            tblMain.Controls.Add(lblRecipe, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857113F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblMain.Size = new Size(382, 284);
            tblMain.TabIndex = 0;
            // 
            // lblPictureFile
            // 
            lblPictureFile.AutoSize = true;
            lblPictureFile.BackColor = SystemColors.ControlLightLight;
            lblPictureFile.Dock = DockStyle.Fill;
            lblPictureFile.Location = new Point(123, 245);
            lblPictureFile.Margin = new Padding(3, 5, 3, 5);
            lblPictureFile.Name = "lblPictureFile";
            lblPictureFile.Size = new Size(256, 34);
            lblPictureFile.TabIndex = 13;
            lblPictureFile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.BackColor = SystemColors.ControlLightLight;
            lblCurrentStatus.Dock = DockStyle.Fill;
            lblCurrentStatus.Location = new Point(123, 205);
            lblCurrentStatus.Margin = new Padding(3, 5, 3, 5);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(256, 30);
            lblCurrentStatus.TabIndex = 12;
            lblCurrentStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.BackColor = SystemColors.ControlLightLight;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Location = new Point(123, 165);
            lblDateArchived.Margin = new Padding(3, 5, 3, 5);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(256, 30);
            lblDateArchived.TabIndex = 11;
            lblDateArchived.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.BackColor = SystemColors.ControlLightLight;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Location = new Point(123, 125);
            lblDatePublished.Margin = new Padding(3, 5, 3, 5);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(256, 30);
            lblDatePublished.TabIndex = 10;
            lblDatePublished.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.BackColor = SystemColors.ControlLightLight;
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Location = new Point(123, 85);
            lblDateDrafted.Margin = new Padding(3, 5, 3, 5);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(256, 30);
            lblDateDrafted.TabIndex = 9;
            lblDateDrafted.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.BackColor = SystemColors.ControlLightLight;
            lblCalories.Dock = DockStyle.Fill;
            lblCalories.Location = new Point(123, 45);
            lblCalories.Margin = new Padding(3, 5, 3, 5);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(256, 30);
            lblCalories.TabIndex = 8;
            lblCalories.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionCalories.Location = new Point(3, 49);
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
            lblCaptionDateDrafted.Location = new Point(3, 89);
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
            lblCaptionDatePublished.Location = new Point(3, 129);
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
            lblCaptionDateArchived.Location = new Point(3, 169);
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
            lblCaptionRecipeStatus.Location = new Point(3, 209);
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
            lblCaptionPictureFile.Location = new Point(3, 251);
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
            lblCaptionRecipeName.Location = new Point(3, 9);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(56, 21);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe";
            // 
            // lblRecipe
            // 
            lblRecipe.AutoSize = true;
            lblRecipe.BackColor = SystemColors.ControlLightLight;
            lblRecipe.Dock = DockStyle.Fill;
            lblRecipe.Location = new Point(123, 5);
            lblRecipe.Margin = new Padding(3, 5, 3, 5);
            lblRecipe.Name = "lblRecipe";
            lblRecipe.Size = new Size(256, 30);
            lblRecipe.TabIndex = 7;
            lblRecipe.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmSingleRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 284);
            Controls.Add(tblMain);
            Name = "frmSingleRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
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
        private Label lblRecipe;
        private Label lblPictureFile;
        private Label lblCurrentStatus;
        private Label lblDateArchived;
        private Label lblDatePublished;
        private Label lblDateDrafted;
        private Label lblCalories;
    }
}