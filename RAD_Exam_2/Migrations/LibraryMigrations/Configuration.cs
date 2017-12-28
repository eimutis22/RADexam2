namespace RAD_Exam_2.Migrations.LibraryMigrations
{
    using RAD_Exam_2.Models.LibraryModels;
    using Rad301ChristmasExam2017.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RAD_Exam_2.Models.LibraryModels.LibraryDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\LibraryMigrations";
        }

        protected override void Seed(RAD_Exam_2.Models.LibraryModels.LibraryDbContext context)
        {
            //SeedMembers(context);
            //SeedBooks(context);

        }

        private void SeedMembers(LibraryDbContext c)
        {
            c.Members.AddOrUpdate(u => u.MemberID, new Member
            {
                FirstName = "John",
                SecondName = "Smith",
                DateJoined = DateTime.Now
            });

            c.Members.AddOrUpdate(u => u.MemberID, new Member
            {
                FirstName = "Jimmy",
                SecondName = "Johnson",
                DateJoined = DateTime.Now
            });
        }

        private void SeedBooks(LibraryDbContext c)
        {
            c.Books.AddOrUpdate(u => u.BookID, new Book
            {
                Author = "Phil Knight",
                ISBN = "123456",
                Title = "Shoe Dog"
            });

            c.Books.AddOrUpdate(u => u.BookID, new Book
            {
                Author = "James Smith",
                ISBN = "123432",
                Title = "Titanic"
            });

            c.Books.AddOrUpdate(u => u.BookID, new Book
            {
                Author = "Jack Bloggs",
                ISBN = "123333",
                Title = "Awesome Book"
            });
        }
    }
}
