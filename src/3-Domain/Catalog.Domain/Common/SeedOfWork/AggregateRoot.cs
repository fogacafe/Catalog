namespace Catalog.Domain.Common.SeedOfWork
{
    public abstract class AggregateRoot : Entity
    {
        protected AggregateRoot() { }

        protected AggregateRoot(Guid id) : base(id) { }
        
    }
}
