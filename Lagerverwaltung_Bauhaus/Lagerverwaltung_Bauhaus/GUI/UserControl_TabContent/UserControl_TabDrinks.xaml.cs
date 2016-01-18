using Lagerverwaltung_Bauhaus.Datenbank;
using System.Windows;
using System.Windows.Controls;

namespace Lagerverwaltung_Bauhaus
{
    /// <summary>
    /// Interaktionslogik für UserControl_TabDrinks.xaml
    /// Hier wird nach betätigen eines Buttons der Jeweilige / ganze 
    /// Lagerbesetand im dataGrid angezeigt.
    /// </summary>
    public partial class UserControl_TabDrinks : UserControl
    {
        public UserControl_TabDrinks()
        {
            InitializeComponent();
        }

        private void button_Drinks_fridge_Click(object sender, RoutedEventArgs e)
        {
            Abfragen thekeAbfrage = new Abfragen();
            var getraenkeListe = thekeAbfrage.getThekeGetraenke();
            Drinks_dataTableGrid.ItemsSource = getraenkeListe;
        }

        private void button_Drinks_bar_Click(object sender, RoutedEventArgs e)
        {
            Abfragen barAbfragen = new Abfragen();
            var getraenkeListe = barAbfragen.getBarGetraenke();
            Drinks_dataTableGrid.ItemsSource = getraenkeListe;
           
        }

        private void button_Drinks_stock_Click(object sender, RoutedEventArgs e)
        {
            Abfragen lagerAbfragen = new Abfragen();
            var getraenkeListe = lagerAbfragen.getLagerGetraenke();
            Drinks_dataTableGrid.ItemsSource = getraenkeListe;
                       
        }

        private void button_Drinks_total_Click(object sender, RoutedEventArgs e)
        {
            Abfragen gesamtAbfrage = new Abfragen();
            var getraenkeListe = gesamtAbfrage.getGesamtGetraenke();
            Drinks_dataTableGrid.ItemsSource = getraenkeListe;

        }
    }
}
