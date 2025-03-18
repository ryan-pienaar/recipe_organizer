namespace recipe_organizer
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            singleRecipeToolStripMenuItem = new ToolStripMenuItem();
            allRecipesToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            byCategoryToolStripMenuItem = new ToolStripMenuItem();
            recipeToolStripMenuItem = new ToolStripMenuItem();
            createNewToolStripMenuItem = new ToolStripMenuItem();
            plannerToolStripMenuItem = new ToolStripMenuItem();
            listViewRecipeCategory = new ListView();
            groupBoxRecipeOptions = new GroupBox();
            nudNumServings = new NumericUpDown();
            lblNumServings = new Label();
            button1 = new Button();
            btnDeleteRecipe = new Button();
            btnGenerateShopList = new Button();
            btnEditRecipe = new Button();
            btnViewRecipe = new Button();
            groupBoxShopList = new GroupBox();
            btnSaveShopList = new Button();
            rtbShopList = new RichTextBox();
            lblSelectCategory = new Label();
            lblSelectRecipe = new Label();
            dataGridViewRecipes = new DataGridView();
            menuStrip.SuspendLayout();
            groupBoxRecipeOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumServings).BeginInit();
            groupBoxShopList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, searchToolStripMenuItem, recipeToolStripMenuItem, plannerToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(927, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(110, 22);
            importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { singleRecipeToolStripMenuItem, allRecipesToolStripMenuItem });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(110, 22);
            exportToolStripMenuItem.Text = "Export";
            // 
            // singleRecipeToolStripMenuItem
            // 
            singleRecipeToolStripMenuItem.Name = "singleRecipeToolStripMenuItem";
            singleRecipeToolStripMenuItem.Size = new Size(144, 22);
            singleRecipeToolStripMenuItem.Text = "Single Recipe";
            // 
            // allRecipesToolStripMenuItem
            // 
            allRecipesToolStripMenuItem.Name = "allRecipesToolStripMenuItem";
            allRecipesToolStripMenuItem.Size = new Size(144, 22);
            allRecipesToolStripMenuItem.Text = "All Recipes";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { byCategoryToolStripMenuItem });
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(54, 20);
            searchToolStripMenuItem.Text = "Search";
            // 
            // byCategoryToolStripMenuItem
            // 
            byCategoryToolStripMenuItem.Name = "byCategoryToolStripMenuItem";
            byCategoryToolStripMenuItem.Size = new Size(138, 22);
            byCategoryToolStripMenuItem.Text = "By Category";
            // 
            // recipeToolStripMenuItem
            // 
            recipeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createNewToolStripMenuItem });
            recipeToolStripMenuItem.Name = "recipeToolStripMenuItem";
            recipeToolStripMenuItem.Size = new Size(54, 20);
            recipeToolStripMenuItem.Text = "Recipe";
            // 
            // createNewToolStripMenuItem
            // 
            createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            createNewToolStripMenuItem.Size = new Size(135, 22);
            createNewToolStripMenuItem.Text = "Create New";
            // 
            // plannerToolStripMenuItem
            // 
            plannerToolStripMenuItem.Name = "plannerToolStripMenuItem";
            plannerToolStripMenuItem.Size = new Size(59, 20);
            plannerToolStripMenuItem.Text = "Planner";
            // 
            // listViewRecipeCategory
            // 
            listViewRecipeCategory.Location = new Point(12, 56);
            listViewRecipeCategory.Name = "listViewRecipeCategory";
            listViewRecipeCategory.Size = new Size(144, 446);
            listViewRecipeCategory.TabIndex = 2;
            listViewRecipeCategory.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxRecipeOptions
            // 
            groupBoxRecipeOptions.Controls.Add(nudNumServings);
            groupBoxRecipeOptions.Controls.Add(lblNumServings);
            groupBoxRecipeOptions.Controls.Add(button1);
            groupBoxRecipeOptions.Controls.Add(btnDeleteRecipe);
            groupBoxRecipeOptions.Controls.Add(btnGenerateShopList);
            groupBoxRecipeOptions.Controls.Add(btnEditRecipe);
            groupBoxRecipeOptions.Controls.Add(btnViewRecipe);
            groupBoxRecipeOptions.Location = new Point(174, 255);
            groupBoxRecipeOptions.Name = "groupBoxRecipeOptions";
            groupBoxRecipeOptions.Size = new Size(434, 253);
            groupBoxRecipeOptions.TabIndex = 4;
            groupBoxRecipeOptions.TabStop = false;
            groupBoxRecipeOptions.Text = "Options";
            // 
            // nudNumServings
            // 
            nudNumServings.Location = new Point(89, 93);
            nudNumServings.Name = "nudNumServings";
            nudNumServings.Size = new Size(120, 23);
            nudNumServings.TabIndex = 6;
            // 
            // lblNumServings
            // 
            lblNumServings.AutoSize = true;
            lblNumServings.Location = new Point(29, 95);
            lblNumServings.Name = "lblNumServings";
            lblNumServings.Size = new Size(54, 15);
            lblNumServings.TabIndex = 5;
            lblNumServings.Text = "Servings:";
            // 
            // button1
            // 
            button1.Location = new Point(27, 141);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 4;
            button1.Text = "Add to Planner";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRecipe
            // 
            btnDeleteRecipe.Location = new Point(272, 34);
            btnDeleteRecipe.Name = "btnDeleteRecipe";
            btnDeleteRecipe.Size = new Size(75, 23);
            btnDeleteRecipe.TabIndex = 3;
            btnDeleteRecipe.Text = "Delete";
            btnDeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // btnGenerateShopList
            // 
            btnGenerateShopList.Location = new Point(27, 208);
            btnGenerateShopList.Name = "btnGenerateShopList";
            btnGenerateShopList.Size = new Size(190, 23);
            btnGenerateShopList.TabIndex = 2;
            btnGenerateShopList.Text = "Generate Shopping List";
            btnGenerateShopList.UseVisualStyleBackColor = true;
            // 
            // btnEditRecipe
            // 
            btnEditRecipe.Location = new Point(134, 34);
            btnEditRecipe.Name = "btnEditRecipe";
            btnEditRecipe.Size = new Size(75, 23);
            btnEditRecipe.TabIndex = 1;
            btnEditRecipe.Text = "Edit";
            btnEditRecipe.UseVisualStyleBackColor = true;
            // 
            // btnViewRecipe
            // 
            btnViewRecipe.Location = new Point(27, 34);
            btnViewRecipe.Name = "btnViewRecipe";
            btnViewRecipe.Size = new Size(75, 23);
            btnViewRecipe.TabIndex = 0;
            btnViewRecipe.Text = "View";
            btnViewRecipe.UseVisualStyleBackColor = true;
            // 
            // groupBoxShopList
            // 
            groupBoxShopList.Controls.Add(btnSaveShopList);
            groupBoxShopList.Controls.Add(rtbShopList);
            groupBoxShopList.Location = new Point(614, 255);
            groupBoxShopList.Name = "groupBoxShopList";
            groupBoxShopList.Size = new Size(301, 253);
            groupBoxShopList.TabIndex = 5;
            groupBoxShopList.TabStop = false;
            groupBoxShopList.Text = "Shopping List";
            // 
            // btnSaveShopList
            // 
            btnSaveShopList.Location = new Point(220, 224);
            btnSaveShopList.Name = "btnSaveShopList";
            btnSaveShopList.Size = new Size(75, 23);
            btnSaveShopList.TabIndex = 3;
            btnSaveShopList.Text = "Save";
            btnSaveShopList.UseVisualStyleBackColor = true;
            // 
            // rtbShopList
            // 
            rtbShopList.Location = new Point(6, 22);
            rtbShopList.Name = "rtbShopList";
            rtbShopList.Size = new Size(208, 225);
            rtbShopList.TabIndex = 0;
            rtbShopList.Text = "";
            // 
            // lblSelectCategory
            // 
            lblSelectCategory.AutoSize = true;
            lblSelectCategory.Location = new Point(12, 38);
            lblSelectCategory.Name = "lblSelectCategory";
            lblSelectCategory.Size = new Size(92, 15);
            lblSelectCategory.TabIndex = 6;
            lblSelectCategory.Text = "Select Category:";
            // 
            // lblSelectRecipe
            // 
            lblSelectRecipe.AutoSize = true;
            lblSelectRecipe.Location = new Point(174, 38);
            lblSelectRecipe.Name = "lblSelectRecipe";
            lblSelectRecipe.Size = new Size(79, 15);
            lblSelectRecipe.TabIndex = 7;
            lblSelectRecipe.Text = "Select Recipe:";
            // 
            // dataGridViewRecipes
            // 
            dataGridViewRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecipes.Location = new Point(174, 56);
            dataGridViewRecipes.Name = "dataGridViewRecipes";
            dataGridViewRecipes.Size = new Size(741, 193);
            dataGridViewRecipes.TabIndex = 8;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 543);
            Controls.Add(dataGridViewRecipes);
            Controls.Add(lblSelectRecipe);
            Controls.Add(lblSelectCategory);
            Controls.Add(groupBoxShopList);
            Controls.Add(groupBoxRecipeOptions);
            Controls.Add(listViewRecipeCategory);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainWindow";
            Text = "Recipe Organizer";
            Load += MainWindow_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            groupBoxRecipeOptions.ResumeLayout(false);
            groupBoxRecipeOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumServings).EndInit();
            groupBoxShopList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem singleRecipeToolStripMenuItem;
        private ToolStripMenuItem allRecipesToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem plannerToolStripMenuItem;
        private ToolStripMenuItem byCategoryToolStripMenuItem;
        private ToolStripMenuItem recipeToolStripMenuItem;
        private ToolStripMenuItem createNewToolStripMenuItem;
        private ListView listViewRecipeCategory;
        private GroupBox groupBoxRecipeOptions;
        private Button btnEditRecipe;
        private Button btnViewRecipe;
        private Button btnGenerateShopList;
        private GroupBox groupBoxShopList;
        private Button btnSaveShopList;
        private RichTextBox rtbShopList;
        private Button btnDeleteRecipe;
        private Label lblNumServings;
        private Button button1;
        private NumericUpDown nudNumServings;
        private Label lblSelectCategory;
        private Label lblSelectRecipe;
        private DataGridView dataGridViewRecipes;
    }
}
