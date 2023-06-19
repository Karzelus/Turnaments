using System;
using System.Collections.Generic;
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Teams", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                string name = reader.GetString(1);
                string srt = reader.GetString(2);
                Team team= new Team()
                {
                    Name = name,
                    Shortcut = srt
                };
                TeamsListView.Items.Add(team);
            }
            reader.Close();
            con.Close();
        }
    }
}
