namespace SFMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            //builder.Services.AddTransient<DataService>();

            // Hämta connection-strängen från AppSettings.json
            var connString = builder.Configuration.GetConnectionString("DefaultConnection");

            // Registrera Context-klassen för dependency injection
            //builder.Services.AddDbContext<ApplicationContext>(o => o.UseSqlServer(connString));

            // Swagger
            builder.Services.AddEndpointsApiExplorer();
            

            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints => endpoints.MapControllers());

            

            app.Run();
        }
    }
}