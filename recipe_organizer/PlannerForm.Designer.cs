namespace recipe_organizer
{
    partial class PlannerForm
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
            lblPlannedMeal = new Label();
            lblPlannedMealName = new Label();
            btnPlannedMealView = new Button();
            btnPlannedMealRemove = new Button();
            dtpPlannedMeal = new DateTimePicker();
            SuspendLayout();
            // 
            // lblPlannedMeal
            // 
            lblPlannedMeal.AutoSize = true;
            lblPlannedMeal.Font = new Font("Segoe UI", 12F);
            lblPlannedMeal.Location = new Point(257, 18);
            lblPlannedMeal.Name = "lblPlannedMeal";
            lblPlannedMeal.Size = new Size(107, 21);
            lblPlannedMeal.TabIndex = 1;
            lblPlannedMeal.Text = "Planned Meal:";
            // 
            // lblPlannedMealName
            // 
            lblPlannedMealName.AutoSize = true;
            lblPlannedMealName.Font = new Font("Segoe UI", 12F);
            lblPlannedMealName.Location = new Point(257, 77);
            lblPlannedMealName.Name = "lblPlannedMealName";
            lblPlannedMealName.Size = new Size(98, 21);
            lblPlannedMealName.TabIndex = 2;
            lblPlannedMealName.Text = "RecipeName";
            // 
            // btnPlannedMealView
            // 
            btnPlannedMealView.Location = new Point(257, 157);
            btnPlannedMealView.Name = "btnPlannedMealView";
            btnPlannedMealView.Size = new Size(75, 23);
            btnPlannedMealView.TabIndex = 3;
            btnPlannedMealView.Text = "View";
            btnPlannedMealView.UseVisualStyleBackColor = true;
            btnPlannedMealView.Click += btnPlannedMealView_Click;
            // 
            // btnPlannedMealRemove
            // 
            btnPlannedMealRemove.Location = new Point(495, 157);
            btnPlannedMealRemove.Name = "btnPlannedMealRemove";
            btnPlannedMealRemove.Size = new Size(75, 23);
            btnPlannedMealRemove.TabIndex = 4;
            btnPlannedMealRemove.Text = "Remove";
            btnPlannedMealRemove.UseVisualStyleBackColor = true;
            btnPlannedMealRemove.Click += btnPlannedMealRemove_Click;
            // 
            // dtpPlannedMeal
            // 
            dtpPlannedMeal.Location = new Point(12, 18);
            dtpPlannedMeal.Name = "dtpPlannedMeal";
            dtpPlannedMeal.Size = new Size(200, 23);
            dtpPlannedMeal.TabIndex = 5;
            dtpPlannedMeal.ValueChanged += dtpPlannedMeal_ValueChanged;
            // 
            // PlannerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 203);
            Controls.Add(dtpPlannedMeal);
            Controls.Add(btnPlannedMealRemove);
            Controls.Add(btnPlannedMealView);
            Controls.Add(lblPlannedMealName);
            Controls.Add(lblPlannedMeal);
            Name = "PlannerForm";
            Text = "Planner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPlannedMeal;
        private Label lblPlannedMealName;
        private Button btnPlannedMealView;
        private Button btnPlannedMealRemove;
        private DateTimePicker dtpPlannedMeal;
    }
}