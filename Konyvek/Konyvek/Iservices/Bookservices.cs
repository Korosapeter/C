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

        private readonly FogalalsContext _dbc;

        public Bookservices(FogalalsContext dbc)
        {
            _dbc = dbc;
        }

        public List<Book> GetAllBooks()
        {
            return _dbc.Books.ToList();
        }

        public Book GetBook(int id)
        {

            Book select = (from x in _dbc.Books
                             where x.BookId == id
                             select x).FirstOrDefault();
            return select;
        }

        public bool saveBook(Book nBook)
        {
            throw new NotImplementedException();
        }
    }
}
