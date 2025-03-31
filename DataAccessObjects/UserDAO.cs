using BusinessObject;
using GalleryRepositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObjects
{
    public class UserDAO
    {
        private readonly IUserRepository _userRepository;
        public UserDAO(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User FindByEmail(string email) => _userRepository.FindByEmail(email);
        public bool ValidateUser(string emaill, string password)
        {
            var user = FindByEmail(emaill);
            if (user == null)
            {
                return false;
            }
            return user.Password == password;
        }
        public static List<User> GetUsers()
        {
            using var context = new MyLibraryContext();
            return context.Users.ToList();
        }
        public static User GetUserById(int id)
        {
            using var context = new MyLibraryContext();
            return context.Users.SingleOrDefault(User => User.Id == id);
        }
        public static void AddUser(User user)
        {
            using var context = new MyLibraryContext();
            context.Users.Add(user);
            context.SaveChanges();
        }
        public static void DeleteUser(User User)
        {
            using var context = new MyLibraryContext();
            var p1 = context.Users.SingleOrDefault(c => c.Id == User.Id);
            context.Users.Remove(p1);
            context.SaveChanges();
        }
        public static void UpdateUser(User User)
        {
            using var context = new MyLibraryContext();
            context.Entry<User>(User).State = EntityState.Modified;
            context.SaveChanges();
        }

    }
}
