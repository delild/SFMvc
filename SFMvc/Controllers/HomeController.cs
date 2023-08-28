using Microsoft.AspNetCore.Mvc;
using SFMvc.Models;

namespace SFMvc.Controllers
{
    public class HomeController : Controller
    {
        public DataService dataService; 
        
        
        public HomeController(DataService dataService)
        {
           this.dataService = dataService;
        }


        [HttpGet("/")]
        public IActionResult Index()
        {

            return View(dataService.GetAllShows());
        }
    }
}
