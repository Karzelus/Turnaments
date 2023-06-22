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

namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy Player.xaml
    /// </summary>
    public partial class Player : Window
    {
        private Turnaments.Models.Player selectedPlayer;
        private Turnaments.Models.Team team;
        private Turnaments.Models.Turnament turnament;

        public Player(Turnaments.Models.Player selectedPlayer, Turnaments.Models.Team team, Turnaments.Models.Turnament turnament)
        {
            InitializeComponent();
            this.selectedPlayer = selectedPlayer;
            this.team = team;
            this.turnament = turnament;

            Name.Text = selectedPlayer.FirstName + " " + selectedPlayer.LastName;
            FirstName.Text = selectedPlayer.FirstName;
            LastName.Text = selectedPlayer.LastName;
            Age.Text = selectedPlayer.Age.ToString();
            Number.Text = selectedPlayer.Number.ToString();
            NumberOfGoals.Text = selectedPlayer.NumberOfGoals.ToString();
        }

        private void BtnClickExitApp(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            Close();
            Team team = new Team(this.team, this.turnament);
            team.Show();
        }

        private void BtnClickChangeData(object sender, RoutedEventArgs e)
        {
            Close();
            EditPlayer editPlayer = new EditPlayer(this.selectedPlayer, this.team, this.turnament);
            editPlayer.Show();
        }
    }
}