using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
using Turnaments.Models;
using System.IO;

namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy EditReferee.xaml
    /// </summary>
    public partial class EditReferee : Window
    {
        Turnaments.Models.Referee refereeToChange;
        int turnamentID;
        public EditReferee(Turnaments.Models.Referee refereeToChange, int turnamentID)
        {
            InitializeComponent();
            this.refereeToChange= refereeToChange;
            this.turnamentID = turnamentID;
        }

        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnClickChangeData(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\JSON\turnamentSerialized.json";
            var jsonData = File.ReadAllText(filePath);
            List<Turnaments.Models.Turnament> turnamentList = JsonConvert.DeserializeObject<List<Turnaments.Models.Turnament>>(jsonData);
            Turnaments.Models.Turnament tournamentToEdit = turnamentList.FirstOrDefault(t => t.Id == turnamentID);
            List<Turnaments.Models.Referee> refereeList = tournamentToEdit.Referees;
            Turnaments.Models.Referee refereeToEdit = refereeList.FirstOrDefault(r => r.Id == refereeToChange.Id);

            if (refereeToEdit != null)
            {
                refereeToEdit.FirstName = RefereeName.Text;
                refereeToEdit.LastName = RefereeLastName.Text;
            }
             string updatedJsonData = JsonConvert.SerializeObject(turnamentList, Formatting.Indented);
            File.WriteAllText(filePath, updatedJsonData);
            //MainWindow mainWindow = new MainWindow(turnamentID);
            //mainWindow.Show();
            Close();
        }

        private void BtnClickExitApp(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
