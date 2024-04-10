using Konyvek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvek.Iservices
{


    internal class Bookservices : IBookservices
    {

        private readonly Context _dbc;

        public Bookservices(Context dbc)
        {
            _dbc = dbc;
        }

        public List<Book> GetAllBooks()
        {
            return _dbc.Books.ToList();
        }

        public Book GetBook(int id)
        {
            Book select = from x in _dbc.book
        }

        public bool saveBook(Book nBook)
        {
            throw new NotImplementedException();
        }
    }
}
