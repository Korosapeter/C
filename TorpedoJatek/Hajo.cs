using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorpedoJatek
{
    public class Hajo
    {
        public int Meret { get; set; } 
        public int Elet { get; set; } 
        public int Irany { get; set; }
        private readonly  Palya palya;
        // 0,1
        //vizszint,fuggoleges
        public Hajo(int meret,Palya p) 
        { 
            Meret = meret;
            Elet = meret;
            palya = p;
        }
        public void KordinataBekeres()
        {
            int x;
            int y;
            int irany;
            do
            {

            Console.WriteLine("Add meg az sor");
             x = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg a oszlop");
             y = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg hogy állítva(0) vagy fektetve(1) legyen a hajó");
             irany = int.Parse(Console.ReadLine());
            } 
            while (!Lerakhato(x,y,irany));
            
            Lerak(x,y,irany);
        }
 
        public void Lerak(int y,int x, int irany)
        {
            for (int i = 0; i < Meret; i++)
            {
                if (irany == 0)
                {
                    palya.HajoPontLerak(new Pont(x, y+i, this));
                }
                else if (irany == 1) 
                {
                    palya.HajoPontLerak(new Pont(x+i , y, this));
                }
            }
            
            
        }
       public bool Lerakhato(int x, int y, int irany)
        {
            if (Meret! > palya.oszlop || Meret! < palya.oszlop)
            {
                return true;
            }
            else
            {
                return false;   
            }


        }
    }






}
