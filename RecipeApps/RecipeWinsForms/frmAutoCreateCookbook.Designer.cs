namespace RecipeWinsForms
{
    partial class frmAutoCreateCookbook
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
            lstUserName = new ComboBox();
            btnCreate = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lstUserName, 0, 0);
            tblMain.Controls.Add(btnCreate, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(5);
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(25, 65, 25, 25);
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(692, 293);
            tblMain.TabIndex = 0;
            // 
            // lstUserName
            // 
            lstUserName.AutoCompleteMode = AutoCompleteMode.Suggest;
            lstUserName.AutoCompleteSource = AutoCompleteSource.ListItems;
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(28, 68);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(315, 36);
            lstUserName.TabIndex = 0;
            lstUserName.Text = "Select a User";
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top;
            btnCreate.AutoSize = true;
            btnCreate.Location = new Point(419, 70);
            btnCreate.Margin = new Padding(5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(175, 38);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create Cookbook";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // frmAutoCreateCookbook
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 293);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "frmAutoCreateCookbook";
            Text = "Hearty Hearth - Auto-Create a Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstUserName;
        private Button btnCreate;
    }
}