namespace CanjeLibros.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbContextLibrosbkp : DbContext
    {
        public DbContextLibrosbkp()
            : base("name=DbContextLibros")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Exchanges> Exchanges { get; set; }
        public virtual DbSet<Libroes> Libroes { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
