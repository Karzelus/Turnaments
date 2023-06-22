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

namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy Drabinka.xaml
    /// </summary>
    public partial class Drabinka : Page
    {
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

            //teamsComboBox.DisplayMemberPath = "TeamName";
        }
        
        private void BtnClickPlayFirst1_4(object sender, RoutedEventArgs e)
        {
            PlayGame playGame = new PlayGame();
            playGame.Show();
        }

        private void BtnClickPlaySecond1_4(object sender, RoutedEventArgs e)
        {
            PlayGame playGame = new PlayGame();
            playGame.Show();
        }

        private void BtnClickPlayThird1_4(object sender, RoutedEventArgs e)
        {
            PlayGame playGame = new PlayGame();
            playGame.Show();
        }

        private void BtnClickPlayFourth1_4(object sender, RoutedEventArgs e)
        {
            PlayGame playGame = new PlayGame();
            playGame.Show();
        }

        private void BtnClickPlayFirst1_2(object sender, RoutedEventArgs e)
        {
            PlayGame playGame = new PlayGame();
            playGame.Show();
        }

        private void BtnClickPlaySecond1_2(object sender, RoutedEventArgs e)
        {
            PlayGame playGame = new PlayGame();
            playGame.Show();
        }

        private void BtnClickBtnClickPlayFinal(object sender, RoutedEventArgs e)
        {
            PlayGame playGame = new PlayGame();
            playGame.Show();
        }
    }
}
