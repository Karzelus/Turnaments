using Newtonsoft.Json;
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
    /// Logika interakcji dla klasy AddReferee.xaml
    /// </summary>
    public partial class AddReferee : Page
    {
        int turnamentID;
        public AddReferee(Turnaments.Models.Turnament turnament)
        {
            InitializeComponent();
            turnamentID = turnament.Id;
        }

        private void BtnClickCreate(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\JSON\turnamentSerialized.json";
            var jsonData = File.ReadAllText(filePath);
            List<Turnaments.Models.Turnament> turnamentList = JsonConvert.DeserializeObject<List<Turnaments.Models.Turnament>>(jsonData);
            Turnaments.Models.Turnament tournamentToEdit = turnamentList.FirstOrDefault(t => t.Id == turnamentID);
            if (tournamentToEdit != null)
            {
                List<Turnaments.Models.Referee> Referees;
                if (tournamentToEdit.Referees!=null)
                {
                    Referees = tournamentToEdit.Referees;
                
                }
                else
                {
                    Referees = new List<Turnaments.Models.Referee>();
                }
                Turnaments.Models.Referee newReferee = new Turnaments.Models.Referee()
                {
                    Id = Referees.Count,
                    FirstName = FirstNameValue.Text,
                    LastName = LastNameValue.Text,
                };
                Referees.Add(newReferee);
                tournamentToEdit.Referees= Referees; 
                string updatedJsonData = JsonConvert.SerializeObject(turnamentList, Formatting.Indented);
                File.WriteAllText(filePath, updatedJsonData);
                MainWindow mainWindow = new MainWindow(tournamentToEdit.Id);
                mainWindow.Show();
            }
        }
    }
}
