﻿using BreakpointApp.Core.Entities;
using BreakpointApp.Infrastructure.Repositories.Generic;
using BreakpointApp.Infrastructure.Repositories.UserRepo;

namespace BreakpointApp.Infrastructure.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DatabaseContext _databaseContext;
        private GenericRepository<User> _userRepository;

        public UnitOfWork(DatabaseContext databaseContext)
        { 
            _databaseContext = databaseContext;
        }

        public GenericRepository<User> UserRepository =>
                _userRepository ??= new GenericRepository<User>(_databaseContext);

        public void Save()
        {
            _databaseContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _databaseContext.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
