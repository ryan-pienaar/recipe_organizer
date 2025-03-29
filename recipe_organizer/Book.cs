using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace recipe_organizer
{
    internal class Book
    {
        public List<Recipe> Recipes { get; set; }

        public Book() { 
            Recipes = new List<Recipe>();
        }

        public Book(string JSONFilePath)
        {
            ImportRecipes(JSONFilePath);
        }

        public void ImportRecipes(string JSONFilePath)
        {
            string JSONString = System.IO.File.ReadAllText(JSONFilePath);
            if (JSONString.TrimStart().StartsWith("["))
            {
                List<Recipe> ImportedRecipes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Recipe>>(JSONString);
                foreach (Recipe recipe in ImportedRecipes)
                {
                    Recipes.Add(recipe);
                }
            }
            else
            {
                Recipe singleRecipe = Newtonsoft.Json.JsonConvert.DeserializeObject<Recipe>(JSONString);
                Recipes.Add(singleRecipe);
            }
        }

        public void Add(Recipe recipe)
        {
            Recipes.Add(recipe);
        }


    }
}
