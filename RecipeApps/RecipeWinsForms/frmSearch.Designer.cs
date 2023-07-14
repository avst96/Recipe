namespace RecipeWinsForms
{
    partial class frmSearch
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
            tblInput = new TableLayoutPanel();
            label1 = new Label();
            txtRecipeName = new TextBox();
            btnSearch = new Button();
            btnNew = new Button();
            gRecipes = new DataGridView();
            tblMain.SuspendLayout();
            tblInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipes).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(tblInput, 0, 0);
            tblMain.Controls.Add(gRecipes, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 82.77027F));
            tblMain.Size = new Size(869, 471);
            tblMain.TabIndex = 0;
            // 
            // tblInput
            // 
            tblInput.AutoSize = true;
            tblInput.ColumnCount = 4;
            tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblInput.ColumnStyles.Add(new ColumnStyle());
            tblInput.ColumnStyles.Add(new ColumnStyle());
            tblInput.Controls.Add(label1, 0, 0);
            tblInput.Controls.Add(txtRecipeName, 1, 0);
            tblInput.Controls.Add(btnSearch, 2, 0);
            tblInput.Controls.Add(btnNew, 3, 0);
            tblInput.Location = new Point(3, 3);
            tblInput.Name = "tblInput";
            tblInput.RowCount = 1;
            tblInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblInput.Size = new Size(370, 37);
            tblInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 0;
            label1.Text = "Recipe Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipeName.Location = new Point(111, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(102, 31);
            txtRecipeName.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(219, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(67, 31);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Dock = DockStyle.Fill;
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(292, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 31);
            btnNew.TabIndex = 3;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // gRecipes
            // 
            gRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipes.Dock = DockStyle.Fill;
            gRecipes.Location = new Point(3, 46);
            gRecipes.Name = "gRecipes";
            gRecipes.RowTemplate.Height = 25;
            gRecipes.Size = new Size(863, 422);
            gRecipes.TabIndex = 1;
            gRecipes.TabStop = false;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 471);
            Controls.Add(tblMain);
            Name = "frmSearch";
            Text = "Recipe Search";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblInput.ResumeLayout(false);
            tblInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblInput;
        private Label label1;
        private TextBox txtRecipeName;
        private Button btnSearch;
        private DataGridView gRecipes;
        private Button btnNew;
    }
}