using Lagerverwaltung_Bauhaus.Datenbank;
using Lagerverwaltung_Bauhaus.Lagerhaltung.Orte;
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

        private void button_Add_Increase_Click(object sender, RoutedEventArgs e)
        {
        
            String input = comboBox_Add_Art.SelectionBoxItem as String;
           // ....
            Abfragen bauhausApp = new Abfragen();
            bauhausApp.getraenkZuDbHinzufuegen(0.5, true, 2, input, ENUMgetraenkeArt.getraenkeArt.Bier, ENUMLagerort.Lagerort.Bar);

            MessageBox.Show("Erfolgreich hinzugefügt");
        }
    }
    }

