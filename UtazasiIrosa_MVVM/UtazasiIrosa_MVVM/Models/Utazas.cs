using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtazasiIrosa_MVVM.Models
{
    internal class Utazas
    {
        public int Id { get; set; }

        public string Nev { get; set; }
        public string Jarmu { get; set; }
        public int MaxLetszam { get; set; }
        public List<Utas> utasok { get; set; }
    }
}
