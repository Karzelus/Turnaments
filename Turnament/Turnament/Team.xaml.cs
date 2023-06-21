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
    /// Logika interakcji dla klasy Team.xaml
    /// </summary>
    public partial class Team : Window
    {
        public Team()
        {
            InitializeComponent();
        }

        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void BtnClickExitApp(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
