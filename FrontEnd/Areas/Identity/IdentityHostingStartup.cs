using System;
using FrontEnd_Web.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FrontEnd_Web.Areas.Identity.IdentityHostingStartup))]
namespace FrontEnd_Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FrontEnd_WebIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FrontEnd_WebIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<FrontEnd_WebIdentityDbContext>();
            });
        }
    }
}