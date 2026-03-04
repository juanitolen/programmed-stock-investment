using Microsoft.EntityFrameworkCore;
using CompraProgramadaAcoes.Domain;

namespace CompraProgramadaAcoes.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Asset> Assets { get; set; }
    public DbSet<Order> Orders { get; set; }
}