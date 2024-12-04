using OceanBio.Server.DataAccess.Repositories;
using OceanBio.Shared.Entities;

namespace OceanBio.Server.EndPointExtensions;

public static class AnimalEndPoints
{
    public static IEndpointRouteBuilder MapAnimalsEndpoints(this IEndpointRouteBuilder app)
    {
       var group = app.MapGroup("animals");

       group.MapGet("", async (AnimalRepository repository) =>
       {
           return await repository.GetAllAnimalsAsync();
       });
       
       group.MapPost("", async (AnimalRepository repository, Animal animal) =>
       {
           await repository.AddAsync(animal);
       });

       group.MapGet("{id}", async (AnimalRepository repository, int id) =>
       {
           return await repository.GetByIdAsync(id);
       });

        return app;
    }
}