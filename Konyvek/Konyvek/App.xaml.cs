using Konyvek.Iservices;
using Konyvek.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Konyvek
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ///<summary>
            ///A PLUSZ SZOLGÁLTATÁSOK HOZZÁADÁS
            ///</summary>A
            Services = ConfigureServices();

        }

        private void Component()
        {
            throw new NotImplementedException();
        }


        //EZEN A METÓDUSON KERESZTÜL LEHET ELKÉRNI A VIEWMODEL-leket
        public new static App Current => (App)Application.Current;


        public IServiceProvider Services { get; }



        private static IServiceProvider ConfigureServices()
        {
            ///<summary>
            ///A SZOLGÁLTATÁSOK-KÉSZLET PÉLDÁNYOSÍTÁSA
            ///SAJÁT SZOLGÁTATÁS HOZZÁADÁSA
            ///A BŐVÍTETT KÉSZLET VISSZAADÁSA
            /// </summary>

            var services = new ServiceCollection();

            services.AddDbContext<FogalalsContext>();

            services.AddSingleton<IAuthorservices, Authorservices>();
           


            return services.BuildServiceProvider();
        }

    }

}
