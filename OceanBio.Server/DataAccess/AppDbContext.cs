using Microsoft.EntityFrameworkCore;
using OceanBio.Shared.Entities;

namespace OceanBio.Server.DataAccess;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Animal> Animals { get; set; }
    public DbSet <AnimalCategory> AnimalCategories { get; set; }
    public DbSet<AnimalFact> AnimalFacts { get; set; }
}