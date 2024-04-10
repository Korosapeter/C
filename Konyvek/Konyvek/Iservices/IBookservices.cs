using Konyvek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvek.Iservices
{
    internal interface IBookservices
    {
        public List<Book> GetAllBooks();

        public  Book GetBook(int id);

        public bool saveBook(Book nBook);
    }
}
