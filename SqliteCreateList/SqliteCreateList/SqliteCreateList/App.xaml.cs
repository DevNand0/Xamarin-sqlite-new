using SqliteCreateList.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SqliteCreateList
{
    public partial class App : Application
    {

        private static DataBase database;
        public static DataBase Database 
        {
            get 
            {
                if (database == null) 
                {
                    database = new DataBase(Path.Combine(
                                            Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                                            "myDb.db"));

                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
