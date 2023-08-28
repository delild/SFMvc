using Microsoft.AspNetCore.Mvc;

namespace SFMvc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
