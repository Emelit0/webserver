using webserver.Dtos;

namespace webserver.Helpers;

using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to postgres with connection string from app settings
        options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
    }
    
    public DbSet<ProductDto> Products { get; set; } = null!;
    
    public DbSet<UserDto> Users { get; set; } = null!;
    
    public DbSet<CategoryDto> Categories { get; set; } = null!;
    
    
}