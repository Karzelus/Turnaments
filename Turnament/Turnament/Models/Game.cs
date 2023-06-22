using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnaments.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int FirstTeamID { get; set; }
        public int SecondTeamID { get; set; }
        public int RefereeID { get; set; }
        public int FirstTeamGoals { get; set; }
        public int SecondTeamGoals { get; set; }
        public string Winner { get; set; }
        public string Losser { get; set; }
        //public bool IsDraw { get; set; }
    }
}