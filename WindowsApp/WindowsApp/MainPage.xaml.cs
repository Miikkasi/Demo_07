using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WindowsApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Leveys_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {

        }

        private void Nappula_Click(object sender, RoutedEventArgs e)
        {
            //Haetaan käyttäjän syöttämät luvut ja muutetaan ne inteistä stringeiksi
            string leveysString = Leveys_syote.Text;
            int leveys = int.Parse(leveysString);

            
            string korkeusString = Korkeus_syote.Text;
            int korkeus = int.Parse(korkeusString);
           
            string karmiString = Karminleveys_syote.Text;
            int karmi = int.Parse(karmiString);

            //Lasketaan karmin piiri
            int karpiiri = 2 * (korkeus + leveys) / 10;

            //Lasketaan ikkunan pinta-ala
            int lasilaske = (leveys * korkeus) / 10;

            //Lasketaan lasin pinta-ala
            int laske = (leveys - (2 * karmi)) * (korkeus - (2 * karmi)) / 10;

            Karminpiiri_vastaus.Text = karpiiri.ToString() + " cm";
            Ikkunanpintaala_vastaus.Text = lasilaske.ToString() + " cm^2";
            Lasinpintaala_vastaus.Text = laske.ToString() + " cm^2";
        }
    }
}
