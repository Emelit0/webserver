using System.ComponentModel.DataAnnotations;

namespace webserver.Entities;

public class Product
{

    public Product()
    {
        throw new NotImplementedException();
    }

    [Key] public int Id { get; set; }

    [Required] public string Name { get; set; } = null!;

    [MaxLength(250)] public string Description { get; set; } = null!;
    public decimal Price { get; set; }

    public int CategoryId { get; set; }

    public int SupplierId { get; set; }

    public virtual ICollection<User> Users { get; set; } = null!;
}