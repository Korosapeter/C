using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lezerloveszet_OOP
{
    internal class JatekosLovese
    {
        public string nev;
        public float x;
        public float y;
        public static float tx;
        public static float ty;
        public int sorszam;



        public JatekosLovese(string sor )
        {
            string[] tomb = sor.Split(';');
            nev = tomb[0];
            x = float.Parse(tomb[1]);
            y = float.Parse(tomb[2]);
            sorszam++; 
        }
        //public float tavolsag
        //{ 

        //    //get { return Math.Sqrt(Math.Pow(tx-x)*2) + (Math.Pow(ty - y) * 2) ; } 
        //}

    }
}
