using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Voets_Eventservices_2
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            dateToday.Text = DateTime.Now.Date.ToShortDateString();
        }
    }
}
