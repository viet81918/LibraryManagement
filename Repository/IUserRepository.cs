using BusinessObject;

namespace GalleryRepositories
{
    public interface IUserRepository : IRepository<User>
    {
        User FindByEmail(string email);
    }
}
