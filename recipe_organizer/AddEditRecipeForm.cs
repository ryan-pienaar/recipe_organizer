using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recipe_organizer
{
    public partial class AddEditRecipeForm : Form
    {
        private Recipe recipe = new Recipe();
        private bool editMode = false;
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\RecipeOrganizer";

        public AddEditRecipeForm(bool editMode, Recipe recipe)
        {
            this.recipe = recipe;
            this.editMode = editMode;
            InitializeComponent();
            if (editMode)
            {
                this.Text = "Edit Recipe";
                EditRecipe();
            }
            else
            {
                this.Text = "Add Recipe";
                AddRecipe();
            }
        }

        public AddEditRecipeForm()
        {
            InitializeComponent();
        }

        private void EditRecipe()
        {
            txtAddEditName.Text = recipe.Name;
            rtbAddEditDescription.Text = recipe.Description;
            nudAddEditPrepTime.Value = (int)recipe.PrepTime / 60;
            nudAddEditCookTime.Value = (int)recipe.CookTime / 60;
            nudAddEditServings.Value = recipe.Servings;
            nudAddEditCalories.Value = recipe.Calories;
            foreach (var ingredient in recipe.Ingredients)
            {
                lbxAddEditIngredients.Items.Add(ingredient.Key + ": " + string.Join(" ", ingredient.Value));
            }
            foreach (var category in recipe.Categories)
            {
                lbxAddEditCategories.Items.Add(category);
            }
            foreach (var instruction in recipe.Instructions)
            {
                lbxAddEditInstructions.Items.Add(instruction);
            }
            picBoxAddEditImage.Image = Image.FromFile(path + "\\Data\\Images\\temp_image.png");
            //Make the image fit the picture box
            picBoxAddEditImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void AddRecipe()
        {
            Recipe newRecipe = new Recipe();
            newRecipe.Name = txtAddEditName.Text;
            newRecipe.Description = rtbAddEditDescription.Text;
            //newRecipe.PhotoFilePath = TODO: Open file dialog to select photo
            newRecipe.PrepTime = (int)nudAddEditPrepTime.Value * 60;
            newRecipe.CookTime = (int)nudAddEditCookTime.Value * 60;
            newRecipe.Categories = new List<string>();
            foreach (var item in lbxAddEditCategories.Items)
            {
                newRecipe.Categories.Add(item.ToString());
            }
            newRecipe.Servings = (int)nudAddEditServings.Value;
            newRecipe.Calories = (int)nudAddEditCalories.Value;
            //newRecipe.Ingredients = new Dictionary<string, string[]>();
            //TODO: Add ingredients with a form
            newRecipe.Instructions = new List<string>();
            foreach (var item in lbxAddEditInstructions.Items)
            {
                if (!string.IsNullOrWhiteSpace(item.ToString()))
                {
                    newRecipe.Instructions.Add(item.ToString());
                }
            }
        }

        private void btnAddEditSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddEditCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEditInstructAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddEditInstructEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEditInstructRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEditCatAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEditCatRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEditIngAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEditIngRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEditIngEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEditImageAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddEditImageRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
