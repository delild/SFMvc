using Microsoft.AspNetCore.Mvc;
using SFMvc.Models;
using Microsoft.EntityFrameworkCore;

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
		public async Task<IActionResult> SearchAsync(string searchText)
		{
			var filteredWebsites = await dataService.GetAllShowsAsync();

				filteredWebsites
				.Where(show =>
					show.Title.ToLower().Contains(searchText.ToLower()))/* ||*/
					//brand.ProductName.ToLower().Contains(searchText.ToLower()))
				.ToList();

			return PartialView("_SearchResultsPartial", filteredWebsites);
		}
	}
}

