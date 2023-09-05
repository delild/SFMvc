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
        public async Task<IActionResult> Index()
        {
            var model = await dataService.GetAllShowsAsync();
            return View(model);
        }


        [HttpGet("AddToWatchList/{id}")]
        public IActionResult AddToWatchList(int id)
        {
            if (!dataService.IsAlreadyInWatchList(id))
            {
                dataService.AddToWatchList(id);
                return PartialView("_ButtonAdded");
            }
            return PartialView("_ButtonNotAdded");
        }


        [HttpGet("GetButtonText/{id}")]
        public IActionResult GetButtonText(int id)
        {
            if (dataService.IsAlreadyInWatchList(id))
            {
                return PartialView("_ButtonAdded");
            }
            return PartialView("_ButtonNotAdded");
        }


        [HttpGet("personal/{id}")]
        public IActionResult RemoveFromWatchList(int id)
        {
            dataService.RemoveFromWatchList(id);
            return RedirectToAction("personal");
        }


        [HttpGet("remove/{id}")]
        public IActionResult RemoveComment(int id)
        {
            int showId = dataService.RemoveComment(id);
            return RedirectToAction("details", new { id = showId });
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

            if (viewModel.UserName.Contains("@"))
            {
                viewModel.UserName = dataService.GetUserNameByEmail(viewModel.UserName);
            }

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
            return RedirectToAction(nameof(Login));
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
        public IActionResult Personal()
        {
            var model = dataService.GetMyWatchList();
            return View(model);
        }

        [HttpGet("details/{id}")]
        public async Task<IActionResult> DetailsAsync(int id)
        {
            var model = await dataService.GetMovieDetailsAsync(id);
            return View(model);
        }

        [HttpPost("details/{id}")]
        public IActionResult SaveComment(DetailsVM model, int id)
        {
            dataService.AddToComments(model, id);
            return RedirectToAction("details", new { id = id });
        }



    }
}
