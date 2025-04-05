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
    public partial class Planner : Form
    {
        public Dictionary<DateTime, List<string>> mealPlanner = new Dictionary<DateTime, List<string>>();  // ✅ Now accessible!

        public DateTimePicker DateTimePickerPlanner;
        private Book recipeBook;
        public Planner(Book bookInstance)
        {
            InitializeComponent();
            recipeBook = bookInstance;

        }

        private void btnViewMeals_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerPlanner.Value.Date;

            if (mealPlanner == null)
            {
                MessageBox.Show("Error: Meal planner is not initialized.");
                return;
            }

            if (mealPlanner.ContainsKey(selectedDate))
            {
                List<string> plannedMeals = mealPlanner[selectedDate];

                if (plannedMeals != null && plannedMeals.Count > 0) 
                {
                    rchTxtBoxPlanner.Text = $"You've planned to make " + string.Join("\n", plannedMeals) + " today!"; 
                }
                else
                {
                    rchTxtBoxPlanner.Text = "No meals planned for this date.";
                }
            }
            else
            {
                rchTxtBoxPlanner.Text = "No meals stored yet!";
            }
        }

        private void btnAddMeals_Click(object sender, EventArgs e)
        {
            List<string> storedRecipes = recipeBook.Recipes.Select(r => r.Name).ToList();  // ✅ Retrieve recipe names
            AddMealsToPlanner mealForm = new AddMealsToPlanner(this, storedRecipes);  // ✅ Pass Planner & Recipes
            mealForm.Show();
        }
    }
}
