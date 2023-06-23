using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
//using Starpholio.Controllers;
using Starpholio.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using Starpholio.Models;
//using Starpholio.Controllers;

namespace Starpholio
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method is called by the runtime to configure services.
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddDistributedMemoryCache();
            services.AddControllersWithViews();
            services.AddDistributedMemoryCache(); // This line configures a default in-memory cache for storing session data

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); // Set the session timeout as desired
                options.Cookie.HttpOnly = true; // Ensure the session cookie is accessible only via HTTP
                options.Cookie.IsEssential = true; // Mark the session cookie as essential for GDPR compliance
            });
            //services.AddScoped<AuthService>(); // Register the AuthService REMOVE COMMENT LATER
            /*services.AddDbContext<StarpholioDB>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));*/
        }


        // This method is called by the runtime to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
