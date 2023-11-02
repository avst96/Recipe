namespace RecipeWinsForms
{
    partial class frmCookbookList
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
            btnNewCookbook = new Button();
            gData = new DataGridView();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(btnNewCookbook, 0, 0);
            tblMain.Controls.Add(gData, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(732, 448);
            tblMain.TabIndex = 0;
            // 
            // btnNewCookbook
            // 
            btnNewCookbook.AutoSize = true;
            btnNewCookbook.Location = new Point(10, 20);
            btnNewCookbook.Margin = new Padding(10, 20, 10, 10);
            btnNewCookbook.Name = "btnNewCookbook";
            btnNewCookbook.Size = new Size(127, 34);
            btnNewCookbook.TabIndex = 0;
            btnNewCookbook.Text = "New Cookbook";
            btnNewCookbook.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.AllowUserToAddRows = false;
            gData.AllowUserToDeleteRows = false;
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(3, 67);
            gData.Name = "gData";
            gData.ReadOnly = true;
            gData.RowTemplate.Height = 25;
            gData.Size = new Size(726, 378);
            gData.TabIndex = 1;
            // 
            // frmCookbookList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 448);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmCookbookList";
            Text = "Cookbook List";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnNewCookbook;
        private DataGridView gData;
    }
}