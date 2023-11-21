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
            optCuisine = new RadioButton();
            optIngredient = new RadioButton();
            optMeasuringUnit = new RadioButton();
            optCourse = new RadioButton();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            flpOptions.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(btnSave, 1, 1);
            tblMain.Controls.Add(gData, 1, 0);
            tblMain.Controls.Add(flpOptions, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(5, 5);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(495, 387);
            tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.BackColor = Color.LimeGreen;
            btnSave.Location = new Point(379, 355);
            btnSave.Margin = new Padding(4, 4, 20, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 32);
            btnSave.TabIndex = 2;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
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
            gData.StandardTab = true;
            gData.TabIndex = 1;
            // 
            // flpOptions
            // 
            flpOptions.AutoSize = true;
            flpOptions.BackColor = SystemColors.ControlLight;
            flpOptions.Controls.Add(optUsers);
            flpOptions.Controls.Add(optCuisine);
            flpOptions.Controls.Add(optIngredient);
            flpOptions.Controls.Add(optMeasuringUnit);
            flpOptions.Controls.Add(optCourse);
            flpOptions.Dock = DockStyle.Fill;
            flpOptions.FlowDirection = FlowDirection.TopDown;
            flpOptions.Location = new Point(3, 3);
            flpOptions.Name = "flpOptions";
            tblMain.SetRowSpan(flpOptions, 2);
            flpOptions.Size = new Size(148, 381);
            flpOptions.TabIndex = 0;
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
            optUsers.TabStop = true;
            optUsers.Text = "Users";
            optUsers.UseVisualStyleBackColor = true;
            // 
            // optCuisine
            // 
            optCuisine.Anchor = AnchorStyles.Left;
            optCuisine.AutoSize = true;
            optCuisine.Location = new Point(15, 75);
            optCuisine.Margin = new Padding(15, 20, 10, 10);
            optCuisine.Name = "optCuisine";
            optCuisine.Size = new Size(86, 25);
            optCuisine.TabIndex = 1;
            optCuisine.Text = "Cuisines";
            optCuisine.UseVisualStyleBackColor = true;
            // 
            // optIngredient
            // 
            optIngredient.Anchor = AnchorStyles.Left;
            optIngredient.AutoSize = true;
            optIngredient.Location = new Point(15, 130);
            optIngredient.Margin = new Padding(15, 20, 10, 10);
            optIngredient.Name = "optIngredient";
            optIngredient.Size = new Size(106, 25);
            optIngredient.TabIndex = 2;
            optIngredient.Text = "Ingredients";
            optIngredient.UseVisualStyleBackColor = true;
            // 
            // optMeasuringUnit
            // 
            optMeasuringUnit.Anchor = AnchorStyles.Left;
            optMeasuringUnit.AutoSize = true;
            optMeasuringUnit.Location = new Point(15, 185);
            optMeasuringUnit.Margin = new Padding(15, 20, 10, 10);
            optMeasuringUnit.Name = "optMeasuringUnit";
            optMeasuringUnit.Size = new Size(123, 25);
            optMeasuringUnit.TabIndex = 3;
            optMeasuringUnit.Text = "Measurments";
            optMeasuringUnit.UseVisualStyleBackColor = true;
            // 
            // optCourse
            // 
            optCourse.Anchor = AnchorStyles.Left;
            optCourse.AutoSize = true;
            optCourse.Location = new Point(15, 240);
            optCourse.Margin = new Padding(15, 20, 10, 10);
            optCourse.Name = "optCourse";
            optCourse.Size = new Size(84, 25);
            optCourse.TabIndex = 4;
            optCourse.Text = "Courses";
            optCourse.UseVisualStyleBackColor = true;
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
        private RadioButton optCuisine;
        private RadioButton optIngredient;
        private RadioButton optMeasuringUnit;
        private RadioButton optCourse;
    }
}