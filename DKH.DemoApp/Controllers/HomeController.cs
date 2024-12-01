using Microsoft.AspNetCore.Mvc;

namespace DKH.DemoApp.Controllers;

[Route("/")]
public class HomeController : ControllerBase
{
    public IActionResult Index()
    {
        return Ok("home");
    }
}
