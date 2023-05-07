using System.Diagnostics.Tracing;

namespace Beadando_Korosa_Peter
{
    internal class Program
    {
        public struct datumok
        {
            public string labdatum;
            public string kezdatum;
            public string fejdatum;
        }
        static void Main(string[] args)
        {
            int valasztas;
            int taj;
            int szig;

            //pontok
            Console.WriteLine("Kórházi segéd program");

            Console.WriteLine("Adja meg a nevét");
            string nev = Console.ReadLine();
            Console.WriteLine("Adja meg a taj számát");
            taj = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a személyi számát");
            szig = int.Parse(Console.ReadLine());

            //menü
            int sz=30, m=15, x=5, y=5;



            Console.Clear();
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < sz; i++)
                Console.Write("X");

            Console.SetCursorPosition(x, y + m);
            for (int i = 0; i <= sz; i++)
                Console.Write("X");

            for (int i = 0; i < m; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("X");
            }

            for (int i = 0; i < m; i++)
            {
                Console.SetCursorPosition(x + sz, y + i);
                Console.Write("X");
            }
            string[] lista = { "1) Lábbal kapcsolatos", "2) Kézzel kapcsolatos", "3) Fejjel kapcsolatos", "4) Adatok lekérése " };
            

            for (int i = 0;i < lista.Length; i++)
            {
                y++;
                Console.SetCursorPosition(x + 2, y);
                Console.WriteLine(lista[i]);
            }
            Console.SetCursorPosition(x+2,y+1);
            Console.WriteLine("Milyen jellegü a panasza:");
            Console.SetCursorPosition(x+2, y+2);
            valasztas = int.Parse(Console.ReadLine());

            //menu valasztas
            datumok[] idopont = new datumok[50];
            int valtozo = 0;
            string sor="";
            if (valasztas == 1)
            {
                lab(idopont,valtozo,sor,nev,taj,szig);
            }



            if (valasztas == 2)
            {
                kez(idopont,valtozo,sor, nev, taj, szig);

            }

            if (valasztas == 3)
            {
                fej(idopont,valtozo,sor, nev, taj, szig);
            }
            if (valasztas == 4)
            {
                lekeres(idopont,sor);
            }



        }
        //lablekeres
        static void lab(datumok[] idopont, int v, string sor, string nev, int taj, int szig)
        {
            Console.Clear();
            FileStream fs = new FileStream("lab.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                idopont[v++].labdatum = sor;
            }
            Array.Resize(ref idopont, v);

            for (int i = 0; i < v; i++)
            {

                Console.WriteLine(idopont[i].labdatum);
            }
            fs.Close();
            sr.Close();
            Console.WriteLine("Melyik időpontot szeretnéd választani?");
            byte idop = byte.Parse(Console.ReadLine());
            Console.WriteLine(idop + ". idopont kiválasztva");
            Thread.Sleep(1000);

            FileStream fs1 = new FileStream("lab.txt", FileMode.Create);
            StreamWriter sr1 = new StreamWriter(fs1);
            FileStream fs2 = new FileStream("lekeres.txt", FileMode.Append);
            StreamWriter sr2 = new StreamWriter(fs2);
            for (int i = 0; i < idopont.Length; i++)
            {
                if (i != (idop - 1))
                {
                    sr1.WriteLine(idopont[i].labdatum);
                }
                else
                    sr2.WriteLine(idopont[i].labdatum + ":" + nev + ":" + taj + ":" + szig);
            }
            sr2.Close();
            fs2.Close();
            sr1.Close();
            fs1.Close();





        }
        //lablekeres
        static void kez(datumok[] idopont, int v, string sor, string nev, int taj, int szig)
        {
            Console.Clear();
            FileStream fs = new FileStream("kez.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                idopont[v++].kezdatum = sor;
            }
            Array.Resize(ref idopont, v);

            for (int i = 0; i < v; i++)
            {

                Console.WriteLine(idopont[i].kezdatum);
            }
            fs.Close();
            sr.Close();
            Console.WriteLine("Melyik időpontot szeretnéd választani?");
            byte idop = byte.Parse(Console.ReadLine());
            Console.WriteLine(idop + ". idopont kiválasztva");
            Thread.Sleep(1000);

            FileStream fs1 = new FileStream("kez.txt", FileMode.Create);
            StreamWriter sr1 = new StreamWriter(fs1);
            FileStream fs2 = new FileStream("lekeres.txt", FileMode.Append);
            StreamWriter sr2 = new StreamWriter(fs2);
            for (int i = 0; i < idopont.Length; i++)
            {
                if (i != (idop - 1))
                {
                    sr1.WriteLine(idopont[i].kezdatum);
                }
                else
                    sr2.WriteLine(idopont[i].kezdatum + ":" + nev + ":" + taj + ":" + szig);
            }
            sr2.Close();
            fs2.Close();
            sr1.Close();
            fs1.Close();
        }

        static void fej(datumok[] idopont, int v, string sor, string nev, int taj, int szig)
        {
            Console.Clear();
            FileStream fs = new FileStream("fej.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                idopont[v++].fejdatum = sor;
            }
            Array.Resize(ref idopont, v);

            for (int i = 0; i < v; i++)
            {

                Console.WriteLine(idopont[i].fejdatum);
            }
            fs.Close();
            sr.Close();
            Console.WriteLine("Melyik időpontot szeretnéd választani?");
            byte idop = byte.Parse(Console.ReadLine());
            Console.WriteLine(idop + ". idopont kiválasztva");
            Thread.Sleep(1000);

            FileStream fs1 = new FileStream("fej.txt", FileMode.Create);
            StreamWriter sr1 = new StreamWriter(fs1);
            FileStream fs2 = new FileStream("lekeres.txt", FileMode.Append);
            StreamWriter sr2 = new StreamWriter(fs2);
            for (int i = 0; i < idopont.Length; i++)
            {
                if (i != (idop - 1))
                {
                    sr1.WriteLine(idopont[i].fejdatum);
                }
                else
                    sr2.WriteLine(idopont[i].fejdatum + ":" + nev + ":" + taj + ":" + szig);
            }
            sr2.Close();
            fs2.Close();
            sr1.Close();
            fs1.Close();
        }
        static void lekeres(datumok[] idopont, string sor)
        {
            Console.Clear();
            string[] sor1;
            FileStream fs = new FileStream("lekeres.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                sor1= sr.ReadLine().Split(":");
                Console.WriteLine(sor1[0]);
                Console.WriteLine(sor1[1]);
                Console.WriteLine(sor1[2]);
                Console.WriteLine(sor1[3]);
            }
            fs.Close();
            sr.Close();
        }
    }
}

    

