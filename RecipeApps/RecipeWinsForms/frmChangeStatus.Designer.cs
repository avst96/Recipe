namespace RecipeWinsForms
{
    partial class frmChangeStatus
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
            lblRecipeName = new Label();
            tblStatus = new TableLayoutPanel();
            lblRecipeStatus = new Label();
            lblCurrentStatus = new Label();
            tblDates = new TableLayoutPanel();
            lblPublished = new Label();
            txtDateArchived = new TextBox();
            txtDatePublished = new TextBox();
            txtDateDrafted = new TextBox();
            lblDatesStatus = new Label();
            lblDrafted = new Label();
            lblArchived = new Label();
            btnDraft = new Button();
            btnPublish = new Button();
            btnArchive = new Button();
            tblMain.SuspendLayout();
            tblStatus.SuspendLayout();
            tblDates.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(tblStatus, 0, 1);
            tblMain.Controls.Add(tblDates, 0, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 17.6958542F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 22.3041458F));
            tblMain.Size = new Size(640, 336);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipeName.Location = new Point(4, 0);
            lblRecipeName.Margin = new Padding(4, 0, 4, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Padding = new Padding(0, 21, 0, 0);
            lblRecipeName.Size = new Size(632, 66);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblStatus
            // 
            tblStatus.ColumnCount = 2;
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblStatus.Controls.Add(lblRecipeStatus, 1, 0);
            tblStatus.Controls.Add(lblCurrentStatus, 0, 0);
            tblStatus.Dock = DockStyle.Fill;
            tblStatus.Location = new Point(4, 70);
            tblStatus.Margin = new Padding(4);
            tblStatus.Name = "tblStatus";
            tblStatus.RowCount = 1;
            tblStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatus.Size = new Size(632, 39);
            tblStatus.TabIndex = 1;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.Anchor = AnchorStyles.Left;
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipeStatus.Location = new Point(320, 7);
            lblRecipeStatus.Margin = new Padding(4, 0, 4, 0);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(98, 25);
            lblRecipeStatus.TabIndex = 1;
            lblRecipeStatus.Text = "unknown";
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Right;
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentStatus.Location = new Point(177, 7);
            lblCurrentStatus.Margin = new Padding(4, 0, 4, 0);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(135, 25);
            lblCurrentStatus.TabIndex = 0;
            lblCurrentStatus.Text = "Current Status:";
            // 
            // tblDates
            // 
            tblDates.ColumnCount = 5;
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.22222F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tblDates.Controls.Add(lblPublished, 2, 0);
            tblDates.Controls.Add(txtDateArchived, 3, 1);
            tblDates.Controls.Add(txtDatePublished, 2, 1);
            tblDates.Controls.Add(txtDateDrafted, 1, 1);
            tblDates.Controls.Add(lblDatesStatus, 0, 1);
            tblDates.Controls.Add(lblDrafted, 1, 0);
            tblDates.Controls.Add(lblArchived, 3, 0);
            tblDates.Controls.Add(btnDraft, 1, 3);
            tblDates.Controls.Add(btnPublish, 2, 3);
            tblDates.Controls.Add(btnArchive, 3, 3);
            tblDates.Dock = DockStyle.Fill;
            tblDates.Location = new Point(3, 116);
            tblDates.Name = "tblDates";
            tblDates.RowCount = 4;
            tblMain.SetRowSpan(tblDates, 3);
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDates.RowStyles.Add(new RowStyle());
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblDates.Size = new Size(634, 217);
            tblDates.TabIndex = 4;
            // 
            // lblPublished
            // 
            lblPublished.Anchor = AnchorStyles.Bottom;
            lblPublished.AutoSize = true;
            lblPublished.Location = new Point(311, 62);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(78, 21);
            lblPublished.TabIndex = 6;
            lblPublished.Text = "Published";
            // 
            // txtDateArchived
            // 
            txtDateArchived.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtDateArchived.BackColor = SystemColors.ControlDark;
            txtDateArchived.Location = new Point(440, 86);
            txtDateArchived.Multiline = true;
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(100, 44);
            txtDateArchived.TabIndex = 3;
            txtDateArchived.TabStop = false;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtDatePublished.BackColor = SystemColors.ControlDark;
            txtDatePublished.Location = new Point(300, 86);
            txtDatePublished.Multiline = true;
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(100, 44);
            txtDatePublished.TabIndex = 2;
            txtDatePublished.TabStop = false;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtDateDrafted.BackColor = SystemColors.ControlDark;
            txtDateDrafted.Location = new Point(160, 86);
            txtDateDrafted.Multiline = true;
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.ReadOnly = true;
            txtDateDrafted.Size = new Size(100, 44);
            txtDateDrafted.TabIndex = 1;
            txtDateDrafted.TabStop = false;
            // 
            // lblDatesStatus
            // 
            lblDatesStatus.Anchor = AnchorStyles.Right;
            lblDatesStatus.AutoSize = true;
            lblDatesStatus.Location = new Point(42, 99);
            lblDatesStatus.Margin = new Padding(3, 3, 3, 0);
            lblDatesStatus.Name = "lblDatesStatus";
            lblDatesStatus.Size = new Size(95, 21);
            lblDatesStatus.TabIndex = 0;
            lblDatesStatus.Text = "Status Dates";
            lblDatesStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDrafted
            // 
            lblDrafted.Anchor = AnchorStyles.Bottom;
            lblDrafted.AutoSize = true;
            lblDrafted.Location = new Point(179, 62);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(62, 21);
            lblDrafted.TabIndex = 4;
            lblDrafted.Text = "Drafted";
            // 
            // lblArchived
            // 
            lblArchived.Anchor = AnchorStyles.Bottom;
            lblArchived.AutoSize = true;
            lblArchived.Location = new Point(454, 62);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(71, 21);
            lblArchived.TabIndex = 5;
            lblArchived.Text = "Archived";
            // 
            // btnDraft
            // 
            btnDraft.Anchor = AnchorStyles.Top;
            btnDraft.AutoSize = true;
            btnDraft.Location = new Point(160, 174);
            btnDraft.Margin = new Padding(0);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(100, 31);
            btnDraft.TabIndex = 3;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            btnPublish.Anchor = AnchorStyles.Top;
            btnPublish.AutoSize = true;
            btnPublish.Location = new Point(300, 174);
            btnPublish.Margin = new Padding(0);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(100, 31);
            btnPublish.TabIndex = 7;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.Anchor = AnchorStyles.Top;
            btnArchive.AutoSize = true;
            btnArchive.Location = new Point(440, 174);
            btnArchive.Margin = new Padding(0);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(100, 31);
            btnArchive.TabIndex = 8;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // frmChangeStatus
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 336);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmChangeStatus";
            Text = "- Change Status";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblStatus.ResumeLayout(false);
            tblStatus.PerformLayout();
            tblDates.ResumeLayout(false);
            tblDates.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private TableLayoutPanel tblStatus;
        private Label lblCurrentStatus;
        private Label lblRecipeStatus;
        private TableLayoutPanel tblDates;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private TextBox txtDateArchived;
        private TextBox txtDatePublished;
        private TextBox txtDateDrafted;
        private Label lblDatesStatus;
        private Button btnDraft;
        private Button btnPublish;
        private Button btnArchive;
    }
}