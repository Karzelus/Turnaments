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
        public Player()
        {
            InitializeComponent();
        }

        private void BtnClickExitApp(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            Close();
            Team team = new Team();
            team.Show();
        }

        private void BtnClickChangeData(object sender, RoutedEventArgs e)
        {
            Close();
            EditPlayer editPlayer = new EditPlayer();
            editPlayer.Show();
        }
    }
}
