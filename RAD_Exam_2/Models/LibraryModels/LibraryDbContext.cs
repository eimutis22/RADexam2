using Rad301ChristmasExam2017.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RAD_Exam_2.Models.LibraryModels
{
    public class LibraryDbContext:  DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Member> Members { get; set; }

        public LibraryDbContext() : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public static LibraryDbContext Create()
        {
            return new LibraryDbContext();
        }
    }
}