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
        public Team FirstTeam { get; set; }
        public Team SecondTeam { get; set; }
        public Referee Referee { get; set; }
        public Team Winner { get; set; }
        public Team Losser { get; set; }
        //public bool IsDraw { get; set; }
    }
}