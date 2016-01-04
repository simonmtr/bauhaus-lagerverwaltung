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
            Drinks_dataTableGrid.ItemsSource = myData;//noch zu implementieren
        }

        private void button_Drinks_bar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Drinks_stock_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Drinks_total_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
