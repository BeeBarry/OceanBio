using Microsoft.EntityFrameworkCore;
using OceanBio.Shared.Entities;

namespace OceanBio.Server.DataAccess.Repositories;

public class AnimalRepository(AppDbContext context)
{
    private readonly AppDbContext _context = context;

    public async Task<List<Animal>> GetAllAnimalsAsync()
    {
        return await _context.Animals.ToListAsync();
    }

    public async Task<Animal?> GetByIdAsync(int id)
    {
        return await _context.Animals.FindAsync(id);
    }

    public async Task AddAsync(Animal animal)
    {
        await _context.Animals.AddAsync(animal);
    }
}