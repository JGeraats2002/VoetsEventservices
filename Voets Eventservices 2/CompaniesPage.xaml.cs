using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.WebRequestMethods;

namespace Voets_Eventservices_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompaniesPage : ContentPage
    {
        List<List<string>> companyNames = new List<List<string>>
        {
            new List<string> { "Games_XL.png", "https://www.games-xl.com/en/" },
            new List<string> { "Degreez.png", "https://www.degreez.nl"},
            new List<string> { "Rebirth_events.png", "https://shop.rebirth-festival.nl/"},
            new List<string> { "Mojo.png", "https://www.mojo.nl/"},
        };
        public CompaniesPage()
        {
            InitializeComponent();
            ObservableCollection<Company> companies = new ObservableCollection<Company>();
            companies = AddCompaniesToCollection(companies);
            myCollectionView.ItemsSource = companies;
        }

        private ObservableCollection<Company> AddCompaniesToCollection(ObservableCollection<Company> companies)
        {
            for (int i = 0; i < companyNames.Count; i++)
            {
                Company company = new Company()
                {
                    Image = companyNames[i][0],
                    URL = companyNames[i][1]
                };
                companies.Add(company);
            }
            return companies;
        }
        private void myCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                Company selectedItem = e.CurrentSelection.FirstOrDefault() as Company;

                if (selectedItem != null)
                {
                    Device.OpenUri(new Uri(selectedItem.URL));
                }

                myCollectionView.SelectedItem = null;
            }
        }
    }
}