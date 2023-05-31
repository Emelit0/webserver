using webserver.Models;

namespace webserver.Repositories;

public interface IProductRepository
{
    Task<List<Product>> GetAllProducts();
    Task<Product> GetProductById(int id);
    Task<Product> CreateProduct(Product product);
    Task<Product> UpdateProduct(int id, Product product);
    Task<Product> DeleteProduct(int id);
}