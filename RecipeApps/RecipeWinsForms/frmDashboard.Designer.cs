namespace RecipeWinsForms
{
    partial class frmDashboard
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
            lblHeader = new Label();
            lblDescription = new Label();
            tblButtons = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            gData = new DataGridView();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblHeader, 0, 1);
            tblMain.Controls.Add(lblDescription, 0, 2);
            tblMain.Controls.Add(tblButtons, 0, 4);
            tblMain.Controls.Add(gData, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.501193F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 29.8329353F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(3, 71);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(794, 40);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Hearty Hearth Desktop App";
            lblHeader.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top;
            lblDescription.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(181, 111);
            lblDescription.Name = "lblDescription";
            lblDescription.Padding = new Padding(20, 0, 20, 0);
            lblDescription.Size = new Size(438, 85);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Welcome to the Hearty Hearth desktop app. In this app you can also ....";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblButtons
            // 
            tblButtons.Anchor = AnchorStyles.Bottom;
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.Controls.Add(btnRecipeList, 0, 0);
            tblButtons.Controls.Add(btnMealList, 1, 0);
            tblButtons.Controls.Add(btnCookbookList, 2, 0);
            tblButtons.Location = new Point(212, 404);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.Size = new Size(376, 43);
            tblButtons.TabIndex = 3;
            // 
            // btnRecipeList
            // 
            btnRecipeList.Anchor = AnchorStyles.Bottom;
            btnRecipeList.AutoSize = true;
            btnRecipeList.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecipeList.Location = new Point(16, 3);
            btnRecipeList.Margin = new Padding(3, 3, 3, 15);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(93, 35);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            btnMealList.Anchor = AnchorStyles.Bottom;
            btnMealList.AutoSize = true;
            btnMealList.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMealList.Location = new Point(141, 3);
            btnMealList.Margin = new Padding(3, 3, 3, 15);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(93, 35);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.Anchor = AnchorStyles.Bottom;
            btnCookbookList.AutoSize = true;
            btnCookbookList.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCookbookList.Location = new Point(266, 3);
            btnCookbookList.Margin = new Padding(3, 3, 3, 15);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(93, 35);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.AllowUserToAddRows = false;
            gData.AllowUserToDeleteRows = false;
            gData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Location = new Point(238, 199);
            gData.Name = "gData";
            gData.ReadOnly = true;
            gData.RowTemplate.Height = 25;
            gData.Size = new Size(323, 198);
            gData.TabIndex = 2;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblHeader;
        private Label lblDescription;
        private DataGridView gData;
        private TableLayoutPanel tblButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
    }
}