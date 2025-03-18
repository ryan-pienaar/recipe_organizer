namespace recipe_organizer
{
    public partial class MainWindow : Form
    {

        Book Book = new Book();

        public MainWindow()
        {
            InitializeComponent();
            SetUpData();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn viewButtonCol = new DataGridViewButtonColumn();
            DataGridViewButtonColumn editButtonCol = new DataGridViewButtonColumn();
            DataGridViewButtonColumn deleteButtonCol = new DataGridViewButtonColumn();

            viewButtonCol.HeaderText = "";
            editButtonCol.HeaderText = "";
            deleteButtonCol.HeaderText = "";

            viewButtonCol.UseColumnTextForButtonValue = true;
            editButtonCol.UseColumnTextForButtonValue = true;
            deleteButtonCol.UseColumnTextForButtonValue = true;

            viewButtonCol.Text = "View";
            editButtonCol.Text = "Edit";
            deleteButtonCol.Text = "Delete";

            //.DataSource = Book.Recipes.ToList();
            var recipeViewList = Book.Recipes.OrderBy(n => n.Name).Select(n => new { 
                n.Name, 
                n.Description, 
                n.TotalTime 
            }).ToList();
            dataGridViewRecipes.DataSource = recipeViewList;

            dataGridViewRecipes.Columns.Add(viewButtonCol);
            dataGridViewRecipes.Columns.Add(editButtonCol);
            dataGridViewRecipes.Columns.Add(deleteButtonCol);
        }

        private void SetUpData()
        {
            List<string> categories_ex_1 = new List<string>();
            categories_ex_1.Add("Pasta");
            categories_ex_1.Add("Italian");
            List<string> ingredients_ex_1 = new List<string>();
            ingredients_ex_1.Add("Pancetta");
            ingredients_ex_1.Add("Spaghetti");
            ingredients_ex_1.Add("Whipping Cream");
            ingredients_ex_1.Add("Parmesan");
            List<string> instructions_ex_1 = new List<string>();
            instructions_ex_1.Add("Prep it");
            instructions_ex_1.Add("Cook it");
            instructions_ex_1.Add("Eat it");
            Recipe recipe_ex_1 = new Recipe("Carbonara", "Pasta Carbonara made with cream", "C:/test.png", 600, 300, categories_ex_1, 2, 1100, ingredients_ex_1, instructions_ex_1);

            List<string> categories_ex_2 = new List<string>();
            categories_ex_2.Add("Toasted");
            categories_ex_2.Add("Comfort");
            List<string> ingredients_ex_2 = new List<string>();
            ingredients_ex_2.Add("Bread");
            ingredients_ex_2.Add("Sliced Ham");
            ingredients_ex_2.Add("Cheddar Cheese");
            List<string> instructions_ex_2 = new List<string>();
            instructions_ex_2.Add("Prep it");
            instructions_ex_2.Add("Cook it");
            instructions_ex_2.Add("Eat it");
            Recipe recipe_ex_2 = new Recipe("Toasted Hame & Cheese", "Ham & Cheese the right way", "C:/test.png", 200, 500, categories_ex_2, 1, 600, ingredients_ex_2, instructions_ex_2);

            List<string> categories_ex_3 = new List<string>();
            categories_ex_3.Add("Pizza");
            categories_ex_3.Add("Italian");
            List<string> ingredients_ex_3 = new List<string>();
            ingredients_ex_3.Add("Pizza Dough");
            ingredients_ex_3.Add("Chicken");
            ingredients_ex_3.Add("BBQ Sauce");
            ingredients_ex_3.Add("Pepperoni");
            List<string> instructions_ex_3 = new List<string>();
            instructions_ex_3.Add("Prep it");
            instructions_ex_3.Add("Cook it");
            instructions_ex_3.Add("Eat it");
            Recipe recipe_ex_3 = new Recipe("BBQ Chicken Pizza", "BBQ Chicken pizza made the right way", "C:/test.png", 30000, 360, categories_ex_1, 2, 1200, ingredients_ex_1, instructions_ex_1);

            Book.Add(recipe_ex_1);
            Book.Add(recipe_ex_2);
            Book.Add(recipe_ex_3);
        }
    }
}
