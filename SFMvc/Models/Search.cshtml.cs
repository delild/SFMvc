using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SFMvc.Models
{
	public class Search : PageModel
	{
		//private readonly DataService dataService;

		//public Search(DataService dataService)
		//{
		//	this.dataService = dataService;
		//}

		private readonly ApplicationContext context;
        public Search(ApplicationContext context)
        {
            this.context = context;
        }
        public List<Show> Shows { get; } = new List<Show>();
		public List<Show> FilteredShows { get; set; } = new List<Show>();

		public void OnGet()
		{
			Shows.AddRange(context.Shows);
			FilteredShows = Shows;
		}
	}
}
