
using System.Data.Entity;

namespace CanjeLibros.Models
{
    public class UsuarioDBContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Libro> Libroes { get; set; }

        public DbSet<Exchange> Exchanges { get; set; }
    }
}