using BreakpointApp.Infrastructure.Repositories.UserRepo;

namespace BreakpointApp.Infrastructure.Repositories.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public IUserRepository UserRepository { get; }

        void Save();
    }
}
