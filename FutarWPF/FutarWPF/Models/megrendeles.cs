using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutarWPF.Models
{
    internal class megrendeles
    {
        public int id { get; set; }

        public futar FutarId { get; set; }
        
        public Etel EtelId { get; set; }

        public string Cim { get; set; }

        public string FizetésiMod { get; set; }

        public DateOnly Dátum { get; set; }
    }
}
