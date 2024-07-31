using Microsoft.AspNetCore.Mvc;

namespace MentorAppPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
