using BusinessObject;
using DataAccessObjects;

namespace Repository
{
    class BookRepository : Repository<Book>, IBookRepository
    {
         public BookRepository(MyLibraryContext context) : base(context) { }
        public Book FindByName(string name)
        {
            return _dbSet.FirstOrDefault(c => c.Title == name);
        }
        public void AddBook(Book book) => BookDAO.AddBook(book);
        public void DeleteBook(Book book) => BookDAO.DeleteBook(book);
        public Book GetBookById(int id) => BookDAO.GetBookById(id);

        public List<Book> GetBooks() => BookDAO.GetBooks();
        public void UpdateBook(Book book) => BookDAO.UpdateBook(book);

    }
}
