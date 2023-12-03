using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Voets_Eventservices_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        private void addressButton_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.google.com/maps/place/Reewoude+90,+6075+NK+Herkenbosch"));
        }

        private void phoneButton_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:+31651028361"));
        }

        private void mailButton_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("mailto:info@voetseventservices.nl"));
        }

        private void websiteButton_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.voetseventservices.nl/"));
        }
    }
}