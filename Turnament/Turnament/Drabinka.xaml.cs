using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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
using System.IO;
using Newtonsoft.Json;
using Turnament.Models;

namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy Drabinka.xaml
    /// </summary>
    public partial class Drabinka : Page
    {
        Turnaments.Models.Turnament turnament;
        private List<bool> canSelectTeams = new List<bool>();
        public event PropertyChangedEventHandler PropertyChanged;
        public string Winner1, Winner2, Winner3, Winner4, Winner5, Winner6, Winner7;
        List<Turnaments.Models.Team> lockedTeams = new List<Turnaments.Models.Team>();
        string filePath;


        public void SaveToFile(string filePath)
        {
            filePath = @"C:\JSON\turnamentTemp" + turnament.Id + ".json";
        BracketState bracketState = new BracketState()
            {
                turnamentId = turnament.Id,
                Winner1= Winner1,
                Winner2= Winner2,
                Winner3= Winner3,
                Winner4= Winner4,
                Winner5= Winner5,
                Winner6= Winner6,
                Winner7= Winner7,
                canSelectTeams= canSelectTeams,
            };
            string json = JsonConvert.SerializeObject(bracketState);
            File.WriteAllText(filePath, json);
        }
        public BracketState LoadFromFile()
        {
            filePath = @"C:\JSON\turnamentTemp" + turnament.Id + ".json";
             string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<BracketState>(json);
        }

        public Drabinka(Turnaments.Models.Turnament turnament)
        {
            InitializeComponent();
            this.turnament = turnament;
            teamsComboBox1.ItemsSource = turnament.Teams;
            teamsComboBox2.ItemsSource = turnament.Teams;
            teamsComboBox3.ItemsSource = turnament.Teams;
            teamsComboBox4.ItemsSource = turnament.Teams;
            teamsComboBox5.ItemsSource = turnament.Teams;
            teamsComboBox6.ItemsSource = turnament.Teams;
            teamsComboBox7.ItemsSource = turnament.Teams;
            teamsComboBox8.ItemsSource = turnament.Teams;
            for (int i = 0; i < turnament.Teams.Count; i++)
            {
                canSelectTeams.Add(true);
            }
            filePath = @"C:\JSON\turnamentTemp" + turnament.Id + ".json";
            if (File.Exists(filePath))
            {
                if (LoadFromFile() != null)
                {
                    BracketState bracketState = LoadFromFile();
                    this.Winner1 = bracketState.Winner1;
                    this.Winner2 = bracketState.Winner2;
                    this.Winner3 = bracketState.Winner3;
                    this.Winner4 = bracketState.Winner4;
                    this.Winner5 = bracketState.Winner5;
                    this.Winner6 = bracketState.Winner6;
                    this.Winner7 = bracketState.Winner7;
                    this.canSelectTeams = bracketState.canSelectTeams;
                    for (int i = 0; i <= 7; i++)
                    {
                        //if (canSelectTeams[i] == false) lockedTeams.Add(turnament.Teams[i]);
                    }
                    teamTextBox1.Text = Winner1;
                    teamTextBox2.Text = Winner2;
                    teamTextBox3.Text = Winner3;
                    teamTextBox4.Text = Winner4;
                    teamTextBox5.Text = Winner5;
                    teamTextBox6.Text = Winner6;
                    teamTextBox7.Text = Winner7;
                }
            }
            DataContext = this;
        }
        
        private void BtnClickPlayFirst1_4(object sender, RoutedEventArgs e)
        {
            if (teamsComboBox1.SelectedItem != null && teamsComboBox2.SelectedItem != null && teamsComboBox1.SelectedItem != teamsComboBox2.SelectedItem)
            {
                Turnaments.Models.Team selectedTeam1 = teamsComboBox1.SelectedItem as Turnaments.Models.Team;
                Turnaments.Models.Team selectedTeam2 = teamsComboBox2.SelectedItem as Turnaments.Models.Team;
                if (!IsTeamLocked(selectedTeam1) && !IsTeamLocked(selectedTeam2))
                {
                    PlayGame playGame = new PlayGame(selectedTeam1, selectedTeam2, turnament);
                    playGame.SaveButtonClicked += (s, args) =>
                    {
                     
                        canSelectTeams[0] = false;
                        canSelectTeams[1] = false;
                        lockedTeams.Add(selectedTeam1);
                        lockedTeams.Add(selectedTeam2);
                        Winner1 = playGame.Winner;
                        teamTextBox1.Text = Winner1;
                        OnPropertyChanged(nameof(CanSelectTeams));
                        SaveToFile(filePath);
                        UpdateComboBoxesEnabledState();
                    };
                    playGame.ShowDialog();
                }
            }
        }
        private void UpdateComboBoxesEnabledState()
        {
            teamsComboBox1.IsEnabled = canSelectTeams[0];
            teamsComboBox2.IsEnabled = canSelectTeams[1];
            teamsComboBox3.IsEnabled = canSelectTeams[2];
            teamsComboBox4.IsEnabled = canSelectTeams[3];
            teamsComboBox5.IsEnabled = canSelectTeams[4];
            teamsComboBox6.IsEnabled = canSelectTeams[5];
            teamsComboBox7.IsEnabled = canSelectTeams[6];
            teamsComboBox8.IsEnabled = canSelectTeams[7];
        }
        private bool IsTeamLocked(Turnaments.Models.Team team)
        {
            return lockedTeams.Contains(team);
        }

        private void BtnClickPlaySecond1_4(object sender, RoutedEventArgs e)
        {
            if (teamsComboBox3.SelectedItem != null && teamsComboBox4.SelectedItem != null && teamsComboBox3.SelectedItem != teamsComboBox4.SelectedItem)
            { 
            Turnaments.Models.Team selectedTeam1 = teamsComboBox3.SelectedItem as Turnaments.Models.Team;
            Turnaments.Models.Team selectedTeam2 = teamsComboBox4.SelectedItem as Turnaments.Models.Team;

            PlayGame playGame = new PlayGame(selectedTeam1, selectedTeam2, turnament);
                if (!IsTeamLocked(selectedTeam1) && !IsTeamLocked(selectedTeam2))
                {
                    playGame.SaveButtonClicked += (s, args) =>
            {
                canSelectTeams[2] = false;
                canSelectTeams[3] = false;
                lockedTeams.Add(selectedTeam1);
                lockedTeams.Add(selectedTeam2);
                Winner2 = playGame.Winner;
                teamTextBox2.Text = Winner2;
                OnPropertyChanged(nameof(CanSelectTeams));
                UpdateComboBoxesEnabledState();
                SaveToFile(filePath);
            };
                    playGame.ShowDialog();
                }

        }
    }

            private void BtnClickPlayThird1_4(object sender, RoutedEventArgs e)
        {
            if (teamsComboBox5.SelectedItem != null && teamsComboBox6.SelectedItem != null && teamsComboBox5.SelectedItem != teamsComboBox6.SelectedItem)
            {
                Turnaments.Models.Team selectedTeam1 = teamsComboBox5.SelectedItem as Turnaments.Models.Team;
                Turnaments.Models.Team selectedTeam2 = teamsComboBox6.SelectedItem as Turnaments.Models.Team;
                if (!IsTeamLocked(selectedTeam1) && !IsTeamLocked(selectedTeam2))
                {
                    PlayGame playGame = new PlayGame(selectedTeam1, selectedTeam2, turnament);
                    playGame.SaveButtonClicked += (s, args) =>
                    {

                        canSelectTeams[4] = false;
                        canSelectTeams[5] = false;
                        lockedTeams.Add(selectedTeam1);
                        lockedTeams.Add(selectedTeam2);
                        Winner3 = playGame.Winner;
                        teamTextBox3.Text = Winner3;
                        OnPropertyChanged(nameof(CanSelectTeams));
                        UpdateComboBoxesEnabledState();
                        SaveToFile(filePath);
                    };
                    playGame.ShowDialog();
                }
            }
        }

        private void BtnClickPlayFourth1_4(object sender, RoutedEventArgs e)
        {
            if (teamsComboBox7.SelectedItem != null && teamsComboBox8.SelectedItem != null && teamsComboBox7.SelectedItem != teamsComboBox8.SelectedItem)
            {
                Turnaments.Models.Team selectedTeam1 = teamsComboBox7.SelectedItem as Turnaments.Models.Team;
                Turnaments.Models.Team selectedTeam2 = teamsComboBox8.SelectedItem as Turnaments.Models.Team;
                PlayGame playGame = new PlayGame(selectedTeam1, selectedTeam2, turnament);
                if (!IsTeamLocked(selectedTeam1) && !IsTeamLocked(selectedTeam2))
                {
                    playGame.SaveButtonClicked += (s, args) =>
                {
                    lockedTeams.Add(selectedTeam1);
                    lockedTeams.Add(selectedTeam2);
                    canSelectTeams[6] = false;
                    canSelectTeams[7] = false;
                    Winner4 = playGame.Winner;
                    teamTextBox4.Text = Winner4;
                    OnPropertyChanged(nameof(CanSelectTeams));
                    UpdateComboBoxesEnabledState();
                    SaveToFile(filePath);
                };
                    playGame.ShowDialog();
                }
            }
        }
        public List<bool> CanSelectTeams
        {
            get { return canSelectTeams; }
            set
            {
                if (canSelectTeams != value)
                {
                    canSelectTeams = value;
                    OnPropertyChanged(nameof(CanSelectTeams));
                }
            }
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    

    private void BtnClickPlayFirst1_2(object sender, RoutedEventArgs e)
        {
            Turnaments.Models.Team selectedTeam1 = turnament.Teams.FirstOrDefault(team => team.Name == Winner1);
            Turnaments.Models.Team selectedTeam2 = turnament.Teams.FirstOrDefault(team => team.Name == Winner2);
            PlayGame playGame = new PlayGame(selectedTeam1, selectedTeam2, turnament);
            playGame.SaveButtonClicked += (s, args) =>
            {
                Winner5 = playGame.Winner;
                teamTextBox5.Text = Winner5;
                OnPropertyChanged(nameof(CanSelectTeams));
                SaveToFile(filePath);
            };
            playGame.ShowDialog();
        }


        private void BtnClickPlaySecond1_2(object sender, RoutedEventArgs e)
        {
            Turnaments.Models.Team selectedTeam1 = turnament.Teams.FirstOrDefault(team => team.Name == Winner3);
            Turnaments.Models.Team selectedTeam2 = turnament.Teams.FirstOrDefault(team => team.Name == Winner4);
            PlayGame playGame = new PlayGame(selectedTeam1, selectedTeam2, turnament);
            playGame.SaveButtonClicked += (s, args) =>
            {
                Winner6 = playGame.Winner;
                teamTextBox6.Text = Winner6;
                OnPropertyChanged(nameof(CanSelectTeams));
                SaveToFile(filePath);
            };
            playGame.ShowDialog();
        }

        private void BtnClickBtnClickPlayFinal(object sender, RoutedEventArgs e)
        {
            Turnaments.Models.Team selectedTeam1 = turnament.Teams.FirstOrDefault(team => team.Name == Winner5);
            Turnaments.Models.Team selectedTeam2 = turnament.Teams.FirstOrDefault(team => team.Name == Winner6);
            PlayGame playGame = new PlayGame(selectedTeam1, selectedTeam2, turnament);
            playGame.SaveButtonClicked += (s, args) =>
            {
                Winner7 = playGame.Winner;
                teamTextBox7.Text = Winner7;
                OnPropertyChanged(nameof(CanSelectTeams));
                SaveToFile(filePath);
            };
            playGame.ShowDialog();
        }
    }
}
