using BreakpointApp.Core.Entities;
using BreakpointApp.Infrastructure.Repositories.Generic;

namespace BreakpointApp.Infrastructure.Repositories.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public GenericRepository<User> UserRepository { get; }

        void Save();
    }
}
