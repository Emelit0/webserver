using webserver.Models;

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
    
    public DbSet<Product> Products { get; set; } = null!;
    
    public DbSet<User> Users { get; set; } = null!;
    
    public DbSet<Category> Categories { get; set; } = null!;
    
    
}