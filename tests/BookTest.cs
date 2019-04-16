using System;
using Xunit;
using Fisher.Bookstore.Models;

namespace tests
{
    public class BookTest
    {
        public string Publisher { get; private set; }
        public DateTime PublishDate { get; private set; }
        public int ID { get; private set; }
        public string Title { get; private set; }
        public Author Author { get; private set; }


        public void ChangePublicationDate(DateTime dateTime)
        {
            //arrange
            var book = new BookTest()
            {
                ID = 1,
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };

            //act
            var newPublicationDate = DateTime.Now.AddMonths(2);
            book.ChangePublicationDate(DateTime.Now.AddMonths(2));

            //assert 
            var expectedPublicationDate = newPublicationDate.ToShortDateString();
            var actualPublicationDate = book.PublishDate.ToShortDateString();

            AssemblyLoadEventArgs.Equals(expectedPublicationDate, actualPublicationDate);
        }

    // Test for Changing a title

        public void ChangeTitle(string bookTitle)
        {
            //arrange
            var book1 = new BookTest()
            {
                ID = 1,
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };

            //act

            var newTitle = "Guardians of the Galaxy";
            book1.ChangeTitle(newTitle);

            //assert 
            var expectedTitle = newTitle;
            var actualTitle = book1.Title;

            AssemblyLoadEventArgs.Equals(expectedTitle, actualTitle);

        }


        // Test for Changing a title

        public void ChangePublisher(string pubName)
        {
            //arrange
            var book2 = new BookTest()
            {
                ID = 1,
                Title = "The Boring Book",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };

            //act

            var newPublisher = "Pearson";
            book2.ChangePublisher(newPublisher);

            //assert 
            var expectedPublisher = newPublisher;
            var actualPublisher = book2.Publisher;

            AssemblyLoadEventArgs.Equals(expectedPublisher, actualPublisher);

        }

    }
}