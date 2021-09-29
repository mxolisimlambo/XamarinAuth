using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Views;
using Xamarin.Helper ;
using Xamarin.ViewModels;
using Xamarin.Data;
using System.IO;

namespace Xamarin
{
    public partial class App : Application
    {
        static NoteDatabase database;

        // Create the database connection as a singleton.
        public static NoteDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new RegisterPage());
            

            SetMainPage();
            //MainPage = new NavigationPage(new RegisterPage());
            //MainPage = new CheapIdeas.MainPage();
        }



        private void SetMainPage()
        {
            if (!string.IsNullOrEmpty(Setting.AccessToken))
            {

                var loginViewModel = new LoginViewModel();
                loginViewModel.LoginCommand.Execute(null);

                MainPage = new NavigationPage(new VehiclePage());
            }
            else if (!string.IsNullOrEmpty(Setting.Username)
                  && !string.IsNullOrEmpty(Setting.Password))
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                MainPage = new NavigationPage(new RegisterPage());
            }
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
