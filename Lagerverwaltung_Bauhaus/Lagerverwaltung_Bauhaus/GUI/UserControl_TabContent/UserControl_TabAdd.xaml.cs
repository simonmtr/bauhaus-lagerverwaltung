using Lagerverwaltung_Bauhaus.Datenbank;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Produkte.Getränke;
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
    /// Interaktionslogik für UserControl_TabAdd.xaml
    /// </summary>
    public partial class UserControl_TabAdd : UserControl
    {
        public UserControl_TabAdd()
        {
            InitializeComponent();
        }

        private void button_Add_Increase_Drink_Click(object sender, RoutedEventArgs e)
        {
            String artInput = comboBox_Add_drinkArt.SelectionBoxItem as String;
            String alcoholInput = comboBox_Add_alcohol.SelectionBoxItem as String; //muss noch in bool gecastet werden
            String bSizeInput = comboBox_Add_bottleSize.SelectionBoxItem as String;//muss noch in double gecastet werden
            String brandInput = comboBox_Add_Brand.SelectionBoxItem as String;
            String drinkAmountInput = comboBox_Add_drinkAmount.SelectionBoxItem as String; //muss noch in int gecastet werden
            String dStorageLoc = comboBox_Add_drinkStorageLocation.SelectionBoxItem as String;

            Abfragen auswahlGetraenke = new Abfragen();
            auswahlGetraenke.getraenkZuDbHinzufuegen(bSizeInput, alcoholInput, drinkAmountInput, brandInput, artInput, dStorageLoc);
        }

        private void button_Add_Increase_Snack_Click(object sender, RoutedEventArgs e)
        {
            String saltyInput = comboBox_Add_saltySweet.SelectionBoxItem as String;
            String snackAmountInput = comboBox_Add_snackAmount.SelectionBoxItem as String;
            String snackArtInput = comboBox_Add_snackArt.SelectionBoxItem as String;
            String sStorageLoc = comboBox_Add_snackStorage.SelectionBoxItem as String;
            String tasteInput = comboBox_Add_taste.SelectionBoxItem as String;

            Abfragen auswahlSnacks = new Abfragen();
            auswahlSnacks.snackZuDbHinzufuegen(snackAmountInput, tasteInput, saltyInput, snackArtInput, sStorageLoc);//tasteInput statt name

        }
    }
}

