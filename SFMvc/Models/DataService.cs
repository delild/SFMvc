﻿using Microsoft.AspNetCore.Http;
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

        public void AddToWatchList(int id)
        {
            context.Shows2Users.Add(new Shows2Users
            { ApplicationUserId = userId, ShowId = id });

            context.SaveChanges();
        }

        internal PersonalVM GetMyWatchList()
        {
            var movies = context.Shows2Users.Where(o => o.ApplicationUserId == userId).ToList();
            List<Show> shows = new List<Show>();
            foreach (var item in movies)
            {
                Show show = context.Shows.SingleOrDefault(o => o.Id == item.ShowId);
				shows.Add(show);
            }

            var model = new PersonalVM { MyWatchList = shows };
            return model;
        }
    }
}
