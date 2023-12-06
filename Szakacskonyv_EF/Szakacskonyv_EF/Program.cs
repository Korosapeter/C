using Szakacskonyv_EF.Models;
using Szakacskonyv_EF.Models.szakacskonyv_EF.Models;

namespace Szakacskonyv_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //Context példányosítása (ekkol létrejön a kapcsolat és a a DbSet pubélikus tulajdonság is...)
                ReceptContext context = new ReceptContext();

                //Ha a ConnectionString-ben leírt adatbázis nem létezne, akkor létrehozza
                //Táblanév --> DbSet neve
                //Mezők    --> publikus tulajdonságok + adattípusok  (Id --> PK)
                context.Database.EnsureCreated();

                Todo r1 = new Todo { Nev = "Valami", Elkeszites = "Nem bonyolult", Hozzavalok = "Sok minden", Ido = 10, Vegan = false };

                //DbSet-hez hozzáadás
                context.receptGyujtemeny.Add(r1);

                //A változások végrehajtása az adatbázison
                context.SaveChanges();


                Console.WriteLine(context.receptGyujtemeny.Count<Todo>());
                Console.ReadLine();

                static void felvetele(ReceptContext context) 
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}