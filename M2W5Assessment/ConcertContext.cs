using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2W5Assessment
{
    public class ConcertContext : DbContext
    {
        public DbSet<Concert> Concerts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=<enter_your_password_here>;Database=concert").UseSnakeCaseNamingConvention();
    }
}
