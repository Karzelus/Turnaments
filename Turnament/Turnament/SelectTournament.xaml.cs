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
using System.Windows.Shapes;

namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy SelectTournament.xaml
    /// </summary>
    public partial class SelectTournament : Window
    {
        public SelectTournament()
        {
            InitializeComponent();
        }

        private void BtnClickSelect(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow(); //Trzeba dodać parametr do okna main window z ID turnieju 
            mainWindow.Show();        
        }

        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
