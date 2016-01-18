using Lagerverwaltung_Bauhaus.Datenbank;
using System.Windows;
using System.Windows.Controls;

namespace Lagerverwaltung_Bauhaus
{
    /// <summary>
    /// Interaktionslogik für UserControl_TabSnacks.xaml
    /// Hier wird nach betätigen eines Buttons der Jeweilige 
    /// Lagerbesetand im dataGrid angezeigt.
    /// </summary>
    public partial class UserControl_TabSnacks : UserControl
    {
        public UserControl_TabSnacks()
        {
            InitializeComponent();
        }

        private void button_Snacks_Sweet_Click(object sender, RoutedEventArgs e)
        {
            Abfragen suessAbfrage = new Abfragen();
            var snackListe = suessAbfrage.getSuessSnacks();
            snacks_DataGrid.ItemsSource = snackListe;

        }

        private void button_Snacks_Salt_Click(object sender, RoutedEventArgs e)
        {
            Abfragen salzAbfrage = new Abfragen();
            var snackListe = salzAbfrage.getSalzSnacks();
            snacks_DataGrid.ItemsSource = snackListe;
            
        }
    }
}
