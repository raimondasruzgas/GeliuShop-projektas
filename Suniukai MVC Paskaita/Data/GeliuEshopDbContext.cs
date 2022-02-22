using Microsoft.EntityFrameworkCore;
using GeliuEshop_projektas.Models;

namespace GeliuEshop_projektas.Data
{
    public class GeliuEshopDbContext : DbContext
    {
        public GeliuEshopDbContext(DbContextOptions<GeliuEshopDbContext> options) : base(options) { }

        public DbSet<Preke> Prekes { get; set; }

    }
}
