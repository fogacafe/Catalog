using Catalog.Domain.Common.SeedOfWork;

namespace Catalog.Domain.Common.Repos
{
    public interface IRepository<T> where T : Entity
    {
        Task<T> FindByIdAsync(Guid id);
        Task DeleteByIdAsync(Guid id);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task SaveAsync(T entity);
    }
}
