using OceanBio.Server.DataAccess.Repositories;
using OceanBio.Shared.Entities;
using OceanBio.Shared.Models;

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
           var animal = await repository.GetByIdAsync(id);

           if (animal is null)
           {
               return Results.NotFound(ServiceResponse<Animal>.Fail($"Animal with id {id} was not found."));
           }
           return Results.Ok(ServiceResponse<Animal>.Success(animal));
       });

        return app;
    }
}