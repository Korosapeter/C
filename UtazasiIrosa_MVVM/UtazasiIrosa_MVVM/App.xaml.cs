using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using UtazasiIrosa_MVVM.Models;
using UtazasiIrosa_MVVM.Services;

namespace UtazasiIrosa_MVVM
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

            this.InitializeComponent();
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

            //HA VALAMELYIK KONSTRUKTOR IDataService PÉLDÁNYT KÉR, AKKOR EGY DataService PÉLDÁNYT AD AZ "APP"
            services.AddSingleton<IUtazasServices, UtazasServices>();



            services.AddDbContext<IrodaContext>();

            //HA VALAKI AZ APP-tól KÉR EGY UserViewModel PÉLDÁNYT AKKOR INNÉT AD EGYET!

            //services.AddTransient<AuthorListViewModel>();
            //services.AddTransient<BookListViewModel>();
            //services.AddTransient<CountryListViewModel>();


            return services.BuildServiceProvider();
        }
    }

}
