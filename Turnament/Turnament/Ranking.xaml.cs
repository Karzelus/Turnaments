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
using Turnaments.Models;
using Newtonsoft.Json;
using System.IO;

namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy Ranking.xaml
    /// </summary>
    public partial class Ranking : Page
    {
        public Ranking(Turnaments.Models.Turnament turnament)
        {
            InitializeComponent();
            List<Turnaments.Models.Team> Teams = turnament.Teams;
            List<Turnaments.Models.Team> sortedTeams = Teams.OrderByDescending(team => team.VictoryNumber - team.LossesNumber).ToList();
            TeamsListView.ItemsSource= sortedTeams;
        }
    }
}
