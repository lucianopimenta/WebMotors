using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using WebMotorsTeste.Core.Interface;
using WebMotorsTeste.Data.Entities;

namespace WebMotorsTeste.Data.Context
{
    public class WebMotorsContext : DbContext, IDbContext
    {
        public WebMotorsContext() { }

        public WebMotorsContext(DbContextOptions<WebMotorsContext> options) : base(options)
        {
            Database.SetCommandTimeout(300);
        }

        public virtual DbSet<Anuncio> Anuncio { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anuncio>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("pk_anuncio");

                entity.Property(e => e.ID)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.marca)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("marca");

                entity.Property(e => e.modelo)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("modelo");

                entity.Property(e => e.versao)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("versao");

                entity.Property(e => e.ano)
                    .IsRequired()
                    .HasColumnName("ano");

                entity.Property(e => e.quilometragem)
                   .IsRequired()
                   .HasColumnName("quilometragem");

                entity.Property(e => e.observacao)
                   .IsRequired()
                   .HasColumnName("observacao");

            });
        }

        #region Transação
        public IDbContextTransaction BeginTransaction()
        {
            return Database.BeginTransaction();
        }

        public void Commit()
        {
            Database.CommitTransaction();
        }

        public DbContext Ctx()
        {
            return this;
        }

        public void Rollback()
        {
            Database.RollbackTransaction();
        }
        #endregion
    }
}
