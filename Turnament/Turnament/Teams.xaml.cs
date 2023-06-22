﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
using System.Xml;
using Turnaments.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy Teams.xaml
    /// </summary>
    public partial class Teams : Page
    {
        public Teams(Turnaments.Models.Turnament turnament)
        {
            InitializeComponent();           
            LoadGrid();           
        }
        public void LoadGrid()
        {
        }
        private void BtnClickSelect(object sender, RoutedEventArgs e)
        {
            Team team = new Team();
            team.Show();
        }

        private void BtnClickDelete(object sender, RoutedEventArgs e)
        {

        }
    }
}
