using Betelguese.Models;

namespace Betelguese.Interfaces
{
    public interface IAnswer
    {
        Task DeleteUser(int id);
        Task<User?> GetUser(int id);
        //Task<IEnumerable<User>> GetUsers();
        Task InsertUser(User user);
        Task UpdateUser(User user);
        List<User> GetUsers();
    }
}
