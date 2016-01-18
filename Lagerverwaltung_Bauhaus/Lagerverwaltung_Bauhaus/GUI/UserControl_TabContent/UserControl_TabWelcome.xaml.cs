using Lagerverwaltung_Bauhaus.Lagerhaltung;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace Lagerverwaltung_Bauhaus
{
    /// <summary>
    /// Interaktionslogik für UserControl_TabWelcome.xaml
    /// Dies ist die Startseite,bis auf einen Test Button ist hier nichst vorhanden.
    /// </summary>
    public partial class UserControl_TabWelcome : UserControl
    {
        public UserControl_TabWelcome()
        {
            InitializeComponent();
            
        }

        //Button zum löschen/zurücksetzen der DB. V.A. für Testzwecke gewesen, oder bei problemen mit db/ db verbindung.
        //Extra mit vielen messageboxen abgesichert....
        private void DB_Kill_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Achtung, dieser Knopf ist zum Löschen der Datenbank. Folgend werden sie zum verlassen oder bestätigen aufgefordert.","INFO",MessageBoxButton.OK,MessageBoxImage.Stop);
            if (MessageBox.Show("Achtung! Bei Programmstart wird die Datenbank zurückgesetzt! Wirklich fortfahren??", "!!!! ACHTUNG !!!!", MessageBoxButton.OKCancel,MessageBoxImage.Warning)== MessageBoxResult.OK)
            {
                Database.SetInitializer(new DropCreateDatabaseAlways<Lagerbestand>()); 
                MessageBox.Show("Die Datenbank wurde zurückgesetzt. ");
            }

            else if ((MessageBox.Show("Der Vorgang wurde abgebrochen.", "Abbruch", MessageBoxButton.OKCancel,MessageBoxImage.Information) == MessageBoxResult.Cancel))
            {

                MessageBox.Show("Vorgang abgebrochen");

            }
        }
    }
}