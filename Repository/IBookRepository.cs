using BusinessObject;

namespace Repository
{
    public interface IBookRepository : IRepository<Book>
    {
       Book FindByName(string name);
        public List<Book> GetBooks();
        public Book GetBookById(int id);
        public void AddBook(Book book);
        public void DeleteBook(Book book);
        public void UpdateBook(Book book);


    }
}
