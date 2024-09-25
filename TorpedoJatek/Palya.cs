using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorpedoJatek
{
    public class Palya
    {
        private readonly List<Pont> tenger;
        public int oszlop { get; set; }
        public int sor { get; set; }
        public bool talalat { get; set; }

        public Palya(int o, int s)
        {

            oszlop = o;
            sor = s;
            tenger = new List<Pont>();
            Kirajzol();
        }
        public void Kirajzol()
        {

            Console.Clear();


            foreach (Pont p in tenger) 
            {
                if (p != null) 
                { 
                Console.SetCursorPosition(p.X+1, p.Y+1);
                Console.WriteLine(p.hajo.Meret);
                }
            }    
        }
        public void HajoLerak()
        {
            Hajo kettes = new Hajo (2,this);
            kettes.KordinataBekeres();

            Hajo negyes = new Hajo (4,this);
            negyes.KordinataBekeres();

            Kirajzol();

        }
        public void HajoPontLerak(Pont p)
        {
            tenger.Add(p);
        }
        public void keret()
        {

        }
        public bool FoglaltPont(int x,int y)
        {
            return false;
        }
        public Pont LovesTalalat()
        {
            return null;
        }
    }




}
