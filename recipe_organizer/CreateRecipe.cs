using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace recipe_organizer
{
    public partial class CreateRecipe : Form
    {
        private MainForm mainForm;
        private Book recipeBook;
        public CreateRecipe(MainForm createNewRecipeForm, Book bookInstance)
        {
            InitializeComponent();
            mainForm = createNewRecipeForm;
            recipeBook = bookInstance;
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            foreach (TextBox box in new[] { txtBoxPrepTime, txtBoxCookTime, txtBoxServings, txtBoxCalories })
                box.Text = string.IsNullOrWhiteSpace(box.Text) ? "0" : box.Text;

            string recipeName = txtBoxName.Text.Trim();
            string recipeDescription = rchTxtBoxDescription.Text.Trim();
            string photoFilePath = txtBoxImg.Text.Trim();

            double recipePrepTime = double.Parse(txtBoxPrepTime.Text);
            double recipeCookTime = double.Parse(txtBoxCookTime.Text);
            double recipeTotalTime = recipePrepTime + recipeCookTime;
            int recipeServings = int.Parse(txtBoxServings.Text);
            int recipeCalories = int.Parse(txtBoxCalories.Text);

            txtBoxTotalTime.Text = recipeTotalTime.ToString();





            List<string> lstrecipeCategories = txtBoxCategory.Text.Split(',')
            .Select(c => c.Trim()).ToList();


            List<string> lstrecipeIngredients = new List<string>(rchTxtBoxIngredients.Lines
            .Select(i => i.Trim()));

            Dictionary<string, string[]> formattedIngredients = lstrecipeIngredients
            .ToDictionary(ingredient => ingredient, ingredient => new string[] { "" });


            List<string> lstrecipeInstructions = rchTxtBoxInstructions.Lines
            .Select(i => i.Trim()).ToList();

            Recipe newRecipe = new Recipe(recipeName,
                                          recipeDescription,
                                          photoFilePath,
                                          recipePrepTime,
                                          recipeCookTime,
                                          lstrecipeCategories,
                                          recipeServings,
                                          recipeCalories,
                                          formattedIngredients,
                                          lstrecipeInstructions);
            recipeBook.Add(newRecipe);


            (Application.OpenForms["MainForm"] as MainForm)?.RefreshDataGrid();

            MessageBox.Show($"Recipe '{recipeName}' added successfully!");
        }

        private void UpdateTotalTime()
        {
            double prepTime = double.Parse(txtBoxPrepTime.Text);
            double cookTime = double.Parse(txtBoxCookTime.Text);

            txtBoxTotalTime.Text = (prepTime + cookTime).ToString();
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPrepTime_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalTime();
        }

        private void txtBoxCookTime_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalTime();
        }

        private void txtBoxTotalTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateRecipe_Load(object sender, EventArgs e)
        {

        }
    }
}
