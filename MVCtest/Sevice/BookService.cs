using MVCtest.DAL;
using MVCtest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCtest.Sevice
{
    public class BookService
    {
        LibraryDAL libraryDal = new LibraryDAL();
        public List<BookModel> GetModel()
        {
            return libraryDal.Books.ToList();
        }

        public dynamic Add(BookModel model)
        {
            libraryDal.Books.Add(model);
            libraryDal.SaveChanges();
            return model;
        }
    }
}