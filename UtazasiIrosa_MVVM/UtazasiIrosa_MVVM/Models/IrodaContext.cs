using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtazasiIrosa_MVVM.Models
{
    internal class IrodaContext : DbContext
    {
        public DbSet<Utas> Utas { get; set; }

        public DbSet<Utazas> Utazas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string c = "server = localhost; userid = root; password =; database = UtazasiIroda";

            optionsBuilder.UseMySql(c, ServerVersion.AutoDetect(c));

        }
    }
}
