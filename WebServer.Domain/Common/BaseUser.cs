namespace WebServer.Domain.Common;

public abstract class BaseUser
{
   public UserId Id { get; set; }
   public DateTimeOffset Created { get; set; }
   public DateTimeOffset? LastModified { get; set; }
   public DateTimeOffset? Deleted { get; set; }
}