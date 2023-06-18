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
    /// Logika interakcji dla klasy Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnClickCreateTournament(object sender, RoutedEventArgs e)
        {
            CreateTournament ct = new CreateTournament();
            this.Hide();
            ct.Show();
        }

        private void BtnClickSelectTournament(object sender, RoutedEventArgs e)
        {
            SelectTournament st = new SelectTournament();
            this.Hide();
            st.Show();
        }            
    }
}
