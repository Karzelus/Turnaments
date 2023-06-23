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
using Newtonsoft.Json;
using Turnaments.Models;
using System.IO;
namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy PlayGame.xaml
    /// </summary>
    public partial class PlayGame : Window
    {
        Turnaments.Models.Team Team1;
        Turnaments.Models.Team Team2;
        Turnaments.Models.Turnament validTurnament;
        Turnaments.Models.Game Game;
        public string Winner;
        public event EventHandler SaveButtonClicked;
        string filePath = @"C:\JSON\turnamentSerialized.json";

        public PlayGame(Turnaments.Models.Team team1, Turnaments.Models.Team team2, Turnaments.Models.Turnament validTurnament)
        {
            InitializeComponent();
            Team1 = team1;
            Team2 = team2;
            this.validTurnament = validTurnament;

            List<Turnaments.Models.Game> gameList = validTurnament.Games;
            int maxId = gameList.Max(game => game.Id);
            Game = new Game()
            {
                FirstTeamID = Team1.Id,
                SecondTeamID = Team2.Id,
                Id = maxId + 1,
                FirstTeamGoals = 0,
                SecondTeamGoals = 0,
            };
            Team1Players.ItemsSource = team1.Players;
            Team2Players.ItemsSource = team2.Players;
            Referees.ItemsSource=validTurnament.Referees;
            TeamGoals2.Text = Game.SecondTeamGoals.ToString();
            TeamGoals1.Text= Game.FirstTeamGoals.ToString();
            FirstTeamName.Text = team1.Name;
            SecondTeamName.Text = team2.Name;
        }
        //Turnament.Models Player
        private void BtnClickExitApp(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnClickTeam1Score(object sender, RoutedEventArgs e)
        {
            Turnaments.Models.Player selectedPlayer = Team1Players.SelectedItem as Turnaments.Models.Player;
            if (selectedPlayer != null)
            {
                selectedPlayer.NumberOfGoals++;
                Game.FirstTeamGoals++;
                TeamGoals1.Text = Game.FirstTeamGoals.ToString();
            }
        }

        private void BtnClickTeam2Score(object sender, RoutedEventArgs e)
        {
            Turnaments.Models.Player selectedPlayer = Team2Players.SelectedItem as Turnaments.Models.Player;
            if (selectedPlayer != null)
            {
                selectedPlayer.NumberOfGoals++;
                Game.SecondTeamGoals++;
                TeamGoals2.Text = Game.SecondTeamGoals.ToString();
            }
            
        }
        private void BtnClickDontSave(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnClickSave(object sender, RoutedEventArgs e)
        {
            Turnaments.Models.Referee selectedReferee = Referees.SelectedItem as Turnaments.Models.Referee;
            if (selectedReferee != null) Game.RefereeID = selectedReferee.Id;
            else Game.RefereeID = 0;
            string filePath = @"C:\JSON\turnamentSerialized.json";
            var jsonData = File.ReadAllText(filePath);
            List<Turnaments.Models.Turnament> turnamentList = JsonConvert.DeserializeObject<List<Turnaments.Models.Turnament>>(jsonData);
            Turnaments.Models.Turnament tournamentToEdit = turnamentList.FirstOrDefault(t => t.Id == validTurnament.Id);
            tournamentToEdit.Games.Add(Game);
            Turnaments.Models.Team teamToEdit1=tournamentToEdit.Teams.FirstOrDefault(t=>t.Name==Team1.Name);
            Turnaments.Models.Team teamToEdit2 =tournamentToEdit.Teams.FirstOrDefault(t => t.Name == Team2.Name);
            teamToEdit1.LostGoals += Game.SecondTeamGoals;
            teamToEdit1.ScoredGoals += Game.FirstTeamGoals;
            teamToEdit2.LostGoals += Game.SecondTeamGoals;
            teamToEdit2.ScoredGoals += Game.FirstTeamGoals;

            if (Game.SecondTeamGoals!=Game.FirstTeamGoals)
            {
                if (Game.SecondTeamGoals > Game.FirstTeamGoals)
                {
                    Game.Winner = Team2.Name;
                    teamToEdit2.VictoryNumber++;
                    teamToEdit1.LossesNumber++;
                }
                else
                {
                    Game.Winner = Team1.Name;
                    teamToEdit1.VictoryNumber++;
                    teamToEdit2.LossesNumber++;
                }                    
                Winner = Game.Winner;
                string updatedJsonData = JsonConvert.SerializeObject(turnamentList, Formatting.Indented);
                File.WriteAllText(filePath, updatedJsonData);
            }
            SaveButtonClicked?.Invoke(this, EventArgs.Empty);
            Close();
    }

        private void InformationListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
