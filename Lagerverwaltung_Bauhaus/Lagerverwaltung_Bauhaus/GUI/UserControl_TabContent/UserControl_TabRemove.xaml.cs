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
using Lagerverwaltung_Bauhaus.Datenbank;

namespace Lagerverwaltung_Bauhaus
{
    /// <summary>
    /// Interaktionslogik für UserControl_TabRemove.xaml
    /// </summary>
    public partial class UserControl_TabRemove : UserControl
    {
        public UserControl_TabRemove()
        {
            InitializeComponent();
        }

        private void button_Remove_Decrease_Snack_Click(object sender, RoutedEventArgs e)
        {
            //String saltyDelete = comboBox_Remove_saltySweet.SelectionBoxItem as String;
            String snackAmountDelete = comboBox_Remove_snackAmount.SelectionBoxItem as String;
            String snackArtDelete = comboBox_Remove_snackArt.SelectionBoxItem as String;
            String sStorageLoc = comboBox_Remove_snackStorage.SelectionBoxItem as String;
            //String tasteDelete = comboBox_Remove_taste.SelectionBoxItem as String;

            Abfragen loeschenSnacks = new Abfragen();
            loeschenSnacks.snackAusDbLoeschen(snackArtDelete, snackAmountDelete, sStorageLoc); // muss noch in die entfernen klasse , wenn das geht,ansonsten raus damit^^
        }

        private void button_Remove_Decrease_Drink_Click(object sender, RoutedEventArgs e)
        {
            //String artDelete = comboBox_Remove_drinkArt.SelectionBoxItem as String;
            // String alcoholDelete = comboBox_Remove_alcohol.SelectionBoxItem as String;  //muss noch in bool gecastet werden
            //String bSizeDelete = comboBox_Remove_bottleSize.SelectionBoxItem as String; //muss noch in double gecastet werden
            String brandDelete = comboBox_Remove_Brand.SelectionBoxItem as String;
            String drinkAmountDelete = comboBox_Remove_drinkAmount.SelectionBoxItem as String; //muss noch in int gecastet werden
            String dStorageLoc = comboBox_Remove_drinkStorageLocation.SelectionBoxItem as String;

            Abfragen loeschenDrinks = new Abfragen();
            loeschenDrinks.getraenkAusDbLoeschen(brandDelete, drinkAmountDelete, dStorageLoc); // muss noch in die entfernen klasse , wenn das geht,ansonsten raus damit^^

        }



        //private void button_Remove_Decrease_Click(object sender, RoutedEventArgs e)
        //{

        //    String delete = comboBox_Remove_Art.SelectionBoxItem as String;
        //    Abfragen BhApp = new Abfragen();
        //    BhApp.getraenkAusDbLoeschen(delete);
        //}
    }
}
