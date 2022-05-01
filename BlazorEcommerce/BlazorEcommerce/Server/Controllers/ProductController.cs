using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //[HttpGet]
        //public async Task<IActionResult> GetProduct()
        //{
        //    return Ok(Products);
        //}
        #region DataContext
        //private readonly DataContext _context;

        //public ProductController(DataContext context)
        //{
        //    _context = context;
        //}

        //[HttpGet]
        //public async Task<ActionResult<List<Product>>> GetProduct()
        //{
        //    var products = await _context.Products.ToListAsync();
        //    var response = new ServiceResponse<List<Product>>()
        //    {
        //        Data = products
        //    };
        //    return Ok(response);
        //}
        #endregion

        #region IProductService
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            var result = await _productService.GetProductsAsync();
            return Ok(result);
        }

        //[HttpGet]
        //[Route("{id}")]
        [HttpGet("productId")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int productId)
        {
            var result = await _productService.GetProductAsync(productId);
            return Ok(result);
        }
        #endregion



    }
}
