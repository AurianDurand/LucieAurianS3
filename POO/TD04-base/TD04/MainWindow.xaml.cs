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

namespace TD04
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            IDessert d = null;
            if(crepe.IsChecked==true)
            {
                // on veut une crepe
            }
            else if(gaufre.IsChecked==true)
            {
                // on veut une gaufre
            }
            
            if(chocolat.IsChecked==true)
            {
                // supplément chocolat
            }
            if(sucre.IsChecked==true)
            {
                // supplément sucre
            }
            
            affichage.Text = d.ToString();
        }
    }
}
