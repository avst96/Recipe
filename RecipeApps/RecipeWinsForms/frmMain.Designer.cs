namespace RecipeWinsForms
{
    partial class frmMain
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
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            MnuDashboard = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            mnuRecipe = new ToolStripMenuItem();
            mnuListRecipe = new ToolStripMenuItem();
            mnuNewRecipe = new ToolStripMenuItem();
            mnuCloneRecipe = new ToolStripMenuItem();
            mnuMeals = new ToolStripMenuItem();
            mnuListMeals = new ToolStripMenuItem();
            mnuCookbooks = new ToolStripMenuItem();
            mnuListCookbooks = new ToolStripMenuItem();
            mnuNewCookbook = new ToolStripMenuItem();
            mnuAutoCreateCookbook = new ToolStripMenuItem();
            mnuData = new ToolStripMenuItem();
            mnuEditData = new ToolStripMenuItem();
            mnuWindows = new ToolStripMenuItem();
            mnuCascadeWindow = new ToolStripMenuItem();
            mnuTileWindow = new ToolStripMenuItem();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuRecipe, mnuMeals, mnuCookbooks, mnuData, mnuWindows });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Padding = new Padding(8, 3, 0, 3);
            mnuMain.Size = new Size(1029, 25);
            mnuMain.TabIndex = 1;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { MnuDashboard });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(38, 19);
            mnuFile.Text = "&File";
            // 
            // MnuDashboard
            // 
            MnuDashboard.Name = "MnuDashboard";
            MnuDashboard.Size = new Size(180, 22);
            MnuDashboard.Text = "&Dashboard";
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 25);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1029, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // mnuRecipe
            // 
            mnuRecipe.DropDownItems.AddRange(new ToolStripItem[] { mnuListRecipe, mnuNewRecipe, mnuCloneRecipe });
            mnuRecipe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mnuRecipe.Name = "mnuRecipe";
            mnuRecipe.Size = new Size(62, 19);
            mnuRecipe.Text = "&Recipes";
            // 
            // mnuListRecipe
            // 
            mnuListRecipe.Name = "mnuListRecipe";
            mnuListRecipe.Size = new Size(180, 22);
            mnuListRecipe.Text = "&List";
            // 
            // mnuNewRecipe
            // 
            mnuNewRecipe.Name = "mnuNewRecipe";
            mnuNewRecipe.Size = new Size(180, 22);
            mnuNewRecipe.Text = "&New Recipe";
            // 
            // mnuCloneRecipe
            // 
            mnuCloneRecipe.Name = "mnuCloneRecipe";
            mnuCloneRecipe.Size = new Size(180, 22);
            mnuCloneRecipe.Text = "&Clone Recipe";
            // 
            // mnuMeals
            // 
            mnuMeals.DropDownItems.AddRange(new ToolStripItem[] { mnuListMeals });
            mnuMeals.Name = "mnuMeals";
            mnuMeals.Size = new Size(51, 19);
            mnuMeals.Text = "&Meals";
            // 
            // mnuListMeals
            // 
            mnuListMeals.Name = "mnuListMeals";
            mnuListMeals.Size = new Size(180, 22);
            mnuListMeals.Text = "&List";
            // 
            // mnuCookbooks
            // 
            mnuCookbooks.DropDownItems.AddRange(new ToolStripItem[] { mnuListCookbooks, mnuNewCookbook, mnuAutoCreateCookbook });
            mnuCookbooks.Name = "mnuCookbooks";
            mnuCookbooks.Size = new Size(80, 19);
            mnuCookbooks.Text = "&Cookbooks";
            // 
            // mnuListCookbooks
            // 
            mnuListCookbooks.Name = "mnuListCookbooks";
            mnuListCookbooks.Size = new Size(180, 22);
            mnuListCookbooks.Text = "&List";
            // 
            // mnuNewCookbook
            // 
            mnuNewCookbook.Name = "mnuNewCookbook";
            mnuNewCookbook.Size = new Size(180, 22);
            mnuNewCookbook.Text = "&New Cookbook";
            // 
            // mnuAutoCreateCookbook
            // 
            mnuAutoCreateCookbook.Name = "mnuAutoCreateCookbook";
            mnuAutoCreateCookbook.Size = new Size(180, 22);
            mnuAutoCreateCookbook.Text = "&Auto-Create";
            // 
            // mnuData
            // 
            mnuData.DropDownItems.AddRange(new ToolStripItem[] { mnuEditData });
            mnuData.Name = "mnuData";
            mnuData.Size = new Size(120, 19);
            mnuData.Text = "&Data Maintenance";
            // 
            // mnuEditData
            // 
            mnuEditData.Name = "mnuEditData";
            mnuEditData.Size = new Size(180, 22);
            mnuEditData.Text = "&Edit Data";
            // 
            // mnuWindows
            // 
            mnuWindows.DropDownItems.AddRange(new ToolStripItem[] { mnuCascadeWindow, mnuTileWindow });
            mnuWindows.Name = "mnuWindows";
            mnuWindows.Size = new Size(70, 19);
            mnuWindows.Text = "&Windows";
            // 
            // mnuCascadeWindow
            // 
            mnuCascadeWindow.Name = "mnuCascadeWindow";
            mnuCascadeWindow.Size = new Size(180, 22);
            mnuCascadeWindow.Text = "&Cascade";
            // 
            // mnuTileWindow
            // 
            mnuTileWindow.Name = "mnuTileWindow";
            mnuTileWindow.Size = new Size(180, 22);
            mnuTileWindow.Text = "&Tile";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(toolStrip1);
            Controls.Add(mnuMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Recipe";
            WindowState = FormWindowState.Maximized;
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem MnuDashboard;
        private ToolStripMenuItem mnuRecipe;
        private ToolStripMenuItem mnuListRecipe;
        private ToolStripMenuItem mnuNewRecipe;
        private ToolStripMenuItem mnuCloneRecipe;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuListMeals;
        private ToolStripMenuItem mnuCookbooks;
        private ToolStripMenuItem mnuListCookbooks;
        private ToolStripMenuItem mnuNewCookbook;
        private ToolStripMenuItem mnuAutoCreateCookbook;
        private ToolStripMenuItem mnuData;
        private ToolStripMenuItem mnuEditData;
        private ToolStripMenuItem mnuWindows;
        private ToolStripMenuItem mnuCascadeWindow;
        private ToolStripMenuItem mnuTileWindow;
    }
}