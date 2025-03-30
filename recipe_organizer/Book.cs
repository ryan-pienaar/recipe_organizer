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
                    if (isAlreadyInBook(recipe, false))
                    {
                        continue;
                    }
                    else
                    {
                        Recipes.Add(recipe);
                    }
                }
            }
            else
            {
                Recipe singleRecipe = Newtonsoft.Json.JsonConvert.DeserializeObject<Recipe>(JSONString);
                if (isAlreadyInBook(singleRecipe, true))
                {
                    return;
                }
                Recipes.Add(singleRecipe);
            }
        }

        public void Add(Recipe recipe)
        {
            Recipes.Add(recipe);
        }

        public void Delete(Recipe recipe)
        {
            Recipes.Remove(recipe);
        }

        public bool isAlreadyInBook(Recipe recipe, bool isSingleRecipe)
        {
            if (Recipes.Contains(recipe))
            {
                if (isSingleRecipe)
                {
                    MessageBox.Show("This recipe is already in the book.");
                }
                return true;
            }
            return false;
        }


    }
}
