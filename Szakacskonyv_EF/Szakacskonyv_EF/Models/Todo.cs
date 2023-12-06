using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakacskonyv_EF.Models
{
    internal class Todo
    {
        class Recept
        {
            public int Id { get; set; }
            public string Nev { get; set; }
            public string Hozzavalok { get; set; }
            public string Elkeszites { get; set; }
            public int Ido { get; set; }
            public bool Vegan { get; set; }

        }
    }
}
