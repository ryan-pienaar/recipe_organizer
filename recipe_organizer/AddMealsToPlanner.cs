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
    public partial class AddMealsToPlanner : Form
    {
        private Planner mainPlanner;
        private List<string> availableRecipes;

        public AddMealsToPlanner(Planner planner, List<string> recipes)
        {
            InitializeComponent();
            mainPlanner = planner;
            availableRecipes = recipes;
            cmbBoxAddToPlanner.Items.AddRange(recipes.ToArray());
        }

        private void btnAddToPlanner_Click(object sender, EventArgs e)
        {
            string selectedRecipe = cmbBoxAddToPlanner.SelectedItem?.ToString();
            DateTime selectedDate = dateTimePickerAddToPlanner.Value.Date;


            if (!string.IsNullOrEmpty(selectedRecipe))
            {
                if (!mainPlanner.mealPlanner.ContainsKey(selectedDate))
                {
                    mainPlanner.mealPlanner[selectedDate] = new List<string>();

                    mainPlanner.mealPlanner[selectedDate].Add(selectedRecipe);
                    MessageBox.Show(
                                    $"{selectedRecipe} added for {selectedDate.ToShortDateString()}!",
                                    "Meal Added to Planner ",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.None,
                                    MessageBoxDefaultButton.Button1
                                    );
                }
            }

        
        }
    }
}
