namespace Catalog.Domain.Common.Repos
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        Task BeginTransaction();
        Task Rollback();
    }
}
