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
    /// Interaktionslogik für UserControl_TabSnacks.xaml
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

            //using (var db = new Lagerbestand())
            //{
            //    var query = from b in db.Snackss where b.enumSnack == ENUMsnackArt.suess select b;
            //    snacks_DataGrid.ItemsSource = query.ToList();
            //}

        }

        private void button_Snacks_Salt_Click(object sender, RoutedEventArgs e)
        {
            Abfragen salzAbfrage = new Abfragen();
            var snackListe = salzAbfrage.getSalzSnacks();
            snacks_DataGrid.ItemsSource = snackListe;

            //using (var db = new Lagerbestand())
            //{
            //    var query = from b in db.Snackss where b.enumSnack == ENUMsnackArt.salzig select b;
            //    snacks_DataGrid.ItemsSource = query.ToList();
            //}
        }
    }
}
//private void button_Drinks_fridge_Click(object sender, RoutedEventArgs e)
//{
//    // Abfragen thekeAbfrage = new Abfragen();
//    // var getraenkeListe = thekeAbfrage.getThekeGetraenke();
//    //Drinks_dataTableGrid.ItemsSource = getraenkeListe;

//    using (var db = new Lagerbestand())
//    {
//        var query = from b in db.Getraenks where b.enumLagerort == ENUMLagerort.Lagerort.Theke select b;

//        Drinks_dataTableGrid.ItemsSource = query.ToList();
//    }
//}