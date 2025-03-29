using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace recipe_organizer
{
    public partial class MainWindow : Form
    {

        Book Book = new Book();

        public MainWindow(string JSONData)
        {
            InitializeComponent();
            SetUpData(JSONData);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn viewButtonCol = new DataGridViewButtonColumn();
            DataGridViewButtonColumn editButtonCol = new DataGridViewButtonColumn();
            DataGridViewButtonColumn deleteButtonCol = new DataGridViewButtonColumn();
            DataGridViewButtonColumn addToPlannerButtonCol = new DataGridViewButtonColumn();

            viewButtonCol.HeaderText = "";
            editButtonCol.HeaderText = "";
            deleteButtonCol.HeaderText = "";
            addToPlannerButtonCol.HeaderText = "";

            viewButtonCol.UseColumnTextForButtonValue = true;
            editButtonCol.UseColumnTextForButtonValue = true;
            deleteButtonCol.UseColumnTextForButtonValue = true;
            addToPlannerButtonCol.UseColumnTextForButtonValue = true;

            viewButtonCol.Text = "View";
            editButtonCol.Text = "Edit";
            deleteButtonCol.Text = "Delete";
            addToPlannerButtonCol.Text = "Add to Planner";

            //.DataSource = Book.Recipes.ToList();
            var recipeViewList = Book.Recipes.OrderBy(n => n.Name).Select(n => new
            {
                n.Name,
                n.Description,
                n.TotalTime
            }).ToList();
            dataGridViewRecipes.DataSource = recipeViewList;

            dataGridViewRecipes.Columns.Add(viewButtonCol);
            dataGridViewRecipes.Columns.Add(editButtonCol);
            dataGridViewRecipes.Columns.Add(deleteButtonCol);
            dataGridViewRecipes.Columns.Add(addToPlannerButtonCol);
        }

        private void SetUpData(string JSONData)
        {
            //List<string> categories_ex_1 = new List<string>();
            //categories_ex_1.Add("Pasta");
            //categories_ex_1.Add("Italian");
            //Dictionary<string, string[]> ingredients_ex_1 = new Dictionary<string, string[]>();
            //ingredients_ex_1.Add("Pancetta", ["170", "g"]);
            //ingredients_ex_1.Add("Spaghetti", ["225", "g"]);
            //ingredients_ex_1.Add("Whipping Cream", ["484", "ml"]);
            //ingredients_ex_1.Add("Egg Yolk", ["2", ""]);
            //ingredients_ex_1.Add("Parmesan Cheese", ["150", "g"]);
            //ingredients_ex_1.Add("Black Pepper", ["1", "tsp"]);
            //ingredients_ex_1.Add("Basil", ["4", "tbs"]);
            //List<string> instructions_ex_1 = new List<string>();
            //instructions_ex_1.Add("Bring a large pot of salted water to boil over high heat. Add the pasta and cook according to package instructions. Drain and set aside.");
            //instructions_ex_1.Add("Add the pancetta to a large skillet and saute over medium-low heat until crisp, about 8 minutes. Transfer the pancetta to a bowl using a slotted spoon.");
            //instructions_ex_1.Add("Add the half and half to the skillet and bring to a simmer. Whisk the egg yolks into the sauce. Whisk in the Parmesan cheese. Stir in the black pepper. Taste for salt and season if needed. I find no salt is needed since the cheese adds plenty of saltiness.");
            //instructions_ex_1.Add("Add the cooked spaghetti, bacon and basil to the skillet and toss well to combine.");
            //instructions_ex_1.Add("Serve immediately with additional Parmesan cheese and black pepper.");
            //Recipe recipe_ex_1 = new Recipe("Carbonara", "Pasta Carbonara made with cream", "C:/test.png", 600, 300, categories_ex_1, 4, 1100, ingredients_ex_1, instructions_ex_1);

            //Book.Add(recipe_ex_1);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\RecipeOrganizer\\Data\\data.json";
            Book.ImportRecipes(path);
        }

        //Save recipe data on window closure
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\RecipeOrganizer\\Data\\data.json";
            string json = JsonConvert.SerializeObject(Book.Recipes, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        private void dataGridViewRecipes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            const int viewIndex = 3;
            const int editIndex = 4;
            const int deleteIndex = 5;
            const int plannerIndex = 6;

            string? recipeName = dataGridViewRecipes.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (e.ColumnIndex == viewIndex)
            {
                MessageBox.Show("Viewing the recipe: " + recipeName);
            }

            if (e.ColumnIndex == editIndex)
            {
                MessageBox.Show("Editing the recipe: " + recipeName);
            }

            if (e.ColumnIndex == deleteIndex)
            {
                MessageBox.Show("Deleting the recipe: " + recipeName);
            }

            if (e.ColumnIndex == plannerIndex)
            {
                MessageBox.Show("Planning the recipe: " + recipeName);
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opens a file dialog to select a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            openFileDialog.Title = "Select a JSON file to import";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\RecipeOrganizer\\Export\\";
            string selectedFilePath = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                //MessageBox.Show("Selected file: " + selectedFilePath);
            }
            Book.ImportRecipes(selectedFilePath);
            var recipeViewList = Book.Recipes.OrderBy(n => n.Name).Select(n => new
            {
                n.Name,
                n.Description,
                n.TotalTime
            }).ToList();
            dataGridViewRecipes.DataSource = recipeViewList;
        }

        private void OpenFileDialog_FileOk(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void singleRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void allRecipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(Book.Recipes, Formatting.Indented);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\RecipeOrganizer\\Export\\ExportedRecipes-" + getFileIDString() + ".json";
            File.WriteAllText(path, json);
        }

        private string getFileIDString()
        {
            DateTime dateTimeNow = System.DateTime.Now;
            string fileDate = dateTimeNow.ToShortDateString();
            string fileTime = dateTimeNow.ToShortTimeString();
            fileDate = fileDate.Replace("/", "-");
            fileTime = fileTime.Replace(":", "");

            return fileDate + "-" + fileTime;
        }

        private void btnGenShoppingList_Click(object sender, EventArgs e)
        {
            rtbShopList.Text = "";
            string selectedRecipe = "";
            try
            {
                selectedRecipe = dataGridViewRecipes.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a recipe to generate a shopping list.");
                return;
            }

            Recipe recipe = Book.Recipes.Find(r => r.Name == selectedRecipe);

            foreach (KeyValuePair<string, string[]> ingredient in recipe.Ingredients)
            {
                rtbShopList.Text += ingredient.Key + " - " + ingredient.Value[0] + " " + ingredient.Value[1] + "\n";
            }
        }

        private void btnSaveShopList_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.Title = "Select a Text file to save to";
            string selectedFilePath = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = saveFileDialog.FileName;
                //MessageBox.Show("Selected file: " + selectedFilePath);
            }

            if (selectedFilePath == "")
            {
                return;
            }

            if (rtbShopList.Text != "")
            {
                File.WriteAllText(selectedFilePath, rtbShopList.Text);
            }
            else
            {
                MessageBox.Show("No shopping list to save.");
            }
                
        }
    }
}
