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
    public partial class SearchForm : Form
    {
        private Book Book;
        public SearchForm(Book bookInstance)
        {
            InitializeComponent();
            Book = bookInstance;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            grpBoxSearch.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grpBoxSearch.Visible = true;

            string userSearch = txtBoxSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(userSearch))
            {
                MessageBox.Show
                    (
                        "Please enter a Category to search!",
                        "Warning ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1


                    );
                return;
            }

            var getCategories = Book.Recipes.SelectMany(r => r.Categories)
                               .Select(c => c.ToLower()).Distinct().ToList();

            if (!getCategories.Contains(userSearch))
            {
                MessageBox.Show
                (
                    $"'{userSearch}' not found in the recipe organizer. Enter a valid Category",
                    "Error ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );
                grpBoxSearch.Visible = false;
                return;
            }


            var getRecipes = Book.Recipes
                .Where(r => r.Categories.Any(c => c.ToLower().Contains(userSearch)))
                .Select(r => new
                {
                    r.Name,
                    r.Description,
                    r.Ingredients,
                    r.Instructions,
                    r.TotalTime
                }).ToList();

            dataGrdVwSearch.DataSource = getRecipes;

            dataGrdVwSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            grpBoxSearch.Visible = true;
        }
    }
}
