using Konyvek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvek.Iservices
{
    internal class Authorservices : IAuthorservices
    {
        FogalalsContext _dbc;

         public Authorservices(FogalalsContext dbc)
        {
            _dbc = dbc;
        }
        public List<Author> GetAllAuthors()
        {
            return _dbc.Authors.ToList();      
         }

        public Author GetBook(int id)
        {
            Author select =  (from x in _dbc.Authors
                              where x.Id == id
                              select x).FirstOrDefault();
            return select;
        }

        public bool saveBook(Author nAuthor)
        {
            throw new NotImplementedException();
        }
    }
}
