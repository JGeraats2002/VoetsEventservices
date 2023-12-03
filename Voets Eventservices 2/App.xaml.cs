using System;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Voets_Eventservices_2
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();

            //Application.Current.Resources["myFont"] = Device.RuntimePlatform == Device.iOS ? "myFont" : $"#myFont";
            Application.Current.Resources["myFont"] = "#myFont";

            MainPage = new NavigationPage(new WelcomePage());
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
