using Microsoft.EntityFrameworkCore;
using webserver.Dtos;
using webserver.Helpers;

namespace webserver.Repositories;

public class ProductRepository
{
    private readonly DataContext _context;

    public ProductRepository(DataContext context)
    {
        _context = context;
    }
    
    public async Task<List<ProductDto>> GetAllProducts()
    {
        var products = await _context.Products.ToListAsync();
        return products.Select(product => new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price,
            Description = product.Description,
            Image = product.Image
        }).ToList();
    }
    
    public async Task<ProductDto> GetProductById(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product != null)
            return null;
        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price,
            Description = product.Description,
            Image = product.Image
        };
    }
    
    public async Task<ProductDto> CreateProduct(ProductDto productDto)
    {
        var product = new Product
        {
            Name = productDto.Name,
            Price = productDto.Price,
            Description = productDto.Description,
            Image = productDto.Image
        };
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price,
            Description = product.Description,
            Image = product.Image
        };
    }
    
    public async Task<ProductDto> UpdateProduct(int id, ProductDto productDto)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
            return null;
        product.Name = productDto.Name;
        product.Price = productDto.Price;
        product.Description = productDto.Description;
        product.Image = productDto.Image;
        await _context.SaveChangesAsync();
        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price,
            Description = product.Description,
            Image = product.Image
        };
    }
}

