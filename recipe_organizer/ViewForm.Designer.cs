namespace recipe_organizer
{
    partial class ViewForm
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
            picBoxView = new PictureBox();
            lblViewPrepTime = new Label();
            lblViewInstructions = new Label();
            lblViewIngredients = new Label();
            lblViewCookTime = new Label();
            lblViewServings = new Label();
            lblViewCalories = new Label();
            lblViewRecipeNameHere = new Label();
            rtbViewInstructions = new RichTextBox();
            rtbViewIngredients = new RichTextBox();
            lblViewDetails = new Label();
            rtbViewDescription = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)picBoxView).BeginInit();
            SuspendLayout();
            // 
            // picBoxView
            // 
            picBoxView.BorderStyle = BorderStyle.FixedSingle;
            picBoxView.Location = new Point(18, 75);
            picBoxView.Name = "picBoxView";
            picBoxView.Size = new Size(321, 254);
            picBoxView.TabIndex = 0;
            picBoxView.TabStop = false;
            // 
            // lblViewPrepTime
            // 
            lblViewPrepTime.AutoSize = true;
            lblViewPrepTime.Location = new Point(742, 237);
            lblViewPrepTime.Name = "lblViewPrepTime";
            lblViewPrepTime.Size = new Size(104, 15);
            lblViewPrepTime.TabIndex = 2;
            lblViewPrepTime.Text = "Preperation Time: ";
            // 
            // lblViewInstructions
            // 
            lblViewInstructions.AutoSize = true;
            lblViewInstructions.Font = new Font("Segoe UI", 12F);
            lblViewInstructions.Location = new Point(18, 348);
            lblViewInstructions.Name = "lblViewInstructions";
            lblViewInstructions.Size = new Size(91, 21);
            lblViewInstructions.TabIndex = 3;
            lblViewInstructions.Text = "Instructions";
            // 
            // lblViewIngredients
            // 
            lblViewIngredients.AutoSize = true;
            lblViewIngredients.Font = new Font("Segoe UI", 12F);
            lblViewIngredients.Location = new Point(357, 75);
            lblViewIngredients.Name = "lblViewIngredients";
            lblViewIngredients.Size = new Size(88, 21);
            lblViewIngredients.TabIndex = 4;
            lblViewIngredients.Text = "Ingredients";
            // 
            // lblViewCookTime
            // 
            lblViewCookTime.AutoSize = true;
            lblViewCookTime.Location = new Point(742, 262);
            lblViewCookTime.Name = "lblViewCookTime";
            lblViewCookTime.Size = new Size(88, 15);
            lblViewCookTime.TabIndex = 3;
            lblViewCookTime.Text = "Cooking Time: ";
            // 
            // lblViewServings
            // 
            lblViewServings.AutoSize = true;
            lblViewServings.Location = new Point(742, 287);
            lblViewServings.Name = "lblViewServings";
            lblViewServings.Size = new Size(57, 15);
            lblViewServings.TabIndex = 4;
            lblViewServings.Text = "Servings: ";
            // 
            // lblViewCalories
            // 
            lblViewCalories.AutoSize = true;
            lblViewCalories.Location = new Point(742, 313);
            lblViewCalories.Name = "lblViewCalories";
            lblViewCalories.Size = new Size(55, 15);
            lblViewCalories.TabIndex = 6;
            lblViewCalories.Text = "Calories: ";
            // 
            // lblViewRecipeNameHere
            // 
            lblViewRecipeNameHere.AutoSize = true;
            lblViewRecipeNameHere.Font = new Font("Segoe UI", 18F);
            lblViewRecipeNameHere.Location = new Point(423, 9);
            lblViewRecipeNameHere.Name = "lblViewRecipeNameHere";
            lblViewRecipeNameHere.Size = new Size(148, 32);
            lblViewRecipeNameHere.TabIndex = 6;
            lblViewRecipeNameHere.Text = "RecipeName";
            // 
            // rtbViewInstructions
            // 
            rtbViewInstructions.Location = new Point(18, 372);
            rtbViewInstructions.Name = "rtbViewInstructions";
            rtbViewInstructions.Size = new Size(980, 205);
            rtbViewInstructions.TabIndex = 7;
            rtbViewInstructions.Text = "";
            // 
            // rtbViewIngredients
            // 
            rtbViewIngredients.Location = new Point(357, 110);
            rtbViewIngredients.Name = "rtbViewIngredients";
            rtbViewIngredients.Size = new Size(374, 219);
            rtbViewIngredients.TabIndex = 8;
            rtbViewIngredients.Text = "";
            // 
            // lblViewDetails
            // 
            lblViewDetails.AutoSize = true;
            lblViewDetails.Font = new Font("Segoe UI", 12F);
            lblViewDetails.Location = new Point(742, 75);
            lblViewDetails.Name = "lblViewDetails";
            lblViewDetails.Size = new Size(57, 21);
            lblViewDetails.TabIndex = 9;
            lblViewDetails.Text = "Details";
            // 
            // rtbViewDescription
            // 
            rtbViewDescription.Location = new Point(742, 110);
            rtbViewDescription.Name = "rtbViewDescription";
            rtbViewDescription.Size = new Size(256, 113);
            rtbViewDescription.TabIndex = 10;
            rtbViewDescription.Text = "";
            // 
            // ViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 589);
            Controls.Add(rtbViewDescription);
            Controls.Add(lblViewDetails);
            Controls.Add(lblViewCalories);
            Controls.Add(rtbViewIngredients);
            Controls.Add(lblViewServings);
            Controls.Add(rtbViewInstructions);
            Controls.Add(lblViewCookTime);
            Controls.Add(lblViewRecipeNameHere);
            Controls.Add(lblViewPrepTime);
            Controls.Add(lblViewIngredients);
            Controls.Add(lblViewInstructions);
            Controls.Add(picBoxView);
            Name = "ViewForm";
            Text = "View Recipe";
            ((System.ComponentModel.ISupportInitialize)picBoxView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxView;
        private Label lblViewPrepTime;
        private Label lblViewInstructions;
        private Label lblViewIngredients;
        private Label lblViewServings;
        private Label lblViewCookTime;
        private Label lblViewCalories;
        private Label lblViewRecipeNameHere;
        private RichTextBox rtbViewInstructions;
        private RichTextBox rtbViewIngredients;
        private Label lblViewDetails;
        private RichTextBox rtbViewDescription;
    }
}