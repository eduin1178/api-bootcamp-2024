using Api.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductRespository _productRespository;

        public ProductsController(IProductRespository productRespository)
        {
            _productRespository = productRespository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _productRespository.GetAll();
            return Ok(products);
        }
    }
}
