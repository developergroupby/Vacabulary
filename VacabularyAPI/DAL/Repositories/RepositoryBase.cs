using System;
using System.Data.Entity;
using System.Linq;
using DAL.Contracts.Entities;
using DAL.Contracts.Repositories;

namespace DAL.Repositories
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class, IEntity
    {
        private readonly RepositoryContext repositoryContext;

        protected IDbSet<T> DbSet
        {
            get
            {
                return repositoryContext.GetContext<T>();
            }
        }

        protected RepositoryBase(RepositoryContext repositoryContext)
        {
            if (repositoryContext == null)
                throw new ArgumentNullException("repositoryContext");

            this.repositoryContext = repositoryContext;
        }

        public T Get(int id)
        {
            return GetQueryable().FirstOrDefault(t => t.Id == id);
        }

        public IQueryable<T> GetQueryable()
        {
            return DbSet.AsQueryable();
        }

        public virtual void Dispose()
        {
            repositoryContext.Dispose();
        }
    }
}
