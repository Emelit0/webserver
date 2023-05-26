namespace webserver.Dtos;

public class UserDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public List<ProductDto> Products { get; set; } = null!;
}