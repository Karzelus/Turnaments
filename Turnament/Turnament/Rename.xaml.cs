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
using Newtonsoft.Json;
using System.IO;
using Turnaments.Models;

namespace Turnament
{
    /// <summary>
    /// Logika interakcji dla klasy Rename.xaml
    /// </summary>
    public partial class Rename : Page
    {
        int turnamentID;
        public Rename(Turnaments.Models.Turnament turnament)
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

                tournamentToEdit.Name = RenameValue.Text;

                string updatedJsonData = JsonConvert.SerializeObject(turnamentList, Formatting.Indented);
  
                File.WriteAllText(filePath, updatedJsonData);
            }
            MainWindow mainWindow = new MainWindow(tournamentToEdit.Id);
            mainWindow.Show();
        }

    }
}
