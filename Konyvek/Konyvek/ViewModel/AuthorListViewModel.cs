using Konyvek.Iservices;
using Konyvek.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvek.ViewModel
{
    internal class AuthorListViewModel 
    {
        private readonly IAuthorservices _asr;

        public ObservableCollection<Author> Adlist { get; set; }

        public AuthorListViewModel
    }
}
