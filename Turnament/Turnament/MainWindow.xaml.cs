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
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;
using System.IO;

namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Turnaments.Models.Turnament matchingTurnament;
        public MainWindow(int selectedId)
        {
            InitializeComponent();
            LoadGrid();
            string filePath = @"C:\JSON\turnamentSerialized.json";
            var jsonData = File.ReadAllText(filePath);
            List<Turnaments.Models.Turnament> turnamentList = JsonConvert.DeserializeObject<List<Turnaments.Models.Turnament>>(jsonData);
            matchingTurnament= turnamentList.FirstOrDefault(t => t.Id == selectedId);
        }
        public MainWindow()
        {
            InitializeComponent();
            LoadGrid();
        }
        public void LoadGrid()
        {
            //Dane.ItemsSource = dt.DefaultView;
        }

        private void BtnClickBracket(object sender, RoutedEventArgs e)
        {
            Main.Content = new Drabinka(matchingTurnament);
        }

        private void BtnClickRanking(object sender, RoutedEventArgs e)
        {
            Main.Content = new Ranking(matchingTurnament);
        }

        private void BtnClickTeams(object sender, RoutedEventArgs e)
        {
            Main.Content = new Teams(matchingTurnament);
        }

        private void BtnClickHistory(object sender, RoutedEventArgs e)
        {
            Main.Content = new History(matchingTurnament);
        }

        private void BtnClickReferee(object sender, RoutedEventArgs e)
        {
            Main.Content = new Referee(matchingTurnament);
        }

        private void BtnClickRename(object sender, RoutedEventArgs e)
        {
            Main.Content = new Rename(matchingTurnament);
        }
        
        private void BtnClickAddTeams(object sender, RoutedEventArgs e)
        {
            Main.Content = new AddTeam(matchingTurnament);
        }

        private void BtnClickAddReferee(object sender, RoutedEventArgs e)
        {
            Main.Content = new AddReferee(matchingTurnament);
        }


        private void BtnClickDeleteTournament(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\JSON\turnamentSerialized.json";
            var jsonData = File.ReadAllText(filePath);
            List<Turnaments.Models.Turnament> tournamentList = JsonConvert.DeserializeObject<List<Turnaments.Models.Turnament>>(jsonData);
            tournamentList.RemoveAll(tournament => tournament.Id == matchingTurnament.Id);
            string updatedJsonData = JsonConvert.SerializeObject(tournamentList, Formatting.Indented);
            File.WriteAllText(filePath, updatedJsonData);
            Menu menu = new Menu();
            this.Close();
            menu.Show();

        }
        private void BtnClickExitApp(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void BtnClickExitTournament(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show();

        }
    }
}