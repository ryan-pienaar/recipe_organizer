using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recipe_organizer
{
    public partial class ViewForm : Form
    {
        private Recipe recipe;
        private string imageEvnironmentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\RecipeOrganizer\\Data\\Images\\";

        public ViewForm(Recipe recipe)
        {
            InitializeComponent();
            this.recipe = recipe;
            if (File.Exists(imageEvnironmentPath + recipe.PhotoFilePath))
            {
                picBoxView.Image = Image.FromFile(imageEvnironmentPath + recipe.PhotoFilePath);
            }
            else
            {
                picBoxView.Image = Image.FromFile(imageEvnironmentPath + "temp_image.png");
            }
            picBoxView.SizeMode = PictureBoxSizeMode.StretchImage;
            lblViewRecipeNameHere.Text = recipe.Name;
            rtbViewDescription.Text = recipe.Description;
            lblViewPrepTime.Text = lblViewPrepTime.Text + recipe.PrepTime.ToString() + " minutes";
            lblViewCookTime.Text = lblViewCookTime.Text + recipe.CookTime.ToString() + " minutes";
            lblViewServings.Text = lblViewServings.Text + recipe.Servings.ToString();
            lblViewCalories.Text = lblViewCalories.Text + recipe.Calories.ToString() + " calories (kcal)";
            foreach (var ingredient in recipe.Ingredients)
            {
                rtbViewIngredients.Text += (ingredient.Key + ": " + string.Join(" ", ingredient.Value) + "\n");
            }
            int count = 1;
            foreach (var instruction in recipe.Instructions)
            {
                rtbViewInstructions.Text += (count + ". " + instruction + "\n\n");
                count++;
            }
        }
    }
}
