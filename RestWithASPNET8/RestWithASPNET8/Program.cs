using Microsoft.EntityFrameworkCore;
using RestWithASPNET8.Model.Context;
using RestWithASPNET8.Business.Implementations;
using RestWithASPNET8.Repository.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connection = builder.Configuration["MySQLConnection:MySQLConnectionString"];
builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql(connection,new MySqlServerVersion(new Version(8, 3, 0))));

builder.Services.AddApiVersioning();

// Dependency Injection 
builder.Services.AddScoped<IPersonBusiness, PersonBusinessImplementation>();
builder.Services.AddScoped<IPersonRepository, PersonRepositoryImplementation>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
