using Microsoft.EntityFrameworkCore;
using OceanBio.Shared.Entities;

namespace OceanBio.Server.DataAccess.Repositories;

public class AnimalCategoryRepository(AppDbContext context)
{
    private readonly AppDbContext _context = context;

    public async Task<List<AnimalCategory>> GetAllCategoriesAsync()
    {
        return await _context.AnimalCategories.ToListAsync();
    }

    public async Task<AnimalCategory?> GetByIdAsync(int id)
    {
        return await _context.AnimalCategories.FindAsync(id);
    }

    public async Task AddAsync(AnimalCategory category)
    {
        await _context.AnimalCategories.AddAsync(category);
        await _context.SaveChangesAsync();
    }

}