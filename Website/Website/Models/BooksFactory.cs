using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Models
{
    public class BooksFactory
    {
        public static IEnumerable<Book> CreateBooks()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book()
            {
                Cover = "ontheroad.jpg",
                Year = "1957",
                Name = "On the Road"
            });

            books.Add(new Book()
            {
                Cover = "thedharmabums.jpg",
                Year = "1958",
                Name = "The Dharma Bums"
            });

            books.Add(new Book()
            {
                Cover = "thesubterraneans.jpg",
                Year = "1958",
                Name = "The Subterraneans"
            });

            books.Add(new Book()
            {
                Cover = "bigsur.jpg",
                Year = "1962",
                Name = "Big Sur"
            });

            return books;
        }
    }
}