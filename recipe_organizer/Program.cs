namespace recipe_organizer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Dynamically create a new RecipeOrganizer folder in the users Documents folder with Data and Export subfolders
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\RecipeOrganizer";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Directory.CreateDirectory(path + "\\Data");
                Directory.CreateDirectory(path + "\\Export");
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());

            
        }
    }
}