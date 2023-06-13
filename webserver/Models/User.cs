namespace webserver.Models;

public class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public List<Product> Products { get; set; } = null!;
}