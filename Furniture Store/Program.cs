using Furniture_Store.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<FurnitureContext>(
       options => options.UseSqlServer("name=ConnectionStrings:FurnitureDatabase"));

builder.Services.AddDbContext<PriceContext>(
       options => options.UseSqlServer("name=ConnectionStrings:PriceDatabase"));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();