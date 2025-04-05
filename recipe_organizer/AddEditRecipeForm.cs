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
        private Recipe recipe;
        private bool editMode;

        public AddEditRecipeForm(bool editMode)
        {
            this.editMode = editMode;
            InitializeComponent();
        }

        private void EditRecipe()
        {

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
    }
}
