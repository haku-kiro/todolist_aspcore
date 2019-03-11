using Microsoft.AspNetCore.Mvc;

/// <summary>
///  This is where the home page is rendered ? 
/// </summary>
namespace todolist_aspcore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
