using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Tech.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {}
        public DbSet<Tech.Models.Contacto> DataContacto {get; set; }
        public DbSet<Tech.Models.Producto> DataProducto {get; set; }
}
