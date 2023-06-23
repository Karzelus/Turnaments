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

namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy AddPlayer.xaml
    /// </summary>
    public partial class AddPlayer : Window
    {
        private Turnaments.Models.Turnament turnament;
        private Turnaments.Models.Team team;

        public AddPlayer(Turnaments.Models.Team selectedTeam, Turnaments.Models.Turnament turnament)
        {
            InitializeComponent();
            this.turnament = turnament;
            this.team = selectedTeam;
        }

        private void BtnClickCreate(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\JSON\turnamentSerialized.json";
            var jsonData = File.ReadAllText(filePath);

            List<Turnaments.Models.Turnament> turnamentList = JsonConvert.DeserializeObject<List<Turnaments.Models.Turnament>>(jsonData);
            Turnaments.Models.Turnament tournamentToEdit = turnamentList.FirstOrDefault(t => t.Id == this.turnament.Id);

            if (tournamentToEdit != null)
            {
                Turnaments.Models.Team editTeam = tournamentToEdit.Teams.FirstOrDefault(t => t.Id == this.team.Id);
                List<Turnaments.Models.Player> players = new List<Turnaments.Models.Player>();
                int maxId = 0;
                if (editTeam.Players != null)
                {
                    players = editTeam.Players;
                    maxId = editTeam.Players.Max(p => p.Id);
                }

                Turnaments.Models.Player newPlayer = new Turnaments.Models.Player()
                {
                    Id = maxId + 1,
                    FirstName = FirstNameValue.Text,
                    LastName = LastNameValue.Text,
                    Age = Convert.ToInt32(AgeValue.Text),
                    Number = maxId + 1
                };

                players.Add(newPlayer);
                editTeam.Players = players;

                string updatedJsonData = JsonConvert.SerializeObject(turnamentList, Formatting.Indented);
                File.WriteAllText(filePath, updatedJsonData);

                Close();
                Team team = new Team(this.team, this.turnament);
                team.Show();
            }
        }

        private void BtnClickExitApp(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}