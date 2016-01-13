using Lagerverwaltung_Bauhaus.Datenbank;
using Lagerverwaltung_Bauhaus.Lagerhaltung;
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

namespace Lagerverwaltung_Bauhaus
{
    /// <summary>
    /// Interaktionslogik für UserControl_TabDrinks.xaml
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

            //using (var db = new Lagerbestand())
            //{
            //    var query = from b in db.Getraenks where b.enumLagerort == ENUMLagerort.Lagerort.Theke select b;

            //    Drinks_dataTableGrid.ItemsSource = query.ToList();
            //}
        }

        private void button_Drinks_bar_Click(object sender, RoutedEventArgs e)
        {
            Abfragen barAbfragen = new Abfragen();
            var getraenkeListe = barAbfragen.getBarGetraenke();
            Drinks_dataTableGrid.ItemsSource = getraenkeListe;

            //    using (var db = new Lagerbestand())
            //    {
            //        var query = from b in db.Getraenks where b.enumLagerort == ENUMLagerort.Lagerort.Bar select b;
            //        Drinks_dataTableGrid.ItemsSource = query.ToList();
            //    }
        }

        private void button_Drinks_stock_Click(object sender, RoutedEventArgs e)
        {
            Abfragen lagerAbfragen = new Abfragen();
            var getraenkeListe = lagerAbfragen.getLagerGetraenke();
            Drinks_dataTableGrid.ItemsSource = getraenkeListe;

            //using (var db = new Lagerbestand())
            //{
            //    var query = from b in db.Getraenks where b.enumLagerort == ENUMLagerort.Lagerort.Lager select b;
            //    Drinks_dataTableGrid.ItemsSource = query.ToList();
            //}




        }

        private void button_Drinks_total_Click(object sender, RoutedEventArgs e)
        {
            Abfragen gesamtAbfrage = new Abfragen();
            var getraenkeListe = gesamtAbfrage.getGesamtGetraenke();
            Drinks_dataTableGrid.ItemsSource = getraenkeListe;

            //using (var db = new Lagerbestand())
            //{
            //    var query = from b in db.Getraenks select b;

            //    Drinks_dataTableGrid.ItemsSource = query.ToList();
            //}

        }
    }
}
