using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObjects
{
    public class BookDAO
    {
        public static List<Book> GetBooks()
        {
            using var context = new MyLibraryContext();
            return context.Books.ToList();
        }
        public static Book GetBookById(int id)
        {
            using var context = new MyLibraryContext();
            return context.Books.SingleOrDefault(book => book.Id == id);
        }
        public static void AddBook(Book book)
        {
            using var context = new MyLibraryContext();
            context.Books.Add(book);
            context.SaveChanges();
        }
        public static void DeleteBook(Book book)
        {
            using var context = new MyLibraryContext();
            var p1 = context.Books.SingleOrDefault(c => c.Id == book.Id);
            context.Books.Remove(p1);
            context.SaveChanges();
        }
        public static void UpdateBook(Book book)
        {
            using var context = new MyLibraryContext();
            context.Entry<Book>(book).State = EntityState.Modified;
            context.SaveChanges();
        }


    }
}
