using static Assignment11_ADV.BookFunctions;

namespace Assignment11_ADV
{
    internal class Program
    {
        static void Main()
        {

            List<Book> bookList = new List<Book>
            {
                new Book("12345", "C# Basics", new string[]{"Mohamed Ahmed"}, new DateTime(2020, 7, 1), 200m),
                new Book("67890", "Advanced C#", new string[]{"yasmin Ahmed"}, new DateTime(2022, 4, 19), 300m)
            };

            BookDelegate myDel = new BookDelegate(BookFunctions.GetTitle);
            LibraryEngine.ProcessBooks(bookList, new Func<Book, string>(myDel));


            LibraryEngine.ProcessBooks(bookList, BookFunctions.GetAuthors);


            LibraryEngine.ProcessBooks(bookList, delegate (Book b) { return b.ISBN; });


            LibraryEngine.ProcessBooks(bookList, b => b.PublicationDate.ToString("yyyy-MM-dd"));
        }
    }
}
