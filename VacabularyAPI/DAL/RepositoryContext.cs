using System;
using System.Data.Entity;
using Common.Contracts.Logging;
using DAL.Contracts.Entities;

namespace DAL
{
    public class RepositoryContext
    {
        private readonly ILogger logger;

        private DbContext dbContext;
        private Boolean disposed;

        public RepositoryContext(DbContext dbContext, ILogger logger)
        {
            if (dbContext == null)
                throw new ArgumentNullException("dbContext");

            if (logger == null)
                throw new ArgumentNullException("logger");

            this.dbContext = dbContext;
            this.logger = logger;
        }

        public IDbSet<T> GetContext<T>() where T : class, IEntity
        {
            if (disposed)
                throw new ObjectDisposedException(GetType().Name);

            return dbContext.Set<T>();
        }

        public Int32 SaveChanges()
        {
            if (disposed)
                throw new ObjectDisposedException(GetType().Name);

            try
            {
                return dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                var err = dbContext.GetValidationErrors();
                foreach (var dbEntityValidationResult in err)
                {
                    foreach (var error in dbEntityValidationResult.ValidationErrors)
                    {
                        logger.Error(String.Format("Property {0}: {1} - {2}", dbEntityValidationResult.Entry.Entity, error.PropertyName, error.ErrorMessage));
                    }
                }

                logger.Error(e);

                return -1;
            }
        }

        public void Dispose()
        {
            if (disposed)
                return;

            disposed = true;
            if (dbContext != null)
            {
                dbContext.Dispose();
                dbContext = null;
            }
        }
    }
}
