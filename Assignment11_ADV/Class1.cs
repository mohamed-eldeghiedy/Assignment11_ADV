using Assignment11_ADV;
using System;
using System.Collections.Generic;


namespace Assignment11_ADV
{



    public delegate string BookDelegate(Book b);


    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}\n" +
                   $"Title: {Title}\n" +
                   $"Authors: {string.Join(", ", Authors)}\n" +
                   $"Publication Date: {PublicationDate:yyyy-MM-dd}\n" +
                   $"Price: {Price:C}";
        }
    }

    public class BookFunctions
    {
        public static string GetTitle(Book B) => B.Title;
        public static string GetAuthors(Book B) => string.Join(", ", B.Authors);
        public static string GetPrice(Book B) => B.Price.ToString("C");
    }


    public class LibraryEngine
    {

        public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
