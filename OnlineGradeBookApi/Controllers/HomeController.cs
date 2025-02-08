using Microsoft.AspNetCore.Mvc;

namespace OnlineGradeBookApi.Controllers;
[ApiController]
[Route("[controller]/[action]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Succesfully Index action loaded");
    }
    [HttpGet]
    public IActionResult ClassSplit()
    {
        return Ok("Succesfully ClassSplit action loaded");
    }
    [HttpGet]
    public IActionResult Class1Split()
    {
        return Ok("Succesfully Class1Split action loaded");
    }
    [HttpGet]
    public IActionResult Class2Split()
    {
        return Ok("Succesfully Class2Split action loaded");
    }
    [HttpGet]
    public IActionResult Class3Split()
    {
        return Ok("Succesfully Class3Split action loaded");
    }
    [HttpGet]
    public IActionResult Privacy()
    {
        return Ok("Succesfully Privacy action loaded");
    }
}