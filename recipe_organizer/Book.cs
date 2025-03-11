using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_organizer
{
    internal class Book
    {
        public List<Recipe> recipes { get; set; }

        public Book() { }

        public Book(string JSONFilePath)
        {
            ImportRecipes(JSONFilePath);
        }

        public void ImportRecipes(string JSONFilePath)
        {
            //TODO : Import recipes from JSON file into list<Recipe> recipes
        }


    }
}
