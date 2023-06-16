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
using System.Data.SqlClient;
using System.Data;

namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string connectionString =
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Turnaments;Integrated Security=True;Encrypt=False";


        SqlConnection con = new SqlConnection(connectionString);
        public MainWindow()
        {
            InitializeComponent();
            LoadGrid();
        }
        public void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Players", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            Dane.ItemsSource = dt.DefaultView;
        }
    }
}