using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy AddTeam.xaml
    /// </summary>
    public partial class AddTeam : Page
    {
        private int turnamentID;

        public AddTeam(Turnaments.Models.Turnament turnament)
        {
            InitializeComponent();
            turnamentID = turnament.Id;
        }

        private void BtnClickCreate(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\JSON\turnamentSerialized.json";
            var jsonData = File.ReadAllText(filePath);
            List<Turnaments.Models.Turnament> turnamentList = JsonConvert.DeserializeObject<List<Turnaments.Models.Turnament>>(jsonData);
            Turnaments.Models.Turnament tournamentToEdit = turnamentList.FirstOrDefault(t => t.Id == turnamentID);
            if (tournamentToEdit != null)
            {
                List<Turnaments.Models.Team> teams;
                if (tournamentToEdit.Teams != null)
                {
                    teams = tournamentToEdit.Teams;
                }
                else
                {
                    teams = new List<Turnaments.Models.Team>();
                }

                Turnaments.Models.Team newTeam = new Turnaments.Models.Team()
                {
                    Id = teams.Count,
                    Name = Name.Text,
                    Shortcut = Shortcut.Text,
                };

                teams.Add(newTeam);
                tournamentToEdit.Teams = teams;
                string updatedJsonData = JsonConvert.SerializeObject(turnamentList, Formatting.Indented);
                File.WriteAllText(filePath, updatedJsonData);

                MainWindow mainWindow = new MainWindow(tournamentToEdit.Id);
                mainWindow.Show();
            }
        }

        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
        }
    }
}