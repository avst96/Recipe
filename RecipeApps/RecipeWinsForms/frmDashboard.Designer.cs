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
            tblDashboardResults = new TableLayoutPanel();
            btnCookbooksCount = new Button();
            btnCookbooks = new Button();
            btnMealsCount = new Button();
            btnMeals = new Button();
            btnRecipesCount = new Button();
            btnRecipes = new Button();
            btnNumberHeader = new Button();
            btnTypeHeader = new Button();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            tblDashboardResults.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblHeader, 0, 1);
            tblMain.Controls.Add(lblDescription, 0, 2);
            tblMain.Controls.Add(tblButtons, 0, 4);
            tblMain.Controls.Add(tblDashboardResults, 0, 3);
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
            // tblDashboardResults
            // 
            tblDashboardResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tblDashboardResults.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblDashboardResults.ColumnCount = 2;
            tblDashboardResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDashboardResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDashboardResults.Controls.Add(btnCookbooksCount, 1, 3);
            tblDashboardResults.Controls.Add(btnCookbooks, 0, 3);
            tblDashboardResults.Controls.Add(btnMealsCount, 1, 2);
            tblDashboardResults.Controls.Add(btnMeals, 0, 2);
            tblDashboardResults.Controls.Add(btnRecipesCount, 1, 1);
            tblDashboardResults.Controls.Add(btnRecipes, 0, 1);
            tblDashboardResults.Controls.Add(btnNumberHeader, 1, 0);
            tblDashboardResults.Controls.Add(btnTypeHeader, 0, 0);
            tblDashboardResults.Location = new Point(280, 196);
            tblDashboardResults.Margin = new Padding(0);
            tblDashboardResults.Name = "tblDashboardResults";
            tblDashboardResults.RowCount = 4;
            tblDashboardResults.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblDashboardResults.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblDashboardResults.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblDashboardResults.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblDashboardResults.Size = new Size(240, 204);
            tblDashboardResults.TabIndex = 4;
            // 
            // btnCookbooksCount
            // 
            btnCookbooksCount.Dock = DockStyle.Fill;
            btnCookbooksCount.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnCookbooksCount.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnCookbooksCount.FlatStyle = FlatStyle.Flat;
            btnCookbooksCount.Location = new Point(120, 151);
            btnCookbooksCount.Margin = new Padding(0);
            btnCookbooksCount.Name = "btnCookbooksCount";
            btnCookbooksCount.Size = new Size(119, 52);
            btnCookbooksCount.TabIndex = 7;
            btnCookbooksCount.TabStop = false;
            btnCookbooksCount.Text = " ";
            btnCookbooksCount.UseVisualStyleBackColor = true;
            // 
            // btnCookbooks
            // 
            btnCookbooks.Dock = DockStyle.Fill;
            btnCookbooks.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnCookbooks.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnCookbooks.FlatStyle = FlatStyle.Flat;
            btnCookbooks.ForeColor = Color.Black;
            btnCookbooks.Location = new Point(1, 151);
            btnCookbooks.Margin = new Padding(0);
            btnCookbooks.Name = "btnCookbooks";
            btnCookbooks.Size = new Size(118, 52);
            btnCookbooks.TabIndex = 6;
            btnCookbooks.TabStop = false;
            btnCookbooks.Text = "Cookbooks";
            btnCookbooks.UseVisualStyleBackColor = true;
            // 
            // btnMealsCount
            // 
            btnMealsCount.Dock = DockStyle.Fill;
            btnMealsCount.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnMealsCount.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnMealsCount.FlatStyle = FlatStyle.Flat;
            btnMealsCount.Location = new Point(120, 101);
            btnMealsCount.Margin = new Padding(0);
            btnMealsCount.Name = "btnMealsCount";
            btnMealsCount.Size = new Size(119, 49);
            btnMealsCount.TabIndex = 5;
            btnMealsCount.TabStop = false;
            btnMealsCount.Text = " ";
            btnMealsCount.UseVisualStyleBackColor = true;
            // 
            // btnMeals
            // 
            btnMeals.Dock = DockStyle.Fill;
            btnMeals.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnMeals.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnMeals.FlatStyle = FlatStyle.Flat;
            btnMeals.ForeColor = Color.Black;
            btnMeals.Location = new Point(1, 101);
            btnMeals.Margin = new Padding(0);
            btnMeals.Name = "btnMeals";
            btnMeals.Size = new Size(118, 49);
            btnMeals.TabIndex = 4;
            btnMeals.TabStop = false;
            btnMeals.Text = "Meals";
            btnMeals.UseVisualStyleBackColor = true;
            // 
            // btnRecipesCount
            // 
            btnRecipesCount.Dock = DockStyle.Fill;
            btnRecipesCount.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnRecipesCount.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnRecipesCount.FlatStyle = FlatStyle.Flat;
            btnRecipesCount.Location = new Point(120, 51);
            btnRecipesCount.Margin = new Padding(0);
            btnRecipesCount.Name = "btnRecipesCount";
            btnRecipesCount.Size = new Size(119, 49);
            btnRecipesCount.TabIndex = 3;
            btnRecipesCount.TabStop = false;
            btnRecipesCount.Text = " ";
            btnRecipesCount.UseVisualStyleBackColor = true;
            // 
            // btnRecipes
            // 
            btnRecipes.Dock = DockStyle.Fill;
            btnRecipes.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnRecipes.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnRecipes.FlatStyle = FlatStyle.Flat;
            btnRecipes.ForeColor = Color.Black;
            btnRecipes.Location = new Point(1, 51);
            btnRecipes.Margin = new Padding(0);
            btnRecipes.Name = "btnRecipes";
            btnRecipes.Size = new Size(118, 49);
            btnRecipes.TabIndex = 2;
            btnRecipes.TabStop = false;
            btnRecipes.Text = "Recipes";
            btnRecipes.UseVisualStyleBackColor = true;
            // 
            // btnNumberHeader
            // 
            btnNumberHeader.BackColor = SystemColors.ActiveBorder;
            btnNumberHeader.Dock = DockStyle.Fill;
            btnNumberHeader.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            btnNumberHeader.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btnNumberHeader.FlatStyle = FlatStyle.Flat;
            btnNumberHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumberHeader.Location = new Point(120, 1);
            btnNumberHeader.Margin = new Padding(0);
            btnNumberHeader.Name = "btnNumberHeader";
            btnNumberHeader.Size = new Size(119, 49);
            btnNumberHeader.TabIndex = 1;
            btnNumberHeader.TabStop = false;
            btnNumberHeader.Text = "Number";
            btnNumberHeader.UseVisualStyleBackColor = false;
            // 
            // btnTypeHeader
            // 
            btnTypeHeader.BackColor = SystemColors.ActiveBorder;
            btnTypeHeader.Dock = DockStyle.Fill;
            btnTypeHeader.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            btnTypeHeader.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btnTypeHeader.FlatStyle = FlatStyle.Flat;
            btnTypeHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTypeHeader.Location = new Point(1, 1);
            btnTypeHeader.Margin = new Padding(0);
            btnTypeHeader.Name = "btnTypeHeader";
            btnTypeHeader.Size = new Size(118, 49);
            btnTypeHeader.TabIndex = 0;
            btnTypeHeader.TabStop = false;
            btnTypeHeader.Text = "Type";
            btnTypeHeader.UseVisualStyleBackColor = false;
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
            tblDashboardResults.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblHeader;
        private Label lblDescription;
        private TableLayoutPanel tblButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
        private TableLayoutPanel tblDashboardResults;
        private Button btnCookbooksCount;
        private Button btnCookbooks;
        private Button btnMealsCount;
        private Button btnMeals;
        private Button btnRecipesCount;
        private Button btnRecipes;
        private Button btnNumberHeader;
        private Button btnTypeHeader;
    }
}