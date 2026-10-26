using JaguatibaiaLanding.Models;
using Microsoft.AspNetCore.Mvc;
namespace JaguatibaiaLanding.Controllers;
public class HomeController : Controller
{
    public IActionResult Index() => View(new LandingViewModel());
    public IActionResult Error() => Content("Ocorreu um erro. Tente novamente.");
}