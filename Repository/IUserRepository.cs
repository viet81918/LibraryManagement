using BusinessObject;

namespace Repository
{
    public interface IUserRepository : IRepository<User>
    {
        User FindByEmail(string email);
    }
}
