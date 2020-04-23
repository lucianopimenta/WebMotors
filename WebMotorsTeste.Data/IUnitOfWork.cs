using System;
using WebMotorsTeste.Core.Interface;
using WebMotorsTeste.Core.Repository;

namespace WebMotorsTeste.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        int Commit();
        IDbContext GetDbContext();
    }
}
