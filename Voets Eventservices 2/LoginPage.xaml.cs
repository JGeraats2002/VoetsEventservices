using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.WebRequestMethods;

namespace Voets_Eventservices_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string companyName = CompanyNameEntry.Text;
            string password = PasswordEntry.Text;

            // Perform authentication logic here
            // You can check credentials, call an authentication service, etc.
            bool isAuthenticated = AuthenticateUser(companyName, password);

            // Comment in or out to be able to login automaticly or with the correct password
            //isAuthenticated = true;

            if (isAuthenticated)
            {
                // Navigate to the main page or another relevant page
                // For example, using NavigationPage:
                Application.Current.MainPage = new AppShell();
            }
            else
            {
                DisplayAlert("Authentication Failed", "Invalid credentials. Please try again.", "OK");
            }
        }

        private bool AuthenticateUser(string companyName, string password)
        {
            // Implement your authentication logic here
            // For example, you might compare the entered credentials with a predefined set
            // or make a call to an authentication service.

            // For demonstration purposes, this example always returns true.
            // In a real-world scenario, replace this with your actual authentication logic.
            if (companyName == null || password == null)
            {
                return false;
            }
            else if (companyName.ToLower().Trim().Equals("Voets Eventservices".ToLower()) && password.Equals("3a4BLeNnIeV3nt$"))
            {
                return true;
            }
            return false;
        }

        private void ShowHideButton_Clicked(object sender, EventArgs e)
        {
            PasswordEntry.IsPassword = !PasswordEntry.IsPassword;

            // Change the image source based on the password visibility state
            ShowHideButton.Source = PasswordEntry.IsPassword ? "show.png" : "hide.png";
        }
    }
}