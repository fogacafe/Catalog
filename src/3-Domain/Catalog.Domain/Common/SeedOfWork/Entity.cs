﻿namespace Catalog.Domain.Common.SeedOfWork
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }

        protected Entity(Guid id)
        {
            Id = id;
        }

        public Entity()
        {
                
        }       
    }
}
