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
    /// Logika interakcji dla klasy PlayGame.xaml
    /// </summary>
    public partial class PlayGame : Window
    {
        public PlayGame()
        {
            InitializeComponent();
        }

        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnClickExitApp(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnClickTeam1Score(object sender, RoutedEventArgs e)
        {

        }

        private void BtnClickTeam2Score(object sender, RoutedEventArgs e)
        {

        }
    }
}