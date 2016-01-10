using System;
using System.Linq;
using DAL.Contracts.Entities;

namespace DAL.Contracts.Repositories
{
    public interface IRepository<T> : IDisposable where T: class, IEntity
    {
        T Get(int id);
        IQueryable<T> GetQueryable();
    }
}
