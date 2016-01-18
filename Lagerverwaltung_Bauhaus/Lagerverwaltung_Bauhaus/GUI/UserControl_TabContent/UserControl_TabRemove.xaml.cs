using Lagerverwaltung_Bauhaus.Datenbank;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Lagerverwaltung_Bauhaus
{
    /// <summary>
    /// Interaktionslogik für UserControl_TabRemove.xaml
    /// Hier werden bestehende Getränke und Snacks vom User gewählt und
    /// aus der DB entfernt.
    /// </summary>
    public partial class UserControl_TabRemove : UserControl
    {
        public UserControl_TabRemove()
        {
            InitializeComponent();
        }

        private void button_Remove_Decrease_Snack_Click(object sender, RoutedEventArgs e)
        {
            String saltyDelete = comboBox_Remove_saltySweet.SelectionBoxItem as String;
            String snackAmountDelete = comboBox_Remove_snackAmount.SelectionBoxItem as String;
            String snackArtDelete = comboBox_Remove_snackArt.SelectionBoxItem as String;
            String sStorageLoc = comboBox_Remove_snackStorage.SelectionBoxItem as String;
            String tasteDelete = comboBox_Remove_taste.SelectionBoxItem as String;

            Abfragen loeschenSnacks = new Abfragen();
            loeschenSnacks.snackAusDbLoeschen(snackAmountDelete, tasteDelete, saltyDelete, snackArtDelete, sStorageLoc);
        }

        private void button_Remove_Decrease_Drink_Click(object sender, RoutedEventArgs e)
        {
            String artDelete = comboBox_Remove_drinkArt.SelectionBoxItem as String;
            String alcoholDelete = comboBox_Remove_alcohol.SelectionBoxItem as String;  
            String bSizeDelete = comboBox_Remove_bottleSize.SelectionBoxItem as String; 
            String brandDelete = comboBox_Remove_Brand.SelectionBoxItem as String;
            String drinkAmountDelete = comboBox_Remove_drinkAmount.SelectionBoxItem as String;
            String dStorageLoc = comboBox_Remove_drinkStorageLocation.SelectionBoxItem as String;

            Abfragen loeschenDrinks = new Abfragen();
            loeschenDrinks.getraenkAusDbLoeschen(bSizeDelete, alcoholDelete, drinkAmountDelete, brandDelete, artDelete, dStorageLoc);

        }

    }
}
