using Catalog.Domain.Common.Repos;
using Microsoft.EntityFrameworkCore.Storage;

namespace Catalog.Infrastructure.EFCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppContext _context;
        private IDbContextTransaction? _transaction;

        public UnitOfWork(AppContext context)
        {
            _context = context;
            _transaction = null;
        }

        public async Task BeginTransaction()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            if (_transaction != null) await _transaction.CommitAsync();

            _transaction = null;
        }

        public async Task Rollback()
        {
            if(_transaction != null) await _transaction.RollbackAsync();

            _transaction = null;
        }
    }
}
