namespace RecipeWinsForms
{
    partial class frmCloneRecipe
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
            btnClone = new Button();
            lstRecipeName = new ComboBox();
            lblRecipe = new Label();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(btnClone, 0, 2);
            tblMain.Controls.Add(lstRecipeName, 0, 1);
            tblMain.Controls.Add(lblRecipe, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(20);
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(675, 313);
            tblMain.TabIndex = 0;
            // 
            // btnClone
            // 
            btnClone.Anchor = AnchorStyles.Right;
            btnClone.AutoSize = true;
            btnClone.BackColor = Color.LimeGreen;
            btnClone.Location = new Point(224, 169);
            btnClone.Name = "btnClone";
            btnClone.Size = new Size(110, 31);
            btnClone.TabIndex = 2;
            btnClone.Text = "Clone";
            btnClone.UseVisualStyleBackColor = false;
            // 
            // lstRecipeName
            // 
            lstRecipeName.AutoCompleteMode = AutoCompleteMode.Suggest;
            lstRecipeName.AutoCompleteSource = AutoCompleteSource.ListItems;
            lstRecipeName.DropDownStyle = ComboBoxStyle.DropDownList;
            lstRecipeName.FormattingEnabled = true;
            lstRecipeName.Location = new Point(23, 44);
            lstRecipeName.Name = "lstRecipeName";
            lstRecipeName.Size = new Size(262, 29);
            lstRecipeName.TabIndex = 1;
            // 
            // lblRecipe
            // 
            lblRecipe.AutoSize = true;
            lblRecipe.Dock = DockStyle.Fill;
            lblRecipe.Location = new Point(23, 20);
            lblRecipe.Name = "lblRecipe";
            lblRecipe.Size = new Size(311, 21);
            lblRecipe.TabIndex = 0;
            lblRecipe.Text = "Select a recipe to clone";
            // 
            // frmCloneRecipe
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 313);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmCloneRecipe";
            Text = "Hearty Hearth - Clone a Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstRecipeName;
        private Button btnClone;
        private Label lblRecipe;
    }
}