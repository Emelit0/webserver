using webserver.Dtos;

namespace webserver.Repositories;

public interface IProductRepository
{
    Task<List<ProductDto>> GetAllProducts();
    Task<ProductDto> GetProductById(int id);
    Task<ProductDto> CreateProduct(ProductDto productDto);
    Task<ProductDto> UpdateProduct(int id, ProductDto productDto);
    Task<ProductDto> DeleteProduct(int id);
}