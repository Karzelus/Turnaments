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
        public Team SeckondTeam { get; set; }
        public List<Referee> Referees { get; set; }
        public string Winner { get; set; }
        public string Losser { get; set; }
        public bool IsDraw { get; set; }
    }
}
