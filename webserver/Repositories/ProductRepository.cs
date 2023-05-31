using Microsoft.EntityFrameworkCore;
using webserver.Helpers;
using webserver.Models;

namespace webserver.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly DataContext _context;

    public ProductRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetAllProducts()
    {
        var products = await _context.Products.ToListAsync();
        return products.Select(product =>
        {
            if (product != null)
                return new Product
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Description = product.Description,
                    Image = product.Image
                };

            throw new InvalidOperationException();
        }).ToList();
    }

    public async Task<Product> GetProductById(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product != null)
            return null;

        return new Product
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price,
            Description = product.Description,
            Image = product.Image
        };
    }

    public async Task<Product> CreateProduct(Product? product)
    {
        if (product != null)
        {
            product = new Product
            {
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                Image = product.Image
            };
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return new Product
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                Image = product.Image
            };
        }

        throw new InvalidOperationException();
    }

    public async Task<Product> UpdateProduct(int id, Product? product)
    {
        product = await _context.Products.FindAsync(id);
        if (product == null)
            return null;
        product.Name = product.Name;
        product.Price = product.Price;
        product.Description = product.Description;
        product.Image = product.Image;
        await _context.SaveChangesAsync();
        return new Product
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price,
            Description = product.Description,
            Image = product.Image
        };
    }

    public Task<Product> DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }
}