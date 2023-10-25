namespace RecipeWinsForms
{
    partial class frmRecipeList
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
            btnNewRecipe = new Button();
            gData = new DataGridView();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(btnNewRecipe, 0, 0);
            tblMain.Controls.Add(gData, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 4, 4, 4);
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(10, 20, 10, 10);
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 21.5736046F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 78.4264F));
            tblMain.Size = new Size(718, 421);
            tblMain.TabIndex = 0;
            // 
            // btnNewRecipe
            // 
            btnNewRecipe.Anchor = AnchorStyles.Left;
            btnNewRecipe.AutoSize = true;
            btnNewRecipe.Location = new Point(14, 44);
            btnNewRecipe.Margin = new Padding(4, 4, 4, 4);
            btnNewRecipe.Name = "btnNewRecipe";
            btnNewRecipe.Size = new Size(132, 35);
            btnNewRecipe.TabIndex = 0;
            btnNewRecipe.Text = "New Recipe";
            btnNewRecipe.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.AllowUserToAddRows = false;
            gData.AllowUserToDeleteRows = false;
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(13, 107);
            gData.Name = "gData";
            gData.ReadOnly = true;
            gData.RowTemplate.Height = 25;
            gData.Size = new Size(692, 301);
            gData.TabIndex = 1;
            // 
            // frmRecipeList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 421);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmRecipeList";
            Text = "Recipe List";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnNewRecipe;
        private DataGridView gData;
    }
}