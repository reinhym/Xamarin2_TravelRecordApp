using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin2_TravelRecordApp
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;

        public App()
        {
            InitializeComponent();

            MainPage = new Xamarin.Forms.NavigationPage(new LoginPage());
        }

        public App(string databaseLocation) : this()
        {
            DatabaseLocation = databaseLocation;
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
