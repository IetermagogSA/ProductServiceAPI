using Microsoft.AspNetCore.Mvc;
using ProductServiceAPI.Data;
using ProductServiceAPI.Models;
using ProductServiceAPI.Services;

namespace ProductServiceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        public readonly IEnumerable<Product> productList = ProductData.GetSampleProducts();
        public readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(productList);
        }

        [HttpPost]
        public ActionResult<Product> CreateProduct([FromBody]Product product)
        {
            var result = _productService.Create(product);
            return Ok(result);
        }

        [HttpPut]
        public ActionResult<Product> PutProduct([FromBody]Product product)
        {
            var result = _productService.Update(product);
            return Ok(result);
        }
    }
}
