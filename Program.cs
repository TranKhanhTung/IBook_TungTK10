using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IBook.Data;
using Microsoft.Extensions.DependencyInjection;

namespace IBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    var configuration = hostContext.Configuration;

                    services.Configure<CookiePolicyOptions>(options =>
                    {
                        options.CheckConsentNeeded = context => false;
                        options.MinimumSameSitePolicy = SameSiteMode.None;
                    });

                    services.AddDbContext<ApplicationDbContext>(options =>
                        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
                    services.AddIdentity<IdentityUser, IdentityRole>()
                        .AddEntityFrameworkStores<ApplicationDbContext>()
                        .AddDefaultUI()
                        .AddDefaultTokenProviders();

                    services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

                    services.AddSession(options =>
                    {
                        options.IdleTimeout = TimeSpan.FromMinutes(30);
                        options.Cookie.HttpOnly = true;
                    });
                })
                .Configure((hostContext, app) =>
                {
                    var env = hostContext.HostingEnvironment;

                    if (env.IsDevelopment())
                    {
                        app.UseDeveloperExceptionPage();
                        app.UseDatabaseErrorPage();
                    }
                    else
                    {
                        app.UseExceptionHandler("/Home/Error");
                        app.UseHsts();
                    }

                    app.UseHttpsRedirection();
                    app.UseStaticFiles();
                    app.UseCookiePolicy();

                    app.UseAuthentication();
                    app.UseSession();
                    app.UseMvc(routes =>
                    {
                        routes.MapRoute(
                          name: "areas",
                          template: "{area=Customer}/{controller=Home}/{action=Index}/{id?}"
                        );
                    });
                });
    }
}
