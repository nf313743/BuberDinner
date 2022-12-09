using Microsoft.AspNetCore.Mvc;

[ApiController]
public class AuthenticationController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        
        return Problem();
    }

}