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


            var result = MessageBox.Show("DB wirklich löschen?", "caption", MessageBoxButton.OKCancel, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Database.SetInitializer<Lagerbestand>(null);

            }

            else if (result == MessageBoxResult.Cancel)
            {

                MessageBox.Show("Operation abgebrochen");

            }
        }
    }
}