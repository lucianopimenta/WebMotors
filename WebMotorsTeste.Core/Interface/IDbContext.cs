using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace WebMotorsTeste.Core.Interface
{
    public interface IDbContext
    {
        int SaveChanges();

        void Dispose();

        DbSet<TEntity> Set<TEntity>()
            where TEntity : class;

        IDbContextTransaction BeginTransaction();
        void Commit();
        void Rollback();
        DbContext Ctx();
    }
}
