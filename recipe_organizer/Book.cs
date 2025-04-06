using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace recipe_organizer
{
    public class Book
    {
        public List<Recipe> Recipes { get; set; }
        public Dictionary<DateOnly, Recipe> Planner { get; set; } = new Dictionary<DateOnly, Recipe>();

        public Book() { 
            Recipes = new List<Recipe>();
        }

        public Book(string JSONFilePath)
        {
            ImportRecipes(JSONFilePath);
        }

        public void ImportPlanner(string JSONFilePath)
        {
            string JSONString = System.IO.File.ReadAllText(JSONFilePath);
            Dictionary<DateOnly, Recipe> ImportedPlanner = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<DateOnly, Recipe>>(JSONString);
            foreach (KeyValuePair<DateOnly, Recipe> entry in ImportedPlanner)
            {
                if (Planner.ContainsKey(entry.Key))
                {
                    continue;
                }
                else
                {
                    Planner.Add(entry.Key, entry.Value);
                }
            }
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
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\RecipeOrganizer\\Data\\data.json";
            string json = JsonConvert.SerializeObject(Recipes, Formatting.Indented);
            File.WriteAllText(path, json);
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
