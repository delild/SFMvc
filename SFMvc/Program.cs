using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SFMvc.Models;

namespace SFMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<DataService>();
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>()
                .AddDefaultTokenProviders();
            // Hämta connection-strängen från AppSettings.json
            var connString = builder.Configuration.GetConnectionString("DefaultConnection");

            // Registrera Context-klassen för dependency injection
            builder.Services.AddDbContext<ApplicationContext>(o => o.UseSqlServer(connString));

            // Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.ConfigureApplicationCookie(
                        o => o.LoginPath = "/login");

            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => endpoints.MapControllers());

            app.Run();
        }
    }
}