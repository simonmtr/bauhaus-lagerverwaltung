using Lagerverwaltung_Bauhaus.Lagerhaltung;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Lagerverwaltung_Bauhaus
{
    /// <summary>
    /// Interaktionslogik für UserControl_TabWelcome.xaml
    /// </summary>
    public partial class UserControl_TabWelcome : UserControl
    {
        public UserControl_TabWelcome()
        {
            InitializeComponent();
            //Database.SetInitializer<Lagerbestand>(null);
        }

        private void DB_Kill_Click(object sender, RoutedEventArgs e)
        {
            //DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNoCancel);
            //if (result == DialogResult.Yes)
            //{
            //    //...
            //}
            //else if (result == DialogResult.No)

            //MessageBox.Show("Datenbank gelöscht");
            //Database.SetInitializer(new DropCreateDatabaseAlways<Lagerbestand>()); <- die 2 zeilen hier funktionieren


           // MessageBox.Show("Achtung! Bei Programmstart wird die Datenbank zurückgesetzt! Wirklich fortfahren?", "!!!! ACHTUNG !!!!", MessageBoxButton.OKCancel, MessageBoxImage.Question);

            if (MessageBox.Show("DB wirklich löschen?", "!!!! ACHTUNG !!!!", MessageBoxButton.OKCancel)== MessageBoxResult.OK)
            {
                Database.SetInitializer(new DropCreateDatabaseAlways<Lagerbestand>()); 
                MessageBox.Show("Die Datenbank wurde zurückgesetzt. ");
            }

            else if ((MessageBox.Show("Der Vorgang wurde abgebrochen.", "Abbruch", MessageBoxButton.OKCancel) == MessageBoxResult.Cancel))
            {

                MessageBox.Show("Operation abgebrochen");

            }
        }
    }
}