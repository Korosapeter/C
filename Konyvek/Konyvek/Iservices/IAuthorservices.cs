using Konyvek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvek.Iservices
{
    internal interface IAuthorservices
    {
        public List<Author> GetAllAuthors();

        public Author GetBook(int id);

        public bool saveBook(Author nAuthor);
    }
}
