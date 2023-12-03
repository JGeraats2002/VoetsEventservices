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
    public partial class AboutPage : ContentPage
    {
        string aboutMe = "Hi,\r\nMy name is Lennie Voets.\r\nI am the founder of Voets Eventservices. \r\nAnd let me tell you something about myself.\r\n\r\nFor years my passion has been developing and implementing projects within the events industry. Before this started to feel like a passion, I was very interested in the profession. That's how I studied Media and Events.\r\n\r\nAfterwards I gained a lot of work experience in different places and at a variety of companies. From meetings to festivals, from weddings to company contact days, it all happened in my work. The step into the professional world was therefore close. I dared to take that leap into the deep. That's why I started Voets Eventservices. This is where my passion and my strength lie. I hope to be able to share this with everyone. Whether it concerns work in front of the scenes or behind the scenes. It remains the most beautiful profession there is.";
        string extra = "Beste Lennie,\r\nWat jij toch af en toe allemaal doet, da ken nie.\r\n\r\nLaten we beginnen over het fucken van het systeem,\r\nJe poetst namelijk alles met Torkrol en Glassex i.p.v. een sopje en zeem.\r\n\r\nRare fratsen met debarrasseren bij de gasten,\r\nOf 10.000L verf verspillen en wat kwasten.\r\n\r\n“Eigenwijs is ook wijs” is een van je uitspraken,\r\nWanneer gaan die hersenen van jou nou eens zelf kraken.\r\n\r\nHopelijk vanaf 1 januari als het ZZP’en begint,\r\nWord je dan eindelijk volwassen of blijf jij altijd een klein kind.\r\n\r\nKun jij daarom zo goed overweg met Maarten en Loek,\r\nOf moet je naar nog jongeren kinderen op zoek.\r\n\r\nIk zet je niet weg als pedofiel of kinderoppas,\r\nZe zijn zó jong, ze lijken wel van jou ras.\r\n\r\nKinderen van jezelf wil jij absoluut niet,\r\nGoed nieuws voor jou, dit gaat ook niet lukken zonder griet.\r\n\r\nGa nou eens grondig op pad,\r\nMisschien heb je de juist allang eens gehad.\r\n\r\nDan heb ik het over Kiki of die meid in Denemarken,\r\nDoe eens je best om die binnen te harken.\r\n\r\nAls dat je niet wil lukken,\r\nMoet je misschien eens proberen om voor een kerel te bukken.\r\n\r\nWellicht valt het andere geslacht je beter in de smaak,\r\nDit kan in het begin wel kramp geven aan je kaak.\r\n\r\nZitten er daarom soms vlekken op je sloof?\r\nZe zeggen wel eens: “Van pijpen word je doof”,\r\n\r\nMaar die uitspraak heb jij nog nooit gehoord,\r\nWant jou gezicht wordt dagelijks doorboord.\r\n\r\nAlle gekkigheid op een stokje,\r\nOf je nu een broek draagt of een rokje.\r\n\r\nJe bent een fantastische vent,\r\nEn blijf lekker jezelf, dat zijn we gewend.\r\n\r\nDat is de mooiste Lennie die we kennen,\r\nLaat ik je nu maar eens verwennen.\r\n\r\nPak snel uit die cadeaus,\r\nAnders wordt de kerstman nog boos.\r\n\r\nLennie veel plezier en succes met je zaak,\r\nHopelijk zien we je nog vaak.\r\n\r\nOnbekende groetjes van: …...\r\n";
        public AboutPage()
        {
            InitializeComponent();
            AboutMeLabel.Text = aboutMe;
            ExtraLabel.Text = extra;
        }
    }
}