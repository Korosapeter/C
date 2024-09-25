using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorpedoJatek
{
    public class Pont
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public bool Talalat { get; set; }   
        public Hajo hajo { get; set; }

        public Pont(int x, int y, Hajo h)
        {
            X = x;
            Y = y;
            Talalat = false;
            hajo = h;
        }
    }
}
