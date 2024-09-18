using Api.Applicartion.Products;
using Api.Domain.Entities;
using Api.Domain.Repositories;
using Api.Domain.UnitOfWork;
using Api.Endpoints.Products;
using Api.Extensions;
using Api.Infrastructure.Repositories;
using Api.Infrastructure.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
//Probando push al repositorio
builder.Services.AddMediatR(x =>
{
    x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
builder.Services.AddDbContext<Api.Infrastructure.ApiDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ApiDbContext"));
});

builder.Services.AddScoped<IProductRespository, ProductRespository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ProductsService>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}

app.AllProducts();
app.AddProduct();

app.MapGet("/", () => "Hello World!");

app.MapControllers();

app.Run();
