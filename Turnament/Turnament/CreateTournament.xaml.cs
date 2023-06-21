using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
using Newtonsoft.Json;
using Turnaments.Models;

namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy CreateTournament.xaml
    /// </summary>
    public partial class CreateTournament : Window
    {
        public CreateTournament()
        {
            InitializeComponent();
        }

        private void BtnClickCreate(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow(); //Trzeba dodać parametr do okna main window z ID turnieju 
            string filePath = @"C:\JSON\turnamentSerialized.json";
            var jsonData = File.ReadAllText(filePath);
            var turnamentList = JsonConvert.DeserializeObject<List< Turnaments.Models.Turnament >> (jsonData)?? new List<Turnaments.Models.Turnament>();
            Turnaments.Models.Turnament turnament = new Turnaments.Models.Turnament()
            {
                Name = CreateTournamentName.Text,
                Id = turnamentList.Count,
                Date = DateTime.Now,
                TeamsNumber = 0,
            };
            turnamentList.Add( turnament );
            string turnamentSerialized = JsonConvert.SerializeObject(turnamentList);
            File.WriteAllText(filePath, turnamentSerialized);
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
