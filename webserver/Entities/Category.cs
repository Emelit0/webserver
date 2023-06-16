using System.ComponentModel.DataAnnotations;

namespace webserver.Entities;

public class Category
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; } = null!;
    
    [MaxLength(250)]
    public string Description { get; set; } = null!;
}