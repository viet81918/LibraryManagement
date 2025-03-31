using BusinessObject;

namespace GalleryRepositories
{
    public interface IBookRepository : IRepository<Book>
    {
        Book FindByName(string name);
    }
}
