namespace recipe_organizer
{
    partial class AddEditRecipeForm
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
            lblAddEditName = new Label();
            lblAddEditDescription = new Label();
            lblAddEditPrepTime = new Label();
            lblAddEditCookTime = new Label();
            lblAddEditCategories = new Label();
            lblAddEditServings = new Label();
            lblAddEditCalories = new Label();
            lblAddEditIngredients = new Label();
            lblAddEditInstructions = new Label();
            txtAddEditName = new TextBox();
            rtbAddEditDescription = new RichTextBox();
            picBoxAddEditImage = new PictureBox();
            gboxAddEditTime = new GroupBox();
            nudAddEditCookTime = new NumericUpDown();
            nudAddEditPrepTime = new NumericUpDown();
            lbxAddEditCategories = new ListBox();
            gboxAddEditMacroDetails = new GroupBox();
            nudAddEditCalories = new NumericUpDown();
            nudAddEditServings = new NumericUpDown();
            lbxAddEditIngredients = new ListBox();
            lbxAddEditInstructions = new ListBox();
            btnAddEditSave = new Button();
            btnAddEditCancel = new Button();
            btnAddEditCatAdd = new Button();
            btnAddEditCatRemove = new Button();
            btnAddEditInstructAdd = new Button();
            btnAddEditInstructRemove = new Button();
            btnAddEditIngAdd = new Button();
            btnAddEditIngRemove = new Button();
            btnAddEditImageAdd = new Button();
            btnAddEditImageRemove = new Button();
            btnAddEditIngEdit = new Button();
            btnAddEditInstructEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxAddEditImage).BeginInit();
            gboxAddEditTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAddEditCookTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAddEditPrepTime).BeginInit();
            gboxAddEditMacroDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAddEditCalories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAddEditServings).BeginInit();
            SuspendLayout();
            // 
            // lblAddEditName
            // 
            lblAddEditName.AutoSize = true;
            lblAddEditName.Location = new Point(12, 9);
            lblAddEditName.Name = "lblAddEditName";
            lblAddEditName.Size = new Size(42, 15);
            lblAddEditName.TabIndex = 0;
            lblAddEditName.Text = "Name:";
            // 
            // lblAddEditDescription
            // 
            lblAddEditDescription.AutoSize = true;
            lblAddEditDescription.Location = new Point(12, 67);
            lblAddEditDescription.Name = "lblAddEditDescription";
            lblAddEditDescription.Size = new Size(70, 15);
            lblAddEditDescription.TabIndex = 1;
            lblAddEditDescription.Text = "Description:";
            // 
            // lblAddEditPrepTime
            // 
            lblAddEditPrepTime.AutoSize = true;
            lblAddEditPrepTime.Location = new Point(25, 28);
            lblAddEditPrepTime.Name = "lblAddEditPrepTime";
            lblAddEditPrepTime.Size = new Size(155, 15);
            lblAddEditPrepTime.TabIndex = 3;
            lblAddEditPrepTime.Text = "Preperation Time (Minutes):";
            // 
            // lblAddEditCookTime
            // 
            lblAddEditCookTime.AutoSize = true;
            lblAddEditCookTime.Location = new Point(25, 68);
            lblAddEditCookTime.Name = "lblAddEditCookTime";
            lblAddEditCookTime.Size = new Size(139, 15);
            lblAddEditCookTime.TabIndex = 4;
            lblAddEditCookTime.Text = "Cooking Time (Minutes):";
            // 
            // lblAddEditCategories
            // 
            lblAddEditCategories.AutoSize = true;
            lblAddEditCategories.Location = new Point(12, 334);
            lblAddEditCategories.Name = "lblAddEditCategories";
            lblAddEditCategories.Size = new Size(119, 15);
            lblAddEditCategories.TabIndex = 5;
            lblAddEditCategories.Text = "Category/Categories:";
            // 
            // lblAddEditServings
            // 
            lblAddEditServings.AutoSize = true;
            lblAddEditServings.Location = new Point(13, 31);
            lblAddEditServings.Name = "lblAddEditServings";
            lblAddEditServings.Size = new Size(54, 15);
            lblAddEditServings.TabIndex = 6;
            lblAddEditServings.Text = "Servings:";
            // 
            // lblAddEditCalories
            // 
            lblAddEditCalories.AutoSize = true;
            lblAddEditCalories.Location = new Point(13, 70);
            lblAddEditCalories.Name = "lblAddEditCalories";
            lblAddEditCalories.Size = new Size(84, 15);
            lblAddEditCalories.TabIndex = 7;
            lblAddEditCalories.Text = "Calories (kcal):";
            // 
            // lblAddEditIngredients
            // 
            lblAddEditIngredients.AutoSize = true;
            lblAddEditIngredients.Location = new Point(622, 9);
            lblAddEditIngredients.Name = "lblAddEditIngredients";
            lblAddEditIngredients.Size = new Size(69, 15);
            lblAddEditIngredients.TabIndex = 8;
            lblAddEditIngredients.Text = "Ingredients:";
            // 
            // lblAddEditInstructions
            // 
            lblAddEditInstructions.AutoSize = true;
            lblAddEditInstructions.Location = new Point(622, 233);
            lblAddEditInstructions.Name = "lblAddEditInstructions";
            lblAddEditInstructions.Size = new Size(72, 15);
            lblAddEditInstructions.TabIndex = 9;
            lblAddEditInstructions.Text = "Instructions:";
            // 
            // txtAddEditName
            // 
            txtAddEditName.Location = new Point(12, 27);
            txtAddEditName.Name = "txtAddEditName";
            txtAddEditName.Size = new Size(316, 23);
            txtAddEditName.TabIndex = 10;
            // 
            // rtbAddEditDescription
            // 
            rtbAddEditDescription.Location = new Point(12, 95);
            rtbAddEditDescription.Name = "rtbAddEditDescription";
            rtbAddEditDescription.Size = new Size(316, 96);
            rtbAddEditDescription.TabIndex = 11;
            rtbAddEditDescription.Text = "";
            // 
            // picBoxAddEditImage
            // 
            picBoxAddEditImage.Location = new Point(362, 12);
            picBoxAddEditImage.Name = "picBoxAddEditImage";
            picBoxAddEditImage.Size = new Size(236, 193);
            picBoxAddEditImage.TabIndex = 13;
            picBoxAddEditImage.TabStop = false;
            // 
            // gboxAddEditTime
            // 
            gboxAddEditTime.Controls.Add(nudAddEditCookTime);
            gboxAddEditTime.Controls.Add(nudAddEditPrepTime);
            gboxAddEditTime.Controls.Add(lblAddEditPrepTime);
            gboxAddEditTime.Controls.Add(lblAddEditCookTime);
            gboxAddEditTime.Location = new Point(12, 214);
            gboxAddEditTime.Name = "gboxAddEditTime";
            gboxAddEditTime.Size = new Size(316, 109);
            gboxAddEditTime.TabIndex = 14;
            gboxAddEditTime.TabStop = false;
            gboxAddEditTime.Text = "Time";
            // 
            // nudAddEditCookTime
            // 
            nudAddEditCookTime.Location = new Point(186, 66);
            nudAddEditCookTime.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudAddEditCookTime.Name = "nudAddEditCookTime";
            nudAddEditCookTime.Size = new Size(103, 23);
            nudAddEditCookTime.TabIndex = 6;
            // 
            // nudAddEditPrepTime
            // 
            nudAddEditPrepTime.Location = new Point(186, 26);
            nudAddEditPrepTime.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudAddEditPrepTime.Name = "nudAddEditPrepTime";
            nudAddEditPrepTime.Size = new Size(103, 23);
            nudAddEditPrepTime.TabIndex = 5;
            // 
            // lbxAddEditCategories
            // 
            lbxAddEditCategories.FormattingEnabled = true;
            lbxAddEditCategories.ItemHeight = 15;
            lbxAddEditCategories.Location = new Point(12, 358);
            lbxAddEditCategories.Name = "lbxAddEditCategories";
            lbxAddEditCategories.Size = new Size(316, 139);
            lbxAddEditCategories.TabIndex = 15;
            // 
            // gboxAddEditMacroDetails
            // 
            gboxAddEditMacroDetails.Controls.Add(nudAddEditCalories);
            gboxAddEditMacroDetails.Controls.Add(nudAddEditServings);
            gboxAddEditMacroDetails.Controls.Add(lblAddEditServings);
            gboxAddEditMacroDetails.Controls.Add(lblAddEditCalories);
            gboxAddEditMacroDetails.Location = new Point(362, 260);
            gboxAddEditMacroDetails.Name = "gboxAddEditMacroDetails";
            gboxAddEditMacroDetails.Size = new Size(236, 105);
            gboxAddEditMacroDetails.TabIndex = 16;
            gboxAddEditMacroDetails.TabStop = false;
            gboxAddEditMacroDetails.Text = "Macro Details";
            // 
            // nudAddEditCalories
            // 
            nudAddEditCalories.Location = new Point(110, 67);
            nudAddEditCalories.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudAddEditCalories.Name = "nudAddEditCalories";
            nudAddEditCalories.Size = new Size(103, 23);
            nudAddEditCalories.TabIndex = 7;
            // 
            // nudAddEditServings
            // 
            nudAddEditServings.Location = new Point(110, 29);
            nudAddEditServings.Name = "nudAddEditServings";
            nudAddEditServings.Size = new Size(103, 23);
            nudAddEditServings.TabIndex = 8;
            // 
            // lbxAddEditIngredients
            // 
            lbxAddEditIngredients.FormattingEnabled = true;
            lbxAddEditIngredients.ItemHeight = 15;
            lbxAddEditIngredients.Location = new Point(622, 37);
            lbxAddEditIngredients.Name = "lbxAddEditIngredients";
            lbxAddEditIngredients.Size = new Size(372, 154);
            lbxAddEditIngredients.TabIndex = 17;
            // 
            // lbxAddEditInstructions
            // 
            lbxAddEditInstructions.FormattingEnabled = true;
            lbxAddEditInstructions.HorizontalScrollbar = true;
            lbxAddEditInstructions.ItemHeight = 15;
            lbxAddEditInstructions.Location = new Point(622, 256);
            lbxAddEditInstructions.Name = "lbxAddEditInstructions";
            lbxAddEditInstructions.Size = new Size(372, 244);
            lbxAddEditInstructions.TabIndex = 18;
            // 
            // btnAddEditSave
            // 
            btnAddEditSave.Location = new Point(411, 388);
            btnAddEditSave.Name = "btnAddEditSave";
            btnAddEditSave.Size = new Size(129, 46);
            btnAddEditSave.TabIndex = 19;
            btnAddEditSave.Text = "Save";
            btnAddEditSave.UseVisualStyleBackColor = true;
            btnAddEditSave.Click += btnAddEditSave_Click;
            // 
            // btnAddEditCancel
            // 
            btnAddEditCancel.Location = new Point(411, 449);
            btnAddEditCancel.Name = "btnAddEditCancel";
            btnAddEditCancel.Size = new Size(129, 46);
            btnAddEditCancel.TabIndex = 20;
            btnAddEditCancel.Text = "Cancel";
            btnAddEditCancel.UseVisualStyleBackColor = true;
            btnAddEditCancel.Click += btnAddEditCancel_Click;
            // 
            // btnAddEditCatAdd
            // 
            btnAddEditCatAdd.Location = new Point(12, 507);
            btnAddEditCatAdd.Name = "btnAddEditCatAdd";
            btnAddEditCatAdd.Size = new Size(75, 23);
            btnAddEditCatAdd.TabIndex = 21;
            btnAddEditCatAdd.Text = "Add";
            btnAddEditCatAdd.UseVisualStyleBackColor = true;
            btnAddEditCatAdd.Click += btnAddEditCatAdd_Click;
            // 
            // btnAddEditCatRemove
            // 
            btnAddEditCatRemove.Location = new Point(253, 507);
            btnAddEditCatRemove.Name = "btnAddEditCatRemove";
            btnAddEditCatRemove.Size = new Size(75, 23);
            btnAddEditCatRemove.TabIndex = 22;
            btnAddEditCatRemove.Text = "Remove";
            btnAddEditCatRemove.UseVisualStyleBackColor = true;
            btnAddEditCatRemove.Click += btnAddEditCatRemove_Click;
            // 
            // btnAddEditInstructAdd
            // 
            btnAddEditInstructAdd.Location = new Point(622, 508);
            btnAddEditInstructAdd.Name = "btnAddEditInstructAdd";
            btnAddEditInstructAdd.Size = new Size(75, 23);
            btnAddEditInstructAdd.TabIndex = 23;
            btnAddEditInstructAdd.Text = "Add";
            btnAddEditInstructAdd.UseVisualStyleBackColor = true;
            btnAddEditInstructAdd.Click += btnAddEditInstructAdd_Click;
            // 
            // btnAddEditInstructRemove
            // 
            btnAddEditInstructRemove.Location = new Point(919, 511);
            btnAddEditInstructRemove.Name = "btnAddEditInstructRemove";
            btnAddEditInstructRemove.Size = new Size(75, 23);
            btnAddEditInstructRemove.TabIndex = 24;
            btnAddEditInstructRemove.Text = "Remove";
            btnAddEditInstructRemove.UseVisualStyleBackColor = true;
            // 
            // btnAddEditIngAdd
            // 
            btnAddEditIngAdd.Location = new Point(622, 197);
            btnAddEditIngAdd.Name = "btnAddEditIngAdd";
            btnAddEditIngAdd.Size = new Size(75, 23);
            btnAddEditIngAdd.TabIndex = 25;
            btnAddEditIngAdd.Text = "Add";
            btnAddEditIngAdd.UseVisualStyleBackColor = true;
            btnAddEditIngAdd.Click += btnAddEditIngAdd_Click;
            // 
            // btnAddEditIngRemove
            // 
            btnAddEditIngRemove.Location = new Point(919, 197);
            btnAddEditIngRemove.Name = "btnAddEditIngRemove";
            btnAddEditIngRemove.Size = new Size(75, 23);
            btnAddEditIngRemove.TabIndex = 26;
            btnAddEditIngRemove.Text = "Remove";
            btnAddEditIngRemove.UseVisualStyleBackColor = true;
            btnAddEditIngRemove.Click += btnAddEditIngRemove_Click;
            // 
            // btnAddEditImageAdd
            // 
            btnAddEditImageAdd.Location = new Point(362, 214);
            btnAddEditImageAdd.Name = "btnAddEditImageAdd";
            btnAddEditImageAdd.Size = new Size(75, 23);
            btnAddEditImageAdd.TabIndex = 27;
            btnAddEditImageAdd.Text = "Select";
            btnAddEditImageAdd.UseVisualStyleBackColor = true;
            btnAddEditImageAdd.Click += btnAddEditImageAdd_Click;
            // 
            // btnAddEditImageRemove
            // 
            btnAddEditImageRemove.Location = new Point(523, 214);
            btnAddEditImageRemove.Name = "btnAddEditImageRemove";
            btnAddEditImageRemove.Size = new Size(75, 23);
            btnAddEditImageRemove.TabIndex = 28;
            btnAddEditImageRemove.Text = "Remove";
            btnAddEditImageRemove.UseVisualStyleBackColor = true;
            btnAddEditImageRemove.Click += btnAddEditImageRemove_Click;
            // 
            // btnAddEditIngEdit
            // 
            btnAddEditIngEdit.Location = new Point(703, 197);
            btnAddEditIngEdit.Name = "btnAddEditIngEdit";
            btnAddEditIngEdit.Size = new Size(75, 23);
            btnAddEditIngEdit.TabIndex = 29;
            btnAddEditIngEdit.Text = "Edit";
            btnAddEditIngEdit.UseVisualStyleBackColor = true;
            btnAddEditIngEdit.Click += btnAddEditIngEdit_Click;
            // 
            // btnAddEditInstructEdit
            // 
            btnAddEditInstructEdit.Location = new Point(703, 508);
            btnAddEditInstructEdit.Name = "btnAddEditInstructEdit";
            btnAddEditInstructEdit.Size = new Size(75, 23);
            btnAddEditInstructEdit.TabIndex = 30;
            btnAddEditInstructEdit.Text = "Edit";
            btnAddEditInstructEdit.UseVisualStyleBackColor = true;
            btnAddEditInstructEdit.Click += btnAddEditInstructEdit_Click;
            // 
            // AddEditRecipeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 546);
            Controls.Add(btnAddEditInstructEdit);
            Controls.Add(btnAddEditIngEdit);
            Controls.Add(btnAddEditImageRemove);
            Controls.Add(btnAddEditImageAdd);
            Controls.Add(btnAddEditIngRemove);
            Controls.Add(btnAddEditIngAdd);
            Controls.Add(btnAddEditInstructRemove);
            Controls.Add(btnAddEditInstructAdd);
            Controls.Add(btnAddEditCatRemove);
            Controls.Add(btnAddEditCatAdd);
            Controls.Add(btnAddEditCancel);
            Controls.Add(btnAddEditSave);
            Controls.Add(lbxAddEditInstructions);
            Controls.Add(lbxAddEditIngredients);
            Controls.Add(gboxAddEditMacroDetails);
            Controls.Add(lbxAddEditCategories);
            Controls.Add(gboxAddEditTime);
            Controls.Add(picBoxAddEditImage);
            Controls.Add(rtbAddEditDescription);
            Controls.Add(txtAddEditName);
            Controls.Add(lblAddEditInstructions);
            Controls.Add(lblAddEditIngredients);
            Controls.Add(lblAddEditCategories);
            Controls.Add(lblAddEditDescription);
            Controls.Add(lblAddEditName);
            Name = "AddEditRecipeForm";
            Text = "AddRecipeForm";
            ((System.ComponentModel.ISupportInitialize)picBoxAddEditImage).EndInit();
            gboxAddEditTime.ResumeLayout(false);
            gboxAddEditTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAddEditCookTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAddEditPrepTime).EndInit();
            gboxAddEditMacroDetails.ResumeLayout(false);
            gboxAddEditMacroDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAddEditCalories).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAddEditServings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddEditName;
        private Label lblAddEditDescription;
        private Label lblAddEditPrepTime;
        private Label lblAddEditCookTime;
        private Label lblAddEditCategories;
        private Label lblAddEditServings;
        private Label lblAddEditCalories;
        private Label lblAddEditIngredients;
        private Label lblAddEditInstructions;
        private TextBox txtAddEditName;
        private RichTextBox rtbAddEditDescription;
        private PictureBox picBoxAddEditImage;
        private GroupBox gboxAddEditTime;
        private NumericUpDown nudAddEditCookTime;
        private NumericUpDown nudAddEditPrepTime;
        private ListBox lbxAddEditCategories;
        private GroupBox gboxAddEditMacroDetails;
        private NumericUpDown nudAddEditCalories;
        private NumericUpDown nudAddEditServings;
        private ListBox lbxAddEditIngredients;
        private ListBox lbxAddEditInstructions;
        private Button btnAddEditSave;
        private Button btnAddEditCancel;
        private Button btnAddEditCatAdd;
        private Button btnAddEditCatRemove;
        private Button btnAddEditInstructAdd;
        private Button btnAddEditInstructRemove;
        private Button btnAddEditIngAdd;
        private Button btnAddEditIngRemove;
        private Button btnAddEditImageAdd;
        private Button btnAddEditImageRemove;
        private Button btnAddEditIngEdit;
        private Button btnAddEditInstructEdit;
    }
}