using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Voets_Eventservices_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExperienceClickedPage : ContentPage
    {
        public ExperienceClickedPage(Experience experience)
        {
            InitializeComponent();
            BindingContext = experience;
        }

        private void ContactButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
        }
    }
}