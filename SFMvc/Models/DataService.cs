using SFMvc.Views.Home;

namespace SFMvc.Models
{
    public class DataService
    {
        List<Show> Shows = new List<Show>()
        {
            new Show {Id = 1, Title= "The Crown", Description = "An American-British Drama from 2016", Format="Serie", ImageUrl = "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480", LogoUrl="https://images.ctfassets.net/4cd45et68cgf/Rx83JoRDMkYNlMC9MKzcB/2b14d5a59fc3937afd3f03191e19502d/Netflix-Symbol.png?w=700&h=456"}
        };
        
        public IndexVM[] GetAllShows()
        {
            return Shows
                .Select(x => new IndexVM
                {
                    Title = x.Title,
                    Description = x.Description,
                    Format = x.Format,
                    ImageUrl = x.ImageUrl,
                    LogoUrl = x.LogoUrl,    
                }
                )
                .ToArray();
        }
    }
}
