using Microsoft.AspNetCore.Mvc;

namespace MVCWebApplication.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
