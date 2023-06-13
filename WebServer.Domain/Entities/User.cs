using WebServer.Domain.Common;

namespace WebServer.Domain.Entities;

public sealed class User : BaseUser
{
   public string Name { get; set; }
   public string Email { get; set; }
   public string Password { get; set; }
}