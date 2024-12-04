using OceanBio.Server.DataAccess.Repositories;
using OceanBio.Shared.Entities;

namespace OceanBio.Server.EndPointExtensions;


public static class AnimalCategoryEndPoints
{
    public static IEndpointRouteBuilder MapAnimalCategories(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("categories");
        
        group.MapGet("", async (AnimalCategoryRepository repository) =>
        {
            return await repository.GetAllCategoriesAsync();
        });



        group.MapPost("", async (AnimalCategoryRepository repository, AnimalCategory category) =>
        {
            await repository.AddAsync(category);
        });

        return app;
    }
}