using Microsoft.AspNetCore.Mvc;
using webserver.Dtos;

namespace webserver.Controllers;

//controller for products
// [ApiController]
// [Route("[controller]")]
// public class ProductController : ControllerBase
// {
//     private readonly ILogger<ProductController> _logger;
//     private readonly IProductRepository _productRepository;
//
//     public ProductController(ILogger<ProductController> logger, IProductRepository productRepository)
//     {
//         _logger = logger;
//         _productRepository = productRepository;
//     }
//
//     //get all products
//     [HttpGet(Name = "GetProducts")]
//     public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
//     {
//         var products = await _productRepository.GetProductsAsync();
//         return Ok(products);
//     }
//
//     //get product by id
//     [HttpGet("{id}", Name = "GetProduct")]
//     public async Task<ActionResult<ProductDto>> GetProduct(int id)
//     {
//         var product = await _productRepository.GetProductAsync(id);
//         if (product == null)
//         {
//             return NotFound();
//         }
//
//         return Ok(product);
//     }
//
//     //create product
//     [HttpPost(Name = "CreateProduct")]
//     public async Task<ActionResult<ProductDto>> CreateProduct(ProductDto productDto)
//     {
//         var product = await _productRepository.CreateProductAsync(productDto);
//         return CreatedAtAction(nameof(GetProduct), new {id = product.Id}, product);
//     }
//
//     //update product
//     [HttpPut("{id}", Name = "UpdateProduct")]
//     public async Task<ActionResult<ProductDto>> UpdateProduct(int id, ProductDto productDto)
//     {
//         if (id != productDto.Id)
//         {
//             return BadRequest();
//         }
//
//         var product = await _productRepository.GetProductAsync(id);
//         if (product == null)
//         {
//             return NotFound();
//         }
//
//         await _productRepository.UpdateProductAsync(productDto);
//         return NoContent();
//     }
//
//     //delete product
//     [HttpDelete("{id}", Name = "DeleteProduct")]
//     public async Task<ActionResult<ProductDto>> DeleteProduct(int id)
//     {
//         var product = await _productRepository.GetProductAsync(id);
//         if (product == null)
//         {
//             return NotFound();
//         }
//
//         await _productRepository.DeleteProductAsync(id);
//         return NoContent();
//     }
// }
