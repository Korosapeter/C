namespace lezerloveszet_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sor;
            float p=0;
            float tx, ty;
            FileStream fs = new FileStream("lovesek.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            List<JatekosLovese> lovesz = new List<JatekosLovese>();
            sor= sr.ReadLine();
            string[] adatok = sor.Split(';');
            tx = float.Parse(adatok[0]);
            ty = float.Parse(adatok[1]);

            while (!sr.EndOfStream)

            {
                sor= sr.ReadLine();
                lovesz.Add(new JatekosLovese(sor));
                p++;
            }

            sr.Close();
            fs.Close();

            Console.WriteLine("Lövész szaám:" + p);
            for (int i = 0; i < 65; i++)
            {
                Console.WriteLine($"{lovesz[i].sorszam},{lovesz[i].nev},{lovesz[i].x},{lovesz[i].y},{lovesz[i].sorszam}");
            }

            /*
            HashSet<string> nevek = new HashSet<string>();
            foreach (var i in lovesz)
            {
                nevek.Add(i.nev);
            }
            Console.WriteLine($"Ennyi ember lőtt{nevek.Count}");

            int nev_sz;
            foreach (var i in nevek)
            {
                nev_sz = 0;
                foreach (var j in lovesz) 
                {
                    if (i==j.nev)
                    {
                        nev_sz++;
                    }
                }
                Console.WriteLine($"{i}: {nev_sz}");
            }
            */
            Dictionary<string , int> NeveK = new Dictionary<string , int>();

            foreach (var i in lovesz)
            { 
                if (NeveK.ContainsKey(i.nev))
                {
                    NeveK[i.nev]++;
                }
                else
                {
                    NeveK.Add(i.nev, 1);
                }


            }
            foreach ( KeyValuePair<string , int> x  in NeveK)
            { Console.WriteLine($"{x.Key} - {x.Value}"); }

            Console.ReadKey();
        }
    }
}