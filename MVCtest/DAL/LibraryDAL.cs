using MVCtest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCtest.DAL
{
    public class LibraryDAL:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookModel>().ToTable("Book");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<BookModel> Books { get; set; }
    }
}