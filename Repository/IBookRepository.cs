using BusinessObject;

namespace Repository
{
    public interface IBookRepository : IRepository<Book>
    {
        Book FindByName(string name);
    }
}
