using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutarWPF.Models
{
    internal class KiszallitasContext : DbContext
    {
        public DbSet<Etel> Etel { get; set; }
        public DbSet<futar> Futar { get; set; }
        public DbSet<megrendeles> Megrendeles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ConnectionString
            string c = "server = localhost; userid = root; password =; database = Futa";

            //OptionBulider: ConnectionString + Szerver verzió (manuálisan, vagy Autodetect)
            optionsBuilder.UseMySql(c, ServerVersion.AutoDetect(c));


        }
    }
}
