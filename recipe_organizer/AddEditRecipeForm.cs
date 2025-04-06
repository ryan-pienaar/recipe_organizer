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
        private string imageEvnironmentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\RecipeOrganizer\\Data\\Images\\";
        private string imageFileName;
        private string selectedImagePath;

        public AddEditRecipeForm(bool editMode, Recipe recipe)
        {
            this.recipe = recipe;
            this.editMode = editMode;
            InitializeComponent();
            if (editMode)
            {
                this.Text = "Edit Recipe";
            }
            else
            {
                this.Text = "Add Recipe";
            }
            EditRecipe();
        }

        public AddEditRecipeForm()
        {
            InitializeComponent();
        }

        private void EditRecipe()
        {
            imageFileName = recipe.PhotoFilePath;
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
            picBoxAddEditImage.Image = Image.FromFile(imageEvnironmentPath + "" + recipe.PhotoFilePath);
            //Make the image fit the picture box
            picBoxAddEditImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAddEditSave_Click(object sender, EventArgs e)
        {

            if (!File.Exists(imageEvnironmentPath + "" + imageFileName))
            {
                File.Copy(selectedImagePath, imageEvnironmentPath + "" + imageFileName);
            }
            recipe.Name = txtAddEditName.Text;
            recipe.Description = rtbAddEditDescription.Text;
            recipe.PhotoFilePath = imageFileName;
            if (!File.Exists(imageEvnironmentPath + "" + imageFileName))
            {
                File.Copy(selectedImagePath, imageEvnironmentPath + "" + imageFileName);
            }
            recipe.PrepTime = (int)nudAddEditPrepTime.Value * 60;
            recipe.CookTime = (int)nudAddEditCookTime.Value * 60;
            recipe.Categories = new List<string>();
            foreach (var item in lbxAddEditCategories.Items)
            {
                recipe.Categories.Add(item.ToString());
            }
            recipe.Servings = (int)nudAddEditServings.Value;
            recipe.Calories = (int)nudAddEditCalories.Value;
            recipe.Instructions = new List<string>();
            foreach (var item in lbxAddEditInstructions.Items)
            {
                if (!string.IsNullOrWhiteSpace(item.ToString()))
                {
                    recipe.Instructions.Add(item.ToString());
                }
            }

            this.Close();
        }

        private void btnAddEditCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEditInstructAdd_Click(object sender, EventArgs e)
        {
            string instruction = Microsoft.VisualBasic.Interaction.InputBox("Enter Instruction", "Add Instruction", "", -1, -1);
            if (!string.IsNullOrWhiteSpace(instruction))
            {
                recipe.Instructions.Add(instruction);
                lbxAddEditInstructions.Items.Add(instruction);
            }
        }

        private void btnAddEditInstructEdit_Click(object sender, EventArgs e)
        {
            object instruction;
            try
            {
                instruction = lbxAddEditInstructions.SelectedItem;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No instruction selected");
                return;
            }

            if (instruction == null)
            {
                MessageBox.Show("No instruction selected");
                return;
            }

            string editInstruction = Microsoft.VisualBasic.Interaction.InputBox("Edit Instruction: " + instruction.ToString(), "Edit Instruction", instruction.ToString(), -1, -1);

            if (!string.IsNullOrWhiteSpace(editInstruction))
            {
                recipe.Instructions.Remove(instruction.ToString());
                recipe.Instructions.Add(editInstruction);
                lbxAddEditInstructions.Items.Remove(lbxAddEditInstructions.SelectedItem);
                lbxAddEditInstructions.Items.Add(editInstruction);
            }


        }

        private void btnAddEditInstructRemove_Click(object sender, EventArgs e)
        {
            try
            {
                recipe.Instructions.Remove(lbxAddEditInstructions.SelectedItem.ToString());
                lbxAddEditInstructions.Items.Remove(lbxAddEditInstructions.SelectedItem);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No instruction selected");
            }
        }

        private void btnAddEditCatAdd_Click(object sender, EventArgs e)
        {
            string category = Microsoft.VisualBasic.Interaction.InputBox("Enter Category", "Add Category", "", -1, -1);
            if (!string.IsNullOrWhiteSpace(category))
            {
                lbxAddEditCategories.Items.Add(category);
            }
        }

        private void btnAddEditCatRemove_Click(object sender, EventArgs e)
        {
            try
            {
                recipe.Categories.Remove(lbxAddEditCategories.SelectedItem.ToString());
                lbxAddEditCategories.Items.Remove(lbxAddEditCategories.SelectedItem);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No category selected");
            }

        }

        private void btnAddEditIngAdd_Click(object sender, EventArgs e)
        {
            string ingredientName = Microsoft.VisualBasic.Interaction.InputBox("Enter Ingredient Name", "Add Ingredient", "", -1, -1);
            string ingredientAmount = Microsoft.VisualBasic.Interaction.InputBox("Enter Ingredient Amount", "Add Ingredient", "", -1, -1);
            string ingredientUnit = Microsoft.VisualBasic.Interaction.InputBox("Enter Ingredient Unit", "Add Ingredient", "", -1, -1);

            if (!string.IsNullOrWhiteSpace(ingredientName) && !string.IsNullOrWhiteSpace(ingredientAmount) && !string.IsNullOrWhiteSpace(ingredientUnit))
            {
                recipe.Ingredients.Add(ingredientName, new string[] { ingredientAmount, ingredientUnit });
                lbxAddEditIngredients.Items.Add(ingredientName + ": " + ingredientAmount + " " + ingredientUnit);
            }
        }

        private void btnAddEditIngRemove_Click(object sender, EventArgs e)
        {
            object ingredientName;
            try
            {
                ingredientName = lbxAddEditIngredients.SelectedItem; 
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("No ingredient selected");
                return;
            }

            if (ingredientName == null)
            {
                MessageBox.Show("No ingredient selected");
                return;
            }

            recipe.Ingredients.Remove(ingredientName.ToString().Split(':')[0]);
            lbxAddEditIngredients.Items.Remove(lbxAddEditIngredients.SelectedItem);
        }

        private void btnAddEditIngEdit_Click(object sender, EventArgs e)
        {
            object ingredientName;
            try
            {
                ingredientName = lbxAddEditIngredients.SelectedItem;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No ingredient selected");
                return;
            }

            if (ingredientName == null)
            {
                MessageBox.Show("No ingredient selected");
                return;
            }

            string[] IngredieantQuantityUnit = recipe.Ingredients[ingredientName.ToString().Split(':')[0]];
            string editIngredientName = Microsoft.VisualBasic.Interaction.InputBox("Edit Ingredient Name: " + ingredientName.ToString().Split(':')[0], "Edit Ingredient", ingredientName.ToString().Split(':')[0], -1, -1);
            string editIngredientAmount = Microsoft.VisualBasic.Interaction.InputBox("Edit Ingredient Amount: " + IngredieantQuantityUnit[0], "Edit Ingredient", IngredieantQuantityUnit[0], -1, -1);
            string editIngredientUnit = Microsoft.VisualBasic.Interaction.InputBox("Edit Ingredient Unit: " + IngredieantQuantityUnit[1], "Edit Ingredient", IngredieantQuantityUnit[1], -1, -1);

            if (!string.IsNullOrWhiteSpace(editIngredientName) && !string.IsNullOrWhiteSpace(editIngredientAmount) && !string.IsNullOrWhiteSpace(editIngredientUnit))
            {
                recipe.Ingredients.Remove(ingredientName.ToString().Split(':')[0]);
                recipe.Ingredients.Add(editIngredientName, new string[] { editIngredientAmount, editIngredientUnit });
                lbxAddEditIngredients.Items.Remove(lbxAddEditIngredients.SelectedItem);
                lbxAddEditIngredients.Items.Add(editIngredientName + ": " + editIngredientAmount + " " + editIngredientUnit);
            }
        }

        private void btnAddEditImageAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                imageFileName = Path.GetFileName(selectedImagePath);
                picBoxAddEditImage.Image = Image.FromFile(selectedImagePath);
                picBoxAddEditImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnAddEditImageRemove_Click(object sender, EventArgs e)
        {
            imageFileName = "temp_image.png";
            selectedImagePath = imageEvnironmentPath + "" + imageFileName;
            picBoxAddEditImage.Image = Image.FromFile(selectedImagePath);
            picBoxAddEditImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
