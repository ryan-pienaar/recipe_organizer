using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_organizer
{
    internal class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double PrepTime { get; set; }
        public double CookTime { get; set; }
        public int TotalTime { get { return (int)(PrepTime + CookTime); } }
        public string Category { get; set; }
        public int Servings { get; set; }
        public int Calories { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Instructions { get; set; }

        public Recipe(string name, string description, double prepTime, double cookTime, string category, int servings, int calories, List<string> ingredients, List<string> instructions)
        {
            Name = name;
            Description = description;
            PrepTime = prepTime;
            CookTime = cookTime;
            Category = category;
            Servings = servings;
            Calories = calories;
            Ingredients = ingredients;
            Instructions = instructions;
        }

        public Recipe()
        {
            Name = "";
            Description = "";
            PrepTime = 0;
            CookTime = 0;
            Category = "";
            Servings = 0;
            Calories = 0;
            Ingredients = new List<string>();
            Instructions = new List<string>();
        }
    }
}
