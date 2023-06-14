using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnaments.Models
{
    public class Turnament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int TeamsNumber { get; set; }
        public int GamesNumber { get; set; }
        public List<Team> Teams { get; set; }
        public List<Referee> Referees { get;}
        public Team Winner { get; set; }
    }
}
