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
            groupBoxShopList = new GroupBox();
            btnGenShoppingList = new Button();
            btnSaveShopList = new Button();
            rtbShopList = new RichTextBox();
            lblSelectCategory = new Label();
            lblSelectRecipe = new Label();
            dataGridViewRecipes = new DataGridView();
            btnShareRecipe = new Button();
            menuStrip.SuspendLayout();
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
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
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
            singleRecipeToolStripMenuItem.Click += singleRecipeToolStripMenuItem_Click;
            // 
            // allRecipesToolStripMenuItem
            // 
            allRecipesToolStripMenuItem.Name = "allRecipesToolStripMenuItem";
            allRecipesToolStripMenuItem.Size = new Size(144, 22);
            allRecipesToolStripMenuItem.Text = "All Recipes";
            allRecipesToolStripMenuItem.Click += allRecipesToolStripMenuItem_Click;
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
            // groupBoxShopList
            // 
            groupBoxShopList.Controls.Add(btnGenShoppingList);
            groupBoxShopList.Controls.Add(btnSaveShopList);
            groupBoxShopList.Controls.Add(rtbShopList);
            groupBoxShopList.Location = new Point(174, 333);
            groupBoxShopList.Name = "groupBoxShopList";
            groupBoxShopList.Size = new Size(301, 169);
            groupBoxShopList.TabIndex = 5;
            groupBoxShopList.TabStop = false;
            groupBoxShopList.Text = "Shopping List";
            // 
            // btnGenShoppingList
            // 
            btnGenShoppingList.Location = new Point(220, 111);
            btnGenShoppingList.Name = "btnGenShoppingList";
            btnGenShoppingList.Size = new Size(75, 23);
            btnGenShoppingList.TabIndex = 4;
            btnGenShoppingList.Text = "Generate";
            btnGenShoppingList.UseVisualStyleBackColor = true;
            btnGenShoppingList.Click += btnGenShoppingList_Click;
            // 
            // btnSaveShopList
            // 
            btnSaveShopList.Location = new Point(220, 140);
            btnSaveShopList.Name = "btnSaveShopList";
            btnSaveShopList.Size = new Size(75, 23);
            btnSaveShopList.TabIndex = 3;
            btnSaveShopList.Text = "Save";
            btnSaveShopList.UseVisualStyleBackColor = true;
            btnSaveShopList.Click += btnSaveShopList_Click;
            // 
            // rtbShopList
            // 
            rtbShopList.Enabled = false;
            rtbShopList.Location = new Point(6, 22);
            rtbShopList.Name = "rtbShopList";
            rtbShopList.Size = new Size(208, 141);
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
            dataGridViewRecipes.ScrollBars = ScrollBars.None;
            dataGridViewRecipes.Size = new Size(741, 271);
            dataGridViewRecipes.TabIndex = 8;
            dataGridViewRecipes.CellClick += dataGridViewRecipes_CellClick;
            // 
            // btnShareRecipe
            // 
            btnShareRecipe.Location = new Point(785, 444);
            btnShareRecipe.Name = "btnShareRecipe";
            btnShareRecipe.Size = new Size(130, 52);
            btnShareRecipe.TabIndex = 9;
            btnShareRecipe.Text = "Share Recipe";
            btnShareRecipe.UseVisualStyleBackColor = true;
            btnShareRecipe.Click += btnShareRecipe_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 512);
            Controls.Add(btnShareRecipe);
            Controls.Add(dataGridViewRecipes);
            Controls.Add(lblSelectRecipe);
            Controls.Add(lblSelectCategory);
            Controls.Add(groupBoxShopList);
            Controls.Add(listViewRecipeCategory);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainWindow";
            Text = "Recipe Organizer";
            Load += MainWindow_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
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
        private GroupBox groupBoxShopList;
        private Button btnSaveShopList;
        private RichTextBox rtbShopList;
        private Label lblSelectCategory;
        private Label lblSelectRecipe;
        private DataGridView dataGridViewRecipes;
        private Button btnGenShoppingList;
        private Button btnShareRecipe;
    }
}
