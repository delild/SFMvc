using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SFMvc.Views.Home;

namespace SFMvc.Models
{
    public class DataService
    {
        UserManager<ApplicationUser> userManager; // Hanterar användare
        SignInManager<ApplicationUser> signInManager; // Hanterar inlogging
        RoleManager<IdentityRole> roleManager; // Hanterar roller
        ApplicationContext context;
        string userId;

        public DataService(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationContext context,
            IHttpContextAccessor accessor)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.context = context;
            this.userId = userManager.GetUserId(accessor.HttpContext.User);
        }

        //public List<Show> Shows = new List<Show>()
        //{
        //    new Show {Id = 1, Title= "The Crown", Description = "An American-British Drama from 2016", Format="Serie", ImageUrl = "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480", LogoUrl="https://images.ctfassets.net/4cd45et68cgf/Rx83JoRDMkYNlMC9MKzcB/2b14d5a59fc3937afd3f03191e19502d/Netflix-Symbol.png?w=700&h=456"},
        //    new Show {Id = 2, Title= "The Crowning of Eva", Description = "An American-British Drama from 2016", Format="Serie", ImageUrl = "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480", LogoUrl="https://images.ctfassets.net/4cd45et68cgf/Rx83JoRDMkYNlMC9MKzcB/2b14d5a59fc3937afd3f03191e19502d/Netflix-Symbol.png?w=700&h=456"}
        //};

        public async Task<IndexVM[]> GetAllShowsAsync()
        {
            return await context.Shows
                .Select(x => new IndexVM
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    Format = x.Format,
                    ImageUrl = x.ImageUrl,
                    LogoUrl = x.LogoUrl,
                    StreamingUrl = x.StreamingUrl,
                    NumberOfSeasons = x.NumberOfSeasons,
                    NumberOfEpisodes = x.NumberOfEpisodes,
                    LengthInMinutes = x.LengthInMinutes,
                })
                .ToArrayAsync();
        }

        public async Task<string> TryLoginAsync(LoginVM viewModel)
        {
            Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(
               viewModel.UserName,
               viewModel.Password,
               isPersistent: false,
               lockoutOnFailure: false);

            return result.Succeeded ? null : "Login failed";
        }

        public async Task<string[]?> TryRegisterAsync(RegisterVM viewModel)
        {
            var user = new ApplicationUser
            {
                UserName = viewModel.UserName,
                Email = viewModel.Email,
            };

            IdentityResult result = await
                userManager.CreateAsync(user, viewModel.Password);

            if (result.Succeeded)
            {
                return null;
            }

            else
                return result.Errors
                    .Select(o => o.Description)
                    .ToArray();
        }

        public async Task TryLogoutAsync()
        {
            await signInManager.SignOutAsync();
        }

        public bool IsAlreadyInWatchList(int id)
        {
            bool isAlreadyInWatchList = false;
            if (context.Shows2Users.Count() > 0)
            {
                foreach (var item in context.Shows2Users)
                {
                    if (item.ApplicationUserId == userId && item.ShowId == id)
                    {
                        isAlreadyInWatchList = true;
                        break;
                    }
                }
            }
            return isAlreadyInWatchList;
        }

        public void AddToWatchList(int id)
        {
            context.Shows2Users.Add(new Shows2Users
            { ApplicationUserId = userId, ShowId = id });

            context.SaveChanges();
        }

        internal void RemoveFromWatchList(int id)
        {
            var itemtoremove1 = context.Shows2Users.SingleOrDefault(o => o.ApplicationUserId == userId && o.ShowId == id);
            context.Shows2Users.Remove(itemtoremove1);

            context.SaveChanges();
        }

        internal PersonalVM GetMyWatchList()
        {
            var model = new PersonalVM();


            var movies = context.Shows2Users.Where(o => o.ApplicationUserId == userId).ToList();

            MyShowVM[] shows = new MyShowVM[movies.Count];

            for (int i = 0; i < movies.Count; i++)
            {
                var showItem = context.Shows
                .Where(o => o.Id == movies[i].ShowId)
                .Select(x => new MyShowVM
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    Format = x.Format,
                    ImageUrl = x.ImageUrl,
                    LogoUrl = x.LogoUrl,
                    StreamingUrl = x.StreamingUrl,
                    NumberOfSeasons = x.NumberOfSeasons,
                    NumberOfEpisodes = x.NumberOfEpisodes,
                    LengthInMinutes = x.LengthInMinutes

                })
                .First();


                shows[i] = showItem;
            }

            model.MyShows = shows;


            model.MyComments = context.Comments
            .Where(c => c.UserId == userId)
            .Select(c => new MyCommentVM
            {
                Id = c.Id,
                Text = c.Text,  
                Time = c.Time,
                Title = context.Shows.SingleOrDefault(s => s.Id == c.ShowId).Title,

            }).ToArray();


            return model;
        }

        internal string GetUserNameByEmail(string email)
        {
            return context.Users.SingleOrDefault(o => o.Email == email).UserName;
        }

        internal async Task<DetailsVM> GetMovieDetailsAsync(int id)
        {
            var item = await context.Shows
                .Where(x => x.Id == id)
                .Select(x => new DetailsVM
                {
                    Show = new ShowVM
                    {
                        Id = x.Id,
                        Description = x.Description,
                        Format = x.Format,
                        ImageUrl = x.ImageUrl,
                        LogoUrl = x.LogoUrl,
                        Title = x.Title,
                        LengthInMinutes = x.LengthInMinutes,
                        NumberOfEpisodes = x.NumberOfEpisodes,
                        NumberOfSeasons = x.NumberOfSeasons,
                        StreamingUrl = x.StreamingUrl,
                        Cast = x.Cast,
                        Year = x.Year,
                        Director = x.Director,
                        Creators = x.Creators,
                        ImdbLink = x.ImdbLink,
                        Genres = x.Genres
                    }
                }
            ).FirstAsync();

            var comment = await context.Comments
                .Where(x => x.ShowId == id).ToArrayAsync();
            if (comment.Count() > 0)
            {

                item.Comments = comment
                .Select(x => new CommentVM
                {
                    UserName = FindUserById(x.UserId).UserName,
                    Text = x.Text,
                    Time = x.Time,
                    Id = x.Id,
                    ShowId = x.ShowId,

                })
                .ToArray();
            }

            return item;
        }

        private ApplicationUser FindUserById(string userId)
        {
            return context.Users.Where(o => o.Id == userId).SingleOrDefault();
        }

        public void AddToComments(DetailsVM model, int showId)
        {

            context.Comments.Add(new Comment
            {
                Text = model.Text,
                Time = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}",
                ShowId = showId,
                UserId = userId,

            });

            context.SaveChanges();
        }

        internal int RemoveComment(int commentId)
        {
            var itemToRemove = context.Comments.SingleOrDefault(x => x.Id == commentId);
            int showId = itemToRemove.ShowId;
            context.Comments.Remove(itemToRemove);

            context.SaveChanges();
            return showId;
        }
    }
}
