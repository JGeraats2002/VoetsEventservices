using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Voets_Eventservices_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExperiencePage : ContentPage
    {
        // Index    Input
        //----------------
        // 0        Title
        // 1        MetaDescription
        // 2        Description
        // 3        Image

        readonly List<List<string>> experiencesList = new List<List<string>> {
            new List<string> { "Sitecrew", "Bouwen, slepen, tillen, niks is te veel!", "Tenten bouwen, vlonders leggen, koelkasten slepen, deco ophangen.. you name it en Voets Eventservices staat voor je klaar.\n\nMet een flexibele instelling, finke dosis doorzettingsvermogen en veel enthousiasme is Voets Eventservices jouw betrouwbare rechterhand.\n\nVoets Eventservices beschikt over een B-rijbewijs en een heftruck certificaat.\n\nGeïnteresseerd in de mogelijkheden?", "sitecrew.webp" },
            new List < string > { "Food and beverage support", "Veel eten verwerken? Daar weet ik wel raad mee!", "Voets Eventservices biedt sterke ondersteuning voor al jouw F&B-support op evenementen en festivals. Met een heftruck certificaat op zak, staan we dag en nacht klaar om je te helpen met alle bijbehorende werkzaamheden. \r\n \r\nOf het nu gaat om het inrichten van een bar of het naadloos coördineren van personeel, Voets Eventservices biedt gepaste services op maat.\r\n\r\n​\r\n\r\nGeïnteresseerd in de mogelijkheden?", "foodandbeveragesupport.webp" },
            new List < string > { "Artist handling", "Geen zin in die riders, laat dat maar aan mij over!", "Van aankomst tot vertrek, Voets Eventservices is jouw partner voor de begeleiding van je artiesten.\r\n\r\n \r\n\r\nOf het nu gaat om het tijdig ophalen van je artiesten op het vliegveld, het voorzien in hun behoeften en comfort zodat ze optimaal presteren op het podium óf het zorgen dat ze op tijd en in stijl weer vertrekken, we regelen het allemaal.\r\n\r\n \r\n\r\nBij Voets Eventservices staat de artiest centraal, en wij staan garant voor een stressvrije en (hopelijk) onvergetelijke ervaring voor zowel de organisatie als de talentvolle gasten.\r\n\r\n​\r\n\r\nGeïnteresseerd in de mogelijkheden?", "artisthandling.webp" },
            new List < string > { "AV support", "Ik zet mezelf graag in de spotlights!", "Als beginnende technicus in de wereld van Audio en Visuele techniek, staat Voets Eventservices klaar om ondersteuning te bieden bij de opbouw van licht en geluid.\r\n\r\n \r\n\r\nOf het nu gaat om trussen monteren, licht- en geluidsapparatuur ophangen, of andere techniek, wij zijn vastbesloten om te leren en te groeien in deze technische wereld.\r\n\r\n​\r\n\r\nGeïnteresseerd in de mogelijkheden?", "avsupport.webp" },
            new List < string > { "Bar support", "Ik drink zelf niet dus je hoeft niet bang te zijn voor fraude!", "Voets Eventservices staat paraat als coördinator voor je bar- of area-management. We zijn de spin in het web als het gaat om het aansturen van medewerkers, het beheren van de drankvoorraad en alle andere klussen die hierbij komen kijken.\r\n\r\n \r\n\r\nWe nemen de leiding in deze dynamische, soms hectische omgeving en zorgen ervoor dat alles zo soepel mogelijk verloopt.\r\n\r\n \r\n\r\nMet Voets Eventservices als coördinator kun je ontspannen en vertrouwen op professionele begeleiding bij het beheren van je bar of area, en dit alles met een lach!\r\n\r\n​\r\n\r\nGeïnteresseerd in de mogelijkheden?", "barsupport.webp" },
            new List < string > { "Transport", "Zolang het maar een moter heeft vind ik het prima!", "Voets Eventservices is jouw betrouwbare partner voor hulp bij het transporteren van goederen en materialen, evenals het laden en lossen ervan. Ons team heeft ruime ervaring in het rijden van lichte transportbussen en we zijn in het bezit van meerdere relevante rijbewijzen en certificaten, waaronder:\r\n\r\n​\r\n\r\n- B rijbewijs\r\n- AM rijbewijs\r\n- Heftruck certificaat\r\n\r\n\r\nMet Voets Eventservices aan je zijde ben je verzekerd van deskundige hulp en vakkundig transport. We staan klaar om de logistieke aspecten van je evenement efficiënt te beheren en te zorgen voor een soepele gang van zaken.\r\n\r\n \r\n\r\nSamen brengen we jouw goederen en materialen precies waar ze moeten zijn.\r\n\r\n​\r\n\r\nGeïnteresseerd in de mogelijkheden?", "transport.webp" },
            new List < string > { "Project management", "\"Doe je best en zet \'m op\", is niet duidelijk genoeg!", "Voets Eventservices beschikt over meerdere jaren aan ervaring en een brede betrokkenheid bij diverse aspecten van evenementen en projecten, wat ons een eigentijdse en creatieve kijk op projectmanagement geeft.\r\n\r\n​\r\n\r\nWij streven ernaar om jouw visie om te zetten in werkelijkheid.\r\n\r\n​\r\n\r\nGeïnteresseerd in de mogelijkheden?", "projectmanagement.webp" },
            new List < string > { "Event management", "Event? \"Even \'t\" welverdiende pauzemomentje!", "Een evenement in gedachten, maar geen idee waar je moet beginnen? Voets Eventservices kan de volledige organisatie van uw evenement zorgeloos uit handen nemen. We bekijken samen wat het doel is van het evenement en gaan daarna aan de slag. Wij zijn up- to date van de tegenwoordige trends en kunnen dus uniek entertainment aanbieden. \r\n\r\n​\r\n\r\nWilt u slechts een gedeelte door ons georganiseerd hebben? Ook dit is mogelijk.  \r\n\r\n​\r\n\r\nGeïnteresseerd in de mogelijkheden?", "eventmanagement.webp" },
            new List < string > { "Stage-hand", "Op zoek naar een stagaire met 2 linker handen?", "Stagehand\r\n\r\nDe stille kracht tijdens uw evenement achter de schermen.\r\n\r\n \r\n\r\nVoets Eventservices biedt assistentie tijdens het maken van opstellingen van apparatuur, decor en technische aspecten, waardoor de artiest zo snel mogelijk kan optreden. Laden en lossen van apparatuur hoort hier ook bij.\r\n\r\n​\r\n\r\nGeïnteresseerd in de mogelijkheden?", "stagehand.webp" },
            new List < string > { "Opdrachten op maat", "Tomaat, klimaat, rolmaat of formaat, \'t maakt mij niet uit maat!", "Hulp nodig bij de uitvoer van een specifiek project of evenement? Voets Eventservices staat open voor verschillende, uiteen lopende werkzaamheden. Een flexibele, actieve en vriendelijke werkhouding staat garant bij Voets Eventservices.\r\n\r\n​\r\n\r\nGeïnteresseerd in de mogelijkheden?", "opdrachtenopmaat.webp" }
        };

        public ExperiencePage()
        {
            InitializeComponent();
            ObservableCollection<Experience> experiences = new ObservableCollection<Experience>();
            for (int i = 0; i < experiencesList.Count(); i++)
            {
                experiences.Add(new Experience
                {
                    Title = experiencesList[i][0],
                    MetaDescription = experiencesList[i][1],
                    Description = experiencesList[i][2],
                    Image = experiencesList[i][3]
                });
            }
            myCollectionView.ItemsSource = experiences;
        }

        private async void myCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                Experience selectedItem = e.CurrentSelection.FirstOrDefault() as Experience;

                if (selectedItem != null)
                {
                   await Navigation.PushAsync(new ExperienceClickedPage(selectedItem));
                }
                
                myCollectionView.SelectedItem = null;
            }
        }
    }
}