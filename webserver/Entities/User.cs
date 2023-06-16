using System.ComponentModel.DataAnnotations;

namespace webserver.Entities;

public class User
{
    [Key] public int Id { get; set; }

    [Required] public string Password { get; set; } = null!;
    
    [Required] public string Name { get; set; } = null!;

    [MaxLength(250)] public string Description { get; set; } = null!;
    
    public List<Product> Products { get; set; } = null!;
}