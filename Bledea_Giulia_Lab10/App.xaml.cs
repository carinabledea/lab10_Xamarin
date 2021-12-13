using System;
using Bledea_Giulia_Lab10;
using System.IO;
using Xamarin.Forms;
using Bledea_Giulia_Lab10.Data;

namespace Bledea_Giulia_Lab10
{
    public partial class App : Application
    {
        static ShoppingListDatabase database;
        public static ShoppingListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "ShoppingList.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ListEntryPage());
        }
    }

}