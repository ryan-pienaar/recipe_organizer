namespace recipe_organizer
{
    partial class CreateRecipe
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
            label1 = new Label();
            txtBoxName = new TextBox();
            label2 = new Label();
            rchTxtBoxDescription = new RichTextBox();
            label3 = new Label();
            txtBoxImg = new TextBox();
            label4 = new Label();
            txtBoxPrepTime = new TextBox();
            label5 = new Label();
            txtBoxCookTime = new TextBox();
            label6 = new Label();
            txtBoxTotalTime = new TextBox();
            label7 = new Label();
            txtBoxCategory = new TextBox();
            label8 = new Label();
            txtBoxServings = new TextBox();
            label9 = new Label();
            txtBoxCalories = new TextBox();
            label10 = new Label();
            rchTxtBoxIngredients = new RichTextBox();
            label11 = new Label();
            rchTxtBoxInstructions = new RichTextBox();
            btnAddRecipe = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(129, 6);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(210, 27);
            txtBoxName.TabIndex = 1;
            txtBoxName.TextChanged += txtBoxName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // rchTxtBoxDescription
            // 
            rchTxtBoxDescription.Location = new Point(129, 62);
            rchTxtBoxDescription.Name = "rchTxtBoxDescription";
            rchTxtBoxDescription.Size = new Size(306, 85);
            rchTxtBoxDescription.TabIndex = 3;
            rchTxtBoxDescription.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 178);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "Image:";
            // 
            // txtBoxImg
            // 
            txtBoxImg.Location = new Point(129, 178);
            txtBoxImg.Name = "txtBoxImg";
            txtBoxImg.Size = new Size(210, 27);
            txtBoxImg.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 229);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 6;
            label4.Text = "Prep Time:";
            // 
            // txtBoxPrepTime
            // 
            txtBoxPrepTime.Location = new Point(129, 229);
            txtBoxPrepTime.Name = "txtBoxPrepTime";
            txtBoxPrepTime.Size = new Size(119, 27);
            txtBoxPrepTime.TabIndex = 7;
            txtBoxPrepTime.TextChanged += txtBoxPrepTime_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 269);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 8;
            label5.Text = "Cook Time:";
            // 
            // txtBoxCookTime
            // 
            txtBoxCookTime.Location = new Point(129, 262);
            txtBoxCookTime.Name = "txtBoxCookTime";
            txtBoxCookTime.Size = new Size(119, 27);
            txtBoxCookTime.TabIndex = 9;
            txtBoxCookTime.TextChanged += txtBoxCookTime_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 311);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 10;
            label6.Text = "Total Time:";
            // 
            // txtBoxTotalTime
            // 
            txtBoxTotalTime.Location = new Point(129, 304);
            txtBoxTotalTime.Name = "txtBoxTotalTime";
            txtBoxTotalTime.ReadOnly = true;
            txtBoxTotalTime.Size = new Size(119, 27);
            txtBoxTotalTime.TabIndex = 11;
            txtBoxTotalTime.TextChanged += txtBoxTotalTime_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 361);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 12;
            label7.Text = "Category:";
            // 
            // txtBoxCategory
            // 
            txtBoxCategory.Location = new Point(129, 354);
            txtBoxCategory.Name = "txtBoxCategory";
            txtBoxCategory.Size = new Size(210, 27);
            txtBoxCategory.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 406);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 14;
            label8.Text = "Servings:";
            // 
            // txtBoxServings
            // 
            txtBoxServings.Location = new Point(129, 406);
            txtBoxServings.Name = "txtBoxServings";
            txtBoxServings.Size = new Size(119, 27);
            txtBoxServings.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 455);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 16;
            label9.Text = "Calories:";
            // 
            // txtBoxCalories
            // 
            txtBoxCalories.Location = new Point(129, 455);
            txtBoxCalories.Name = "txtBoxCalories";
            txtBoxCalories.Size = new Size(119, 27);
            txtBoxCalories.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 509);
            label10.Name = "label10";
            label10.Size = new Size(86, 20);
            label10.TabIndex = 18;
            label10.Text = "Ingredients:";
            // 
            // rchTxtBoxIngredients
            // 
            rchTxtBoxIngredients.Location = new Point(129, 506);
            rchTxtBoxIngredients.Name = "rchTxtBoxIngredients";
            rchTxtBoxIngredients.Size = new Size(306, 110);
            rchTxtBoxIngredients.TabIndex = 19;
            rchTxtBoxIngredients.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 642);
            label11.Name = "label11";
            label11.Size = new Size(87, 20);
            label11.TabIndex = 20;
            label11.Text = "Instructions:";
            // 
            // rchTxtBoxInstructions
            // 
            rchTxtBoxInstructions.Location = new Point(129, 642);
            rchTxtBoxInstructions.Name = "rchTxtBoxInstructions";
            rchTxtBoxInstructions.Size = new Size(306, 180);
            rchTxtBoxInstructions.TabIndex = 21;
            rchTxtBoxInstructions.Text = "";
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Location = new Point(315, 856);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(147, 29);
            btnAddRecipe.TabIndex = 22;
            btnAddRecipe.Text = "Add Recipe";
            btnAddRecipe.UseVisualStyleBackColor = true;
            btnAddRecipe.Click += btnAddRecipe_Click;
            // 
            // CreateRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 897);
            Controls.Add(btnAddRecipe);
            Controls.Add(rchTxtBoxInstructions);
            Controls.Add(label11);
            Controls.Add(rchTxtBoxIngredients);
            Controls.Add(label10);
            Controls.Add(txtBoxCalories);
            Controls.Add(label9);
            Controls.Add(txtBoxServings);
            Controls.Add(label8);
            Controls.Add(txtBoxCategory);
            Controls.Add(label7);
            Controls.Add(txtBoxTotalTime);
            Controls.Add(label6);
            Controls.Add(txtBoxCookTime);
            Controls.Add(label5);
            Controls.Add(txtBoxPrepTime);
            Controls.Add(label4);
            Controls.Add(txtBoxImg);
            Controls.Add(label3);
            Controls.Add(rchTxtBoxDescription);
            Controls.Add(label2);
            Controls.Add(txtBoxName);
            Controls.Add(label1);
            Name = "CreateRecipe";
            Text = "CreateRecipe";
            Load += CreateRecipe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxName;
        private Label label2;
        private RichTextBox rchTxtBoxDescription;
        private Label label3;
        private TextBox txtBoxImg;
        private Label label4;
        private TextBox txtBoxPrepTime;
        private Label label5;
        private TextBox txtBoxCookTime;
        private Label label6;
        private TextBox txtBoxTotalTime;
        private Label label7;
        private TextBox txtBoxCategory;
        private Label label8;
        private TextBox txtBoxServings;
        private Label label9;
        private TextBox txtBoxCalories;
        private Label label10;
        private RichTextBox rchTxtBoxIngredients;
        private Label label11;
        private RichTextBox rchTxtBoxInstructions;
        private Button btnAddRecipe;
    }
}