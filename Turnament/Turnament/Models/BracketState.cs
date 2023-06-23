using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnament.Models
{
    public class BracketState
    {
      public int turnamentId;
       public string Winner1, Winner2, Winner3, Winner4, Winner5, Winner6, Winner7;
       public List<bool> canSelectTeams;
       public List<bool> lockedTeams;
    }
}
