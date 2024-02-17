using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Ef
{
 
    
        public class EfDataContext : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Teams;Integrated Security=True");
            }

            public DbSet<Player> Players { get; set; }
            public DbSet<Team> Teams{ get; set; }
           
        }

    }

