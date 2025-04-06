using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_organizer
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoFilePath { get; set; }
        public double PrepTime { get; set; }
        public double CookTime { get; set; }
        public int TotalTime { get { return (int)(PrepTime + CookTime); } }
        public List<string> Categories { get; set; }
        public int Servings { get; set; }
        public int Calories { get; set; }
        public Dictionary<string, string[]> Ingredients { get; set; }
        public List<string> Instructions { get; set; }

        public Recipe(string name, string description, string photoFilePath, double prepTime, double cookTime, List<string> categories, int servings, int calories, Dictionary<string, string[]> ingredients, List<string> instructions)
        {
            Name = name;
            Description = description;
            PhotoFilePath = photoFilePath;
            PrepTime = prepTime;
            CookTime = cookTime;
            Categories = categories;
            Servings = servings;
            Calories = calories;
            Ingredients = ingredients;
            Instructions = instructions;
        }

        public Recipe()
        {
            Name = "";
            Description = "";
            PhotoFilePath = "temp_image.png";
            PrepTime = 0;
            CookTime = 0;
            Categories = new List<string>();
            Servings = 0;
            Calories = 0;
            Ingredients = new Dictionary<string, string[]>();
            Instructions = new List<string>();
        }
    }
}
