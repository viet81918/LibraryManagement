using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObjects
{
    class UserDAO
    {
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
