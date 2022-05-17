using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Digiruokalista_Remastered.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Ravintola> Ravintola { get; set; } = null!;
        public virtual DbSet<Kategoria> Kategoriat { get; set; } = null!;
        public virtual DbSet<Ruoka> Ruuat { get; set; } = null!;
        public virtual DbSet<Hinta> Hinnat { get; set; } = null!;
    }
}