namespace WebServer.Domain.Common;

public class BaseProduct
{
   public ProductId Id { get; set; }
   public DateTimeOffset Created { get; set; }
   public DateTimeOffset? LastModified { get; set; }
   public DateTimeOffset? Deleted { get; set; }
}