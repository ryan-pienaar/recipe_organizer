namespace recipe_organizer
{
    partial class MainForm
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
            ListViewItem listViewItem1 = new ListViewItem("test");
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
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, searchToolStripMenuItem, recipeToolStripMenuItem, plannerToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 3, 0, 3);
            menuStrip.Size = new Size(1059, 30);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(137, 26);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { singleRecipeToolStripMenuItem, allRecipesToolStripMenuItem });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(137, 26);
            exportToolStripMenuItem.Text = "Export";
            // 
            // singleRecipeToolStripMenuItem
            // 
            singleRecipeToolStripMenuItem.Name = "singleRecipeToolStripMenuItem";
            singleRecipeToolStripMenuItem.Size = new Size(182, 26);
            singleRecipeToolStripMenuItem.Text = "Single Recipe";
            singleRecipeToolStripMenuItem.Click += singleRecipeToolStripMenuItem_Click;
            // 
            // allRecipesToolStripMenuItem
            // 
            allRecipesToolStripMenuItem.Name = "allRecipesToolStripMenuItem";
            allRecipesToolStripMenuItem.Size = new Size(182, 26);
            allRecipesToolStripMenuItem.Text = "All Recipes";
            allRecipesToolStripMenuItem.Click += allRecipesToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { byCategoryToolStripMenuItem });
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(67, 24);
            searchToolStripMenuItem.Text = "Search";
            // 
            // byCategoryToolStripMenuItem
            // 
            byCategoryToolStripMenuItem.Name = "byCategoryToolStripMenuItem";
            byCategoryToolStripMenuItem.Size = new Size(172, 26);
            byCategoryToolStripMenuItem.Text = "By Category";
            // 
            // recipeToolStripMenuItem
            // 
            recipeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createNewToolStripMenuItem });
            recipeToolStripMenuItem.Name = "recipeToolStripMenuItem";
            recipeToolStripMenuItem.Size = new Size(68, 24);
            recipeToolStripMenuItem.Text = "Recipe";
            // 
            // createNewToolStripMenuItem
            // 
            createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            createNewToolStripMenuItem.Size = new Size(169, 26);
            createNewToolStripMenuItem.Text = "Create New";
            // 
            // plannerToolStripMenuItem
            // 
            plannerToolStripMenuItem.Name = "plannerToolStripMenuItem";
            plannerToolStripMenuItem.Size = new Size(72, 24);
            plannerToolStripMenuItem.Text = "Planner";
            // 
            // listViewRecipeCategory
            // 
            listViewRecipeCategory.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listViewRecipeCategory.Location = new Point(14, 75);
            listViewRecipeCategory.Margin = new Padding(3, 4, 3, 4);
            listViewRecipeCategory.Name = "listViewRecipeCategory";
            listViewRecipeCategory.Size = new Size(164, 593);
            listViewRecipeCategory.TabIndex = 2;
            listViewRecipeCategory.UseCompatibleStateImageBehavior = false;
            listViewRecipeCategory.SelectedIndexChanged += listViewRecipeCategory_SelectedIndexChanged;
            // 
            // groupBoxShopList
            // 
            groupBoxShopList.Controls.Add(btnGenShoppingList);
            groupBoxShopList.Controls.Add(btnSaveShopList);
            groupBoxShopList.Controls.Add(rtbShopList);
            groupBoxShopList.Location = new Point(199, 444);
            groupBoxShopList.Margin = new Padding(3, 4, 3, 4);
            groupBoxShopList.Name = "groupBoxShopList";
            groupBoxShopList.Padding = new Padding(3, 4, 3, 4);
            groupBoxShopList.Size = new Size(344, 225);
            groupBoxShopList.TabIndex = 5;
            groupBoxShopList.TabStop = false;
            groupBoxShopList.Text = "Shopping List";
            // 
            // btnGenShoppingList
            // 
            btnGenShoppingList.Location = new Point(251, 148);
            btnGenShoppingList.Margin = new Padding(3, 4, 3, 4);
            btnGenShoppingList.Name = "btnGenShoppingList";
            btnGenShoppingList.Size = new Size(86, 31);
            btnGenShoppingList.TabIndex = 4;
            btnGenShoppingList.Text = "Generate";
            btnGenShoppingList.UseVisualStyleBackColor = true;
            btnGenShoppingList.Click += btnGenShoppingList_Click;
            // 
            // btnSaveShopList
            // 
            btnSaveShopList.Location = new Point(251, 187);
            btnSaveShopList.Margin = new Padding(3, 4, 3, 4);
            btnSaveShopList.Name = "btnSaveShopList";
            btnSaveShopList.Size = new Size(86, 31);
            btnSaveShopList.TabIndex = 3;
            btnSaveShopList.Text = "Save";
            btnSaveShopList.UseVisualStyleBackColor = true;
            btnSaveShopList.Click += btnSaveShopList_Click;
            // 
            // rtbShopList
            // 
            rtbShopList.Enabled = false;
            rtbShopList.Location = new Point(7, 29);
            rtbShopList.Margin = new Padding(3, 4, 3, 4);
            rtbShopList.Name = "rtbShopList";
            rtbShopList.Size = new Size(237, 187);
            rtbShopList.TabIndex = 0;
            rtbShopList.Text = "";
            // 
            // lblSelectCategory
            // 
            lblSelectCategory.AutoSize = true;
            lblSelectCategory.Location = new Point(14, 51);
            lblSelectCategory.Name = "lblSelectCategory";
            lblSelectCategory.Size = new Size(116, 20);
            lblSelectCategory.TabIndex = 6;
            lblSelectCategory.Text = "Select Category:";
            // 
            // lblSelectRecipe
            // 
            lblSelectRecipe.AutoSize = true;
            lblSelectRecipe.Location = new Point(199, 51);
            lblSelectRecipe.Name = "lblSelectRecipe";
            lblSelectRecipe.Size = new Size(101, 20);
            lblSelectRecipe.TabIndex = 7;
            lblSelectRecipe.Text = "Select Recipe:";
            // 
            // dataGridViewRecipes
            // 
            dataGridViewRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecipes.Location = new Point(199, 75);
            dataGridViewRecipes.Margin = new Padding(3, 4, 3, 4);
            dataGridViewRecipes.Name = "dataGridViewRecipes";
            dataGridViewRecipes.RowHeadersWidth = 51;
            dataGridViewRecipes.ScrollBars = ScrollBars.None;
            dataGridViewRecipes.Size = new Size(847, 361);
            dataGridViewRecipes.TabIndex = 8;
            dataGridViewRecipes.CellClick += dataGridViewRecipes_CellClick;
            dataGridViewRecipes.CellContentClick += dataGridViewRecipes_CellContentClick;
            // 
            // btnShareRecipe
            // 
            btnShareRecipe.Location = new Point(897, 592);
            btnShareRecipe.Margin = new Padding(3, 4, 3, 4);
            btnShareRecipe.Name = "btnShareRecipe";
            btnShareRecipe.Size = new Size(149, 69);
            btnShareRecipe.TabIndex = 9;
            btnShareRecipe.Text = "Share Recipe";
            btnShareRecipe.UseVisualStyleBackColor = true;
            btnShareRecipe.Click += btnShareRecipe_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 683);
            Controls.Add(btnShareRecipe);
            Controls.Add(dataGridViewRecipes);
            Controls.Add(lblSelectRecipe);
            Controls.Add(lblSelectCategory);
            Controls.Add(groupBoxShopList);
            Controls.Add(listViewRecipeCategory);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
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
