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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy Drabinka.xaml
    /// </summary>
    public partial class Drabinka : Page
    {
        public Drabinka()
        {
            InitializeComponent();
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
