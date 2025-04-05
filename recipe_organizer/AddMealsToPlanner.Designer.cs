namespace recipe_organizer
{
    partial class AddMealsToPlanner
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
            cmbBoxAddToPlanner = new ComboBox();
            dateTimePickerAddToPlanner = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            btnAddToPlanner = new Button();
            SuspendLayout();
            // 
            // cmbBoxAddToPlanner
            // 
            cmbBoxAddToPlanner.FormattingEnabled = true;
            cmbBoxAddToPlanner.Location = new Point(159, 26);
            cmbBoxAddToPlanner.Name = "cmbBoxAddToPlanner";
            cmbBoxAddToPlanner.Size = new Size(151, 28);
            cmbBoxAddToPlanner.TabIndex = 0;
            // 
            // dateTimePickerAddToPlanner
            // 
            dateTimePickerAddToPlanner.Location = new Point(159, 114);
            dateTimePickerAddToPlanner.Name = "dateTimePickerAddToPlanner";
            dateTimePickerAddToPlanner.Size = new Size(250, 27);
            dateTimePickerAddToPlanner.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 2;
            label1.Text = "Choose recipe:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 121);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 3;
            label2.Text = "Choose date:";
            // 
            // btnAddToPlanner
            // 
            btnAddToPlanner.Location = new Point(146, 205);
            btnAddToPlanner.Name = "btnAddToPlanner";
            btnAddToPlanner.Size = new Size(146, 29);
            btnAddToPlanner.TabIndex = 4;
            btnAddToPlanner.Text = "Add to planner";
            btnAddToPlanner.UseVisualStyleBackColor = true;
            btnAddToPlanner.Click += btnAddToPlanner_Click;
            // 
            // AddMealsToPlanner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 246);
            Controls.Add(btnAddToPlanner);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerAddToPlanner);
            Controls.Add(cmbBoxAddToPlanner);
            Name = "AddMealsToPlanner";
            Text = "AddMealsToPlanner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBoxAddToPlanner;
        private DateTimePicker dateTimePickerAddToPlanner;
        private Label label1;
        private Label label2;
        private Button btnAddToPlanner;
    }
}