using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnaments.Models
{
    public class TurnamentDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Referee> Referees { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Turnament> Turnaments { get; set;}

    }
}
