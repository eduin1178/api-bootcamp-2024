using Api.Applicartion;
using Api.Applicartion.Products;
using Api.Domain.Entities;
using Api.Domain.Repositories;
using Api.Domain.UnitOfWork;

namespace Api.Endpoints.Products
{
    public static class ProductsEndPoints
    {
        public static void AllProducts(this WebApplication app)
        {
            app.MapGet("/Products", async (IProductRespository _repository) =>
            {
                var products = await _repository.GetAll();
                return Results.Ok(products);
            })
            .WithName("Create")
            .WithTags("Products");
        }

        public static void AddProduct(this WebApplication app)
        {
            app.MapPost("Products", async (Product product,
                ProductsService productService) =>
            {
                await productService.Add(product);

            }).WithName("AddProducto")
            .WithTags("Products");
        }
    }
}
