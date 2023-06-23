using Newtonsoft.Json;
using System;
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
using Turnaments.Models;

namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy Team.xaml
    /// </summary>
    public partial class Team : Window
    {
        private Turnaments.Models.Team team;
        private Turnaments.Models.Turnament turnament;

        public Team(Turnaments.Models.Team selectedTeam, Turnaments.Models.Turnament turnament)
        {
            InitializeComponent();

            string filePath = @"C:\JSON\turnamentSerialized.json";
            var jsonData = File.ReadAllText(filePath);
            List<Turnaments.Models.Turnament> turnamentList = JsonConvert.DeserializeObject<List<Turnaments.Models.Turnament>>(jsonData);
            this.turnament = turnamentList.FirstOrDefault(t => t.Id == turnament.Id);
            this.team = this.turnament.Teams.Where(t => t.Id == selectedTeam.Id).FirstOrDefault();

            TeamName.Text = selectedTeam.Name;
            Name.Text = selectedTeam.Name;
            Shortcut.Text = selectedTeam.Shortcut;
            VictoryNumber.Text = selectedTeam.VictoryNumber.ToString();
            LossesNumber.Text = selectedTeam.LossesNumber.ToString();
            LostGoals.Text = selectedTeam.LostGoals.ToString();
            ScoredGoals.Text = selectedTeam.ScoredGoals.ToString();

            PlayersListView.ItemsSource = team.Players;
        }

        private void BtnClickSelect(object sender, RoutedEventArgs e)
        {
            Turnaments.Models.Player selectedPlayer = PlayersListView.SelectedItem as Turnaments.Models.Player;
            if (selectedPlayer != null)
            {
                Close();
                Player player = new Player(selectedPlayer, this.team, this.turnament);
                player.Show();
            }
        }

        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnClickExitApp(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnClickAddPlayer(object sender, RoutedEventArgs e)
        {
            Close();
            AddPlayer addPlayer = new AddPlayer(this.team, this.turnament);
            addPlayer.Show();
        }
    }
}