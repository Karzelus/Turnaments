﻿using System;
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
    /// Logika interakcji dla klasy Team.xaml
    /// </summary>
    public partial class Team : Window
    {
        public Team()
        {
            InitializeComponent();
        }

        private void BtnClickSelect(object sender, RoutedEventArgs e)
        {
            Close();
            Player player= new Player();
            player.Show();
        }
        
        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void BtnClickExitApp(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnClickAddPlayer(object sender, RoutedEventArgs e)
        {
            AddPlayer addPlayer = new AddPlayer();
            addPlayer.Show();
        }
    }
}
