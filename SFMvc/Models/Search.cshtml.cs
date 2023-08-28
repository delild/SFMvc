using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SFMvc.Models
{
	public class Search : PageModel
	{
		private readonly DataService dataService;

		public Search(DataService dataService)
		{
			dataService = dataService;
		}

		public List<Show> Shows { get; } = new List<Show>();
		public List<Show> FilteredShows { get; set; } = new List<Show>();

		public void OnGet()
		{
			Shows.AddRange(dataService.Shows);
			FilteredShows = Shows;
		}
	}
}
