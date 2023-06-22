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
    /// Logika interakcji dla klasy EditPlayer.xaml
    /// </summary>
    public partial class EditPlayer : Window
    {
        private Turnaments.Models.Player selectedPlayer;
        private Turnaments.Models.Team team;
        private Turnaments.Models.Turnament turnament;

        public EditPlayer(Turnaments.Models.Player selectedPlayer, Turnaments.Models.Team team, Turnaments.Models.Turnament turnament)
        {
            InitializeComponent();
            this.selectedPlayer = selectedPlayer;
            this.team = team;
            this.turnament = turnament;

            FirstName.Text = selectedPlayer.FirstName;
            LastName.Text = selectedPlayer.LastName;
            Age.Text = selectedPlayer.Age.ToString();
            Number.Text = selectedPlayer.Number.ToString();
        }

        private void BtnClickExitApp(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnClickChangeData(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\JSON\turnamentSerialized.json";
            var jsonData = File.ReadAllText(filePath);
            List<Turnaments.Models.Turnament> turnamentList = JsonConvert.DeserializeObject<List<Turnaments.Models.Turnament>>(jsonData);
            Turnaments.Models.Turnament tournamentToEdit = turnamentList.FirstOrDefault(t => t.Id == this.turnament.Id);
            List<Turnaments.Models.Team> teamList = tournamentToEdit.Teams;
            Turnaments.Models.Team teamToEdit = teamList.FirstOrDefault(t => t.Id == this.team.Id);
            Turnaments.Models.Player playerToEdit = teamToEdit.Players.FirstOrDefault(t => t.Id == this.selectedPlayer.Id);

            if (playerToEdit != null)
            {
                playerToEdit.FirstName = FirstName.Text;
                playerToEdit.LastName = LastName.Text;
                playerToEdit.Age = Convert.ToInt32(Age.Text);
                playerToEdit.Number = Convert.ToInt32(Number.Text);
            }

            string updatedJsonData = JsonConvert.SerializeObject(turnamentList, Formatting.Indented);
            File.WriteAllText(filePath, updatedJsonData);

            Close();
            Player Player = new Player(playerToEdit, this.team, this.turnament);
            Player.Show();
        }
    }
}