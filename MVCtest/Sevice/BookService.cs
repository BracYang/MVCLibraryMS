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

        public bool IsValidUser(UserLogin u)
        {
            if (u.UserName=="a"&&u.Password=="1")
                return true;
            return false;
        }

        public UserStatus GetUserValidity(UserLogin u)
        {
            if (u.UserName=="admin"&&u.Password=="1")
            {
                return UserStatus.AuthenticatedAdmin;
            }
            if (u.UserName == "user" && u.Password == "1")
            {
                return UserStatus.AuthenticatedUser;
            }
            else
            {
                return UserStatus.NonAuthenticatedUser;
            }
        }
    }
}