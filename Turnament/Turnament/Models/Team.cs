using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnaments.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Shortcut { get; set; }
        public int VictoryNumber { get; set; }
        public int LossesNumber { get; set; }
        public List<Player> Players { get; set; }
        public int LostGoals { get; set; }
        public int ScoredGoals { get; set; }
        public string Image { get; set; }
    }
}
