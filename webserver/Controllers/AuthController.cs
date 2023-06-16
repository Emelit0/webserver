namespace webserver.Controllers;

public class AuthController
{
    private readonly ILogger<AuthController> _logger;
    private readonly IUserRepository _userRepository;
    private readonly ITokenService _tokenService;
    
    public AuthController(ILogger<AuthController> logger, IUserRepository userRepository, ITokenService tokenService)
    {
        _logger = logger;
        _userRepository = userRepository;
        _tokenService = tokenService;
    }
    
    //register
    
    
    //login
    
    //logout
    
    //refresh token
    
    
}