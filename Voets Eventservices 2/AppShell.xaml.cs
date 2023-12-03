using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Voets_Eventservices_2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void OnLougoutButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new WelcomePage());
            Navigation.PopToRootAsync();
        }
    }
}
