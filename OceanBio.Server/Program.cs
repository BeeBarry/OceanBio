using Microsoft.EntityFrameworkCore;
using OceanBio.Server.DataAccess;
using OceanBio.Server.DataAccess.Repositories;
using OceanBio.Server.EndPointExtensions;
using OceanBio.Shared.Entities;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddScoped<AnimalRepository>();
builder.Services.AddScoped<AnimalFactRepository>();
builder.Services.AddScoped<AnimalCategoryRepository>();




// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapAnimalCategories();
app.MapAnimalsEndpoints();




app.Run();

