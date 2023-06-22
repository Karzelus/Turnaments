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
using Newtonsoft.Json;
using System.IO;
using Turnaments.Models;

namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy RefereeSelect.xaml
    /// </summary>
    public partial class RefereeSelect : Window
    {
        public RefereeSelect(Turnaments.Models.Referee selectedReferee)
        {
            InitializeComponent();
        }

        private void BtnClickExitApp(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
