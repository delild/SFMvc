using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SFMvc.Models;
using SFMvc.Views.Home;

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

        

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginVM viewModel)
        {
            if (!ModelState.IsValid)
                return View();

            // Check if credentials is valid (and set auth cookie)
            var errorMessage = await dataService.TryLoginAsync(viewModel);
            if (errorMessage != null)
            {
                // Show error
                ModelState.AddModelError(string.Empty, errorMessage);
                return View();
            }

            // Redirect user
            return RedirectToAction(nameof(Index));
        }




        
        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterVM viewModel)
        {
            if (!ModelState.IsValid)
                return View();

            // Try to register user
            var errorMessage = await dataService.TryRegisterAsync(viewModel);
            if (errorMessage != null)
            {
                foreach (var item in errorMessage)
                {
                    ModelState.AddModelError(string.Empty, item);

                }
                return View();
            }

            // Redirect user
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            await dataService.TryLogoutAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        [HttpGet("personal")]
        public async Task<IActionResult> Personal()
        {
            return View();
        }





    }
}
