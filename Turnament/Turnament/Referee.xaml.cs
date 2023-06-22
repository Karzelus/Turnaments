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

namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy Referee.xaml
    /// </summary>
    public partial class Referee : Page
    {
        public Referee(Turnaments.Models.Turnament turnament)
        {
            InitializeComponent();
            RefereesList.ItemsSource = turnament.Referees;
        }

        private void BtnClickSelect(object sender, RoutedEventArgs e)
        {
            Turnaments.Models.Referee selectedReferee = RefereesList.SelectedItem as Turnaments.Models.Referee;
            if (selectedReferee != null)
            {
                RefereeSelect refereeSelect = new RefereeSelect(selectedReferee);
                refereeSelect.Show();
            }
        }
    }
}
