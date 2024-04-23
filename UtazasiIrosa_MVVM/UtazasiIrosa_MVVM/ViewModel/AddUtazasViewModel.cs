using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtazasiIrosa_MVVM.Models;
using UtazasiIrosa_MVVM.Services;

namespace UtazasiIrosa_MVVM.ViewModel
{
    internal class AddUtazasViewModel
    {
        private readonly IUtazasServices _services;
        public Utazas ujut {  get; set; }

        public AddUtazasViewModel(IUtazasServices services)
        {
            _services = services;
        }
        public void Mentes(string _Name, string _Jarmu, string _Max)
        {
            ujut = new Utazas { Nev = _Name, Jarmu = _Jarmu, MaxLetszam = int.Parse(_Max) };
        }
    }
}
