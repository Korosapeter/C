using Konyvek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Konyvek.Iservices.ICountrzservices;

namespace Konyvek.Iservices
{
    internal class CountryService : ICountrzservices
    {
        private readonly FogalalsContext _dbc;

        public CountryService(FogalalsContext dbc)
        {
            _dbc = dbc;
        }
        bool ICountrzservices.AddCountry(Country ctry)
        {
            _dbc.Countrys.Add(ctry);
            return true;
        }

        List<Country> ICountrzservices.GetAllCountry()
        {
            return (from c in _dbc.Countrys select c).ToList<Country>();
        }

        Country ICountrzservices.GetCountryById(int id)
        {
            return (Country)from c in _dbc.Countrys where c.Id == id select c;
        }
    }
}

}
