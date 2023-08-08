using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MusicStore.Models;
using Stripe;

namespace MusicStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting(options => options.LowercaseUrls = true);

            services.AddMemoryCache();
            services.AddSession();

            services.AddControllersWithViews().AddNewtonsoftJson();
            services.AddMvc().AddNewtonsoftJson();


            services.AddHttpContextAccessor();
            services.AddTransient<IMusicStoreUnitOfWork, MusicStoreUnitOfWork>();
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<ICart, Cart>();

            services.AddDbContext<MusicStoreContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MusicStoreContext")));
        }

        // Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            // This is your test secret API key.
            StripeConfiguration.ApiKey = "sk_test_51NcpKeDEEICFmRsM45CrvcGhqRwCHqtQHgek8fVjcTdU23V9UpUuuY2Ind7Szc5bu9n5V1N0WPqbFGtOJpJaKTuZ00kdTlSll5";
            app.UseDeveloperExceptionPage();

            
            
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                // route for Admin area
                endpoints.MapAreaControllerRoute(
                    name: "admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Album}/{action=Index}/{id?}");

                // route for paging, sorting, and filtering
                endpoints.MapControllerRoute(
                    name: "",
                    pattern: "{controller}/{action}/page/{pagenumber}/size/{pagesize}/sort/{sortfield}/{sortdirection}/filter/{artist}/{genre}/{price}");

                // route for paging and sorting only
                endpoints.MapControllerRoute(
                    name: "",
                    pattern: "{controller}/{action}/page/{pagenumber}/size/{pagesize}/sort/{sortfield}/{sortdirection}");

                // default route
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}");
            });
        }
    }
}
