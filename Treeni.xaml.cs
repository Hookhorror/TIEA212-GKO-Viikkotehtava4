using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Viikkotehtava4
{
    /// <summary>
    /// Interaction logic for Treeni.xaml
    /// </summary>
    public partial class Treeni : UserControl
    {
        //private double matka;
        //private TimeSpan aika = new TimeSpan(01, 00, 00);
        private double nopeus;


        // nimeäminen tehtävä juuri seuraavalla tavalla
        public static readonly DependencyProperty MatkaProperty =
         DependencyProperty.Register(
           "Matka",
           typeof(double), // propertyn tietotyyppi
           typeof(Treeni), // luokka jossa property sijaitsee
           new FrameworkPropertyMetadata(0.0,  // propertyn oletusarvo EI OSAA MUUTTAA 0:aa DOUBLEKSI
                FrameworkPropertyMetadataOptions.AffectsRender, // vaikuttaa luokan ulkoasuun (textbox päivittyy)
                new PropertyChangedCallback(OnValueChanged),  // kutsutaan propertyn arvon muuttumisen jälkeen
                new CoerceValueCallback(MuutaMatkaa))); // kutsutaan ennen propertyn arvon muutosta

        // seuraavat tehtävä juuri näin. Ei mitään tarkistuksien lisäämistä
        public double Matka
        {
            get { return (double)GetValue(MatkaProperty); }
            set { SetValue(MatkaProperty, value); }
        }

        // tätä kutsutaan ennen laskurin muuttamista ja voidaan tässä vaiheessa
        // tehdä tarkistuksia ja muuttaa laskuriin asetettavaa arvoa
        private static object MuutaMatkaa(DependencyObject element, object value)
        {
            double luku = 0;
            try
            {
                luku = (double)value;
                if (luku < 0) value = 0.0;
            }
            catch
            {
                luku = 0;
            }
            //double luku = (double)value;
            //if (luku < 0) value = 0.0;

            return luku;
        }

        // Laskuria on muutettu. Päivitetään tieto myös textboxiin
        // parempi olisi bindata textbox tähän propertyyn:
        // {Binding ElementName=IkkunanNimi, Path=Laskuri}
        private static void OnValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            //Treeni o = (Treeni)obj;
            //o.textBoxMatka.Text = (Convert.ToDouble(o.textBoxMatka.Text)).ToString();
        }

        // nimeäminen tehtävä juuri seuraavalla tavalla
        public static readonly DependencyProperty AikaProperty =
         DependencyProperty.Register(
           "Aika",
           typeof(TimeSpan), // propertyn tietotyyppi
           typeof(Treeni), // luokka jossa property sijaitsee
           new FrameworkPropertyMetadata(new TimeSpan(00, 00, 00),  // propertyn oletusarvo
                FrameworkPropertyMetadataOptions.AffectsRender, // vaikuttaa luokan ulkoasuun (textbox päivittyy)
                new PropertyChangedCallback(OnValueChanged),  // kutsutaan propertyn arvon muuttumisen jälkeen
                new CoerceValueCallback(MuutaAikaa))); // kutsutaan ennen propertyn arvon muutosta

        // seuraavat tehtävä juuri näin. Ei mitään tarkistuksien lisäämistä
        public TimeSpan Aika
        {
            get { return (TimeSpan)GetValue(AikaProperty); }
            set { SetValue(AikaProperty, value); }
        }

        // tätä kutsutaan ennen laskurin muuttamista ja voidaan tässä vaiheessa
        // tehdä tarkistuksia ja muuttaa laskuriin asetettavaa arvoa
        private static object MuutaAikaa(DependencyObject element, object value)
        {
            TimeSpan aika = (TimeSpan)value;
            //if (aika < 0) value = 0;

            return aika;
        }


        public Treeni()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Käsittelee laske -napin painalluksen, ja laskee nopeuden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLaske_Click(object sender, RoutedEventArgs e)
        {
            nopeus = Matka / Aika.TotalHours;
            labelNopeus.Content = String.Format("{0:0.00} km/h", nopeus);
        }
    }
}
