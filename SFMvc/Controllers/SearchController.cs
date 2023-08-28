using Microsoft.AspNetCore.Mvc;
using SFMvc.Models;

namespace SFMvc.Controllers
{
	public class SearchController : Controller
	{
		private readonly DataService dataService;

		public SearchController(DataService context)
		{
			dataService = context;
		}

		[HttpGet]
		public IActionResult Search(string searchText)
		{
			var filteredWebsites = dataService.GetAllShows()
				.Where(show =>
					show.Title.ToLower().Contains(searchText.ToLower()))/* ||*/
					//brand.ProductName.ToLower().Contains(searchText.ToLower()))
				.ToList();

			return PartialView("_SearchResultsPartial", filteredWebsites);
		}
	}
}

