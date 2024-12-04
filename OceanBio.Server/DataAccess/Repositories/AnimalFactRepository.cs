using Microsoft.EntityFrameworkCore;
using OceanBio.Shared.Entities;

namespace OceanBio.Server.DataAccess.Repositories;

public class AnimalFactRepository(AppDbContext context)
{
    private readonly AppDbContext _context = context;

    public async Task<List<AnimalFact>> GetAllFactsAsync()
    {
        return await _context.AnimalFacts.ToListAsync();
    }

    public async Task<AnimalFact?> GetByIdAsync(int id)
    {
        return await _context.AnimalFacts.FindAsync(id);
    }

    public async Task AddAsync(AnimalFact fact)
    {
        await _context.AnimalFacts.AddAsync(fact);
        await _context.SaveChangesAsync();
    }
}