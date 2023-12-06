using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakacskonyv_EF.Models
{
    internal class TodoContext
    {
                namespace szakacskonyv_EF.Models
    {
        class ReceptContext : DbContext
        {


            public DbSet<Todo> receptGyujtemeny { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                //ConnectionString
                string c = "server = localhost; userid = root; password =; database = receptEF";

                //OptionBulider: ConnectionString + Szerver verzió (manuálisan, vagy Autodetect)
                optionsBuilder.UseMySql(c, ServerVersion.AutoDetect(c));


            }
        }
    }
}


    

