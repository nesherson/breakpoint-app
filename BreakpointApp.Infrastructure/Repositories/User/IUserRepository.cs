using BreakpointApp.Core.Entities;

namespace BreakpointApp.Infrastructure.Repositories.UserRepo
{
    public interface IUserRepository : IDisposable
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUserById(Guid userId);
        Task InsertUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(Guid userId);
        Task Save();
    }
}
