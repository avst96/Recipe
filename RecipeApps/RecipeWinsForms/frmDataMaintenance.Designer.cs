namespace RecipeWinsForms
{
    partial class frmDataMaintenance
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
            btnSave = new Button();
            gData = new DataGridView();
            flpOptions = new FlowLayoutPanel();
            optUsers = new RadioButton();
            optCuisines = new RadioButton();
            optIngredients = new RadioButton();
            optMeasurements = new RadioButton();
            optCourses = new RadioButton();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            flpOptions.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(btnSave, 1, 1);
            tblMain.Controls.Add(gData, 1, 0);
            tblMain.Controls.Add(flpOptions, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(5, 5);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(495, 387);
            tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.Location = new Point(379, 355);
            btnSave.Margin = new Padding(4, 4, 20, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 32);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.BackgroundColor = SystemColors.Control;
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(157, 3);
            gData.Name = "gData";
            gData.RowTemplate.Height = 25;
            gData.Size = new Size(335, 345);
            gData.TabIndex = 1;
            // 
            // flpOptions
            // 
            flpOptions.AutoSize = true;
            flpOptions.BackColor = SystemColors.ControlLight;
            flpOptions.Controls.Add(optUsers);
            flpOptions.Controls.Add(optCuisines);
            flpOptions.Controls.Add(optIngredients);
            flpOptions.Controls.Add(optMeasurements);
            flpOptions.Controls.Add(optCourses);
            flpOptions.Dock = DockStyle.Fill;
            flpOptions.FlowDirection = FlowDirection.TopDown;
            flpOptions.Location = new Point(3, 3);
            flpOptions.Name = "flpOptions";
            tblMain.SetRowSpan(flpOptions, 2);
            flpOptions.Size = new Size(148, 381);
            flpOptions.TabIndex = 2;
            // 
            // optUsers
            // 
            optUsers.Anchor = AnchorStyles.Left;
            optUsers.AutoSize = true;
            optUsers.Checked = true;
            optUsers.Location = new Point(15, 20);
            optUsers.Margin = new Padding(15, 20, 10, 10);
            optUsers.Name = "optUsers";
            optUsers.Size = new Size(67, 25);
            optUsers.TabIndex = 0;
            optUsers.Text = "Users";
            optUsers.UseVisualStyleBackColor = true;
            // 
            // optCuisines
            // 
            optCuisines.Anchor = AnchorStyles.Left;
            optCuisines.AutoSize = true;
            optCuisines.Location = new Point(15, 75);
            optCuisines.Margin = new Padding(15, 20, 10, 10);
            optCuisines.Name = "optCuisines";
            optCuisines.Size = new Size(86, 25);
            optCuisines.TabIndex = 1;
            optCuisines.Text = "Cuisines";
            optCuisines.UseVisualStyleBackColor = true;
            // 
            // optIngredients
            // 
            optIngredients.Anchor = AnchorStyles.Left;
            optIngredients.AutoSize = true;
            optIngredients.Location = new Point(15, 130);
            optIngredients.Margin = new Padding(15, 20, 10, 10);
            optIngredients.Name = "optIngredients";
            optIngredients.Size = new Size(106, 25);
            optIngredients.TabIndex = 2;
            optIngredients.Text = "Ingredients";
            optIngredients.UseVisualStyleBackColor = true;
            // 
            // optMeasurements
            // 
            optMeasurements.Anchor = AnchorStyles.Left;
            optMeasurements.AutoSize = true;
            optMeasurements.Location = new Point(15, 185);
            optMeasurements.Margin = new Padding(15, 20, 10, 10);
            optMeasurements.Name = "optMeasurements";
            optMeasurements.Size = new Size(123, 25);
            optMeasurements.TabIndex = 3;
            optMeasurements.Text = "Measurments";
            optMeasurements.UseVisualStyleBackColor = true;
            // 
            // optCourses
            // 
            optCourses.Anchor = AnchorStyles.Left;
            optCourses.AutoSize = true;
            optCourses.Location = new Point(15, 240);
            optCourses.Margin = new Padding(15, 20, 10, 10);
            optCourses.Name = "optCourses";
            optCourses.Size = new Size(84, 25);
            optCourses.TabIndex = 4;
            optCourses.Text = "Courses";
            optCourses.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 412);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmDataMaintenance";
            Padding = new Padding(5, 5, 5, 20);
            Text = "Hearty Hearth - Data Maintenance";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            flpOptions.ResumeLayout(false);
            flpOptions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private DataGridView gData;
        private FlowLayoutPanel flpOptions;
        private RadioButton optUsers;
        private RadioButton optCuisines;
        private RadioButton optIngredients;
        private RadioButton optMeasurements;
        private RadioButton optCourses;
    }
}