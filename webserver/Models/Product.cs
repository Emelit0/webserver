namespace webserver.Models;

public class Product
{
   public Product(object image)
   {
      Image = image;
   }

   public Product()
   {
      throw new NotImplementedException();
   }

   public int Id { get; set; }
   
   public string Name { get; set; } = null!;
   
   public string Description { get; set; } = null!;
   
   public decimal Price { get; set; }
   
   public int CategoryId { get; set; }
   
   public int SupplierId { get; set; }
   
   public virtual ICollection<User> Users { get; set; } = null!;
   public object Image { get; set; }
}