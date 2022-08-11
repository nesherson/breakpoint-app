using BreakpointApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BreakpointApp.Infrastructure.Repositories.UserRepo
{
    public class UserRepository : IUserRepository, IDisposable
    {
        private readonly DatabaseContext _databaseContext;
        private bool _disposed;

        public UserRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _disposed = false;
        }

        public async Task DeleteUser(Guid userId)
        {
            User? user = await _databaseContext.User.FindAsync(userId);
            if (user == null)
                throw new NullReferenceException("User not found");

            _databaseContext.User.Remove(user);
        }

        public async Task<User> GetUserById(Guid userId)
        {
            User user = await _databaseContext.User.FindAsync(userId);

            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            IEnumerable<User> users = await _databaseContext.User.ToListAsync();

            return users;
        }

        public async Task InsertUser(User user)
        {
            await _databaseContext.User.AddAsync(user);
        }

        public async Task Save()
        {
            await _databaseContext.SaveChangesAsync();
        }

        public async Task UpdateUser(User user)
        {
            _databaseContext.Entry(user).State = EntityState.Modified;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            { 
                
            }

            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
