namespace recipe_organizer
{
    partial class Planner
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
            dateTimePickerPlanner = new DateTimePicker();
            btnViewMeals = new Button();
            rchTxtBoxPlanner = new RichTextBox();
            btnAddMeals = new Button();
            SuspendLayout();
            // 
            // dateTimePickerPlanner
            // 
            dateTimePickerPlanner.Location = new Point(24, 12);
            dateTimePickerPlanner.Name = "dateTimePickerPlanner";
            dateTimePickerPlanner.Size = new Size(244, 27);
            dateTimePickerPlanner.TabIndex = 0;
            // 
            // btnViewMeals
            // 
            btnViewMeals.Location = new Point(28, 400);
            btnViewMeals.Name = "btnViewMeals";
            btnViewMeals.Size = new Size(94, 29);
            btnViewMeals.TabIndex = 1;
            btnViewMeals.Text = "View Meals";
            btnViewMeals.UseVisualStyleBackColor = true;
            btnViewMeals.Click += btnViewMeals_Click;
            // 
            // rchTxtBoxPlanner
            // 
            rchTxtBoxPlanner.Location = new Point(28, 88);
            rchTxtBoxPlanner.Name = "rchTxtBoxPlanner";
            rchTxtBoxPlanner.Size = new Size(437, 238);
            rchTxtBoxPlanner.TabIndex = 2;
            rchTxtBoxPlanner.Text = "";
            // 
            // btnAddMeals
            // 
            btnAddMeals.Location = new Point(185, 400);
            btnAddMeals.Name = "btnAddMeals";
            btnAddMeals.Size = new Size(94, 29);
            btnAddMeals.TabIndex = 3;
            btnAddMeals.Text = "Add Meals";
            btnAddMeals.UseVisualStyleBackColor = true;
            btnAddMeals.Click += btnAddMeals_Click;
            // 
            // Planner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddMeals);
            Controls.Add(rchTxtBoxPlanner);
            Controls.Add(btnViewMeals);
            Controls.Add(dateTimePickerPlanner);
            Name = "Planner";
            Text = "Planner";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePickerPlanner;
        private Button btnViewMeals;
        private RichTextBox rchTxtBoxPlanner;
        private Button btnAddMeals;
    }
}