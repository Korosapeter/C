using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtazasiIrosa_MVVM.Models;

namespace UtazasiIrosa_MVVM.Services
{
    internal class UtazasServices : IUtazasServices
    {
        private readonly IrodaContext _context;
        public UtazasServices(IrodaContext context)
        {
            _context = context;
        }
        public void UtazasMentes(Utazas utazas)
        {
            _context.Utazas.Add(utazas);
            _context.SaveChanges();

        }
    }

}
