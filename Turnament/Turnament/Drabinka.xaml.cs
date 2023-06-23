using System;
using System.Collections.Generic;
using System.ComponentModel;
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
      

        public Drabinka(Turnaments.Models.Turnament turnament)
        {
            InitializeComponent();
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
            this.turnament = turnament;
            DataContext = this;

            //teamsComboBox.DisplayMemberPath = "TeamName";
        }
        
        private void BtnClickPlayFirst1_4(object sender, RoutedEventArgs e)
        {
            if (teamsComboBox1.SelectedItem != null && teamsComboBox2.SelectedItem != null && teamsComboBox1.SelectedItem!=teamsComboBox2.SelectedItem)
            {
                Turnaments.Models.Team selectedTeam1 = teamsComboBox1.SelectedItem as Turnaments.Models.Team;
                Turnaments.Models.Team selectedTeam2 = teamsComboBox2.SelectedItem as Turnaments.Models.Team;
                PlayGame playGame = new PlayGame(selectedTeam1,selectedTeam2,turnament);
                playGame.SaveButtonClicked += (s, args) =>
                {
                    int index1 = turnament.Teams.IndexOf(selectedTeam1);
                    int index2 = turnament.Teams.IndexOf(selectedTeam2);
                    canSelectTeams[index1] = false;
                    canSelectTeams[index2] = false;
                    OnPropertyChanged(nameof(CanSelectTeams));
                    UpdateComboBoxesEnabledState();
                };
                playGame.ShowDialog();
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

        private void BtnClickPlaySecond1_4(object sender, RoutedEventArgs e)
        {
            if (teamsComboBox3.SelectedItem != null && teamsComboBox4.SelectedItem != null && teamsComboBox3.SelectedItem != teamsComboBox4.SelectedItem)
            {
                Turnaments.Models.Team selectedTeam1 = teamsComboBox3.SelectedItem as Turnaments.Models.Team;
                Turnaments.Models.Team selectedTeam2 = teamsComboBox4.SelectedItem as Turnaments.Models.Team;
                PlayGame playGame = new PlayGame(selectedTeam1, selectedTeam2, turnament);
                playGame.Show();

            }
        }

            private void BtnClickPlayThird1_4(object sender, RoutedEventArgs e)
        {
            if (teamsComboBox5.SelectedItem != null && teamsComboBox6.SelectedItem != null && teamsComboBox5.SelectedItem != teamsComboBox6.SelectedItem)
            {
                Turnaments.Models.Team selectedTeam1 = teamsComboBox5.SelectedItem as Turnaments.Models.Team;
                Turnaments.Models.Team selectedTeam2 = teamsComboBox6.SelectedItem as Turnaments.Models.Team;
                PlayGame playGame = new PlayGame(selectedTeam1, selectedTeam2, turnament);
                playGame.Show();
            }
        }

        private void BtnClickPlayFourth1_4(object sender, RoutedEventArgs e)
        {
            if (teamsComboBox1.SelectedItem != null && teamsComboBox2.SelectedItem != null && teamsComboBox1.SelectedItem != teamsComboBox2.SelectedItem)
            {
                Turnaments.Models.Team selectedTeam1 = teamsComboBox7.SelectedItem as Turnaments.Models.Team;
                Turnaments.Models.Team selectedTeam2 = teamsComboBox8.SelectedItem as Turnaments.Models.Team;
                PlayGame playGame = new PlayGame(selectedTeam1, selectedTeam2, turnament);
                playGame.Show();
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
           // PlayGame playGame = new PlayGame(selectedTeam1, selectedTeam2, turnament);
          //  playGame.Show();
        }

        private void BtnClickPlaySecond1_2(object sender, RoutedEventArgs e)
        {
         //   PlayGame playGame = new PlayGame();
         //   playGame.Show();
        }

        private void BtnClickBtnClickPlayFinal(object sender, RoutedEventArgs e)
        {
           // PlayGame playGame = new PlayGame();
          //  playGame.Show();
        }
    }
}
