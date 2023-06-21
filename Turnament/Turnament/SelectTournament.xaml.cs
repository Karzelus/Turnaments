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
using Turnaments.Models;
using Newtonsoft.Json;
using System.IO;

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
            string filePath = @"C:\JSON\turnamentSerialized.json";
            var jsonData = File.ReadAllText(filePath);
            List<Turnaments.Models.Turnament> turnamentList = JsonConvert.DeserializeObject<List<Turnaments.Models.Turnament>>(jsonData);
            Tournaments.ItemsSource = turnamentList;
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
        private void BtnClickExitApp(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
