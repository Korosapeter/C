using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvek.Models
{


        internal class FogalalsContext : DbContext
        {
            public DbSet<Book> Books { get; set; }
            public DbSet<Author> Authors { get; set; }
            public DbSet<Country> Countrys { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                //ConnectionString
                string c = "server = localhost; userid = root; password =; database = Book";

                //OptionBulider: ConnectionString + Szerver verzió (manuálisan, vagy Autodetect)
                optionsBuilder.UseMySql(c, ServerVersion.AutoDetect(c));


            }
        }
    
}
