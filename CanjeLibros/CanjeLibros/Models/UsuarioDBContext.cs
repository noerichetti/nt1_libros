using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CanjeLibros.Models
{
    public class UsuarioDBContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Libro> Libroes { get; set; }

        public DbSet<Exchange> Exchanges { get; set; }
    }
}