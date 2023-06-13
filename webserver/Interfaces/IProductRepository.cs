using webserver.Models;

namespace webserver.Repositories;

public interface IProductRepository
{
    public Task<List<Product>> GetAllProducts();
    public Task<Product> GetProductById(int id);
    public Task<Product> CreateProduct(Product product);
    public Task<Product> UpdateProduct(int id, Product product);
    public Task<Product> DeleteProduct(int id);
    
}