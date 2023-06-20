using System;
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
        static string connectionString =
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Turnaments;Integrated Security=True;Encrypt=False";
        SqlConnection con = new SqlConnection(connectionString);
        public Teams()
        {
            InitializeComponent();           
            LoadGrid();           
        }
        public void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("SELECT Name, Shortcut FROM Teams", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Team> teams = new List<Team>();
            while (reader.Read())
            {
                string name = reader.GetString(0);
                string srt = reader.GetString(1);
                Team team = new Team()
                {
                    Name = name,
                    Shortcut = srt
                };
                teams.Add(team);
            }
            reader.Close();
            con.Close();
            for(int i = 0; i< teams.Count; i++) 
            {               
                RadioButton rb = new RadioButton { Content = teams[i].Name, IsChecked = i == 0,Foreground = Brushes.White};
                //Tu Logika radio buttonów
                //rb.Checked += (sender, args) =>
                //{
                //    Console.WriteLine("Pressed " + (sender as RadioButton).Tag);
                //};
                //rb.Unchecked += (sender, args) => { /* Do stuff */ };
                MyStackPanel.Children.Add(rb); 
            }
        }
        private void BtnClickSelect(object sender, RoutedEventArgs e)
        {

        }

        private void BtnClickAddTeam(object sender, RoutedEventArgs e)
        {                   
        }
    }
}
