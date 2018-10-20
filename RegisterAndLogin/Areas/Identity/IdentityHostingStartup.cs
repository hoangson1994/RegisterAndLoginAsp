using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RegisterAndLogin.Areas.Identity.Data;
using RegisterAndLogin.Models;

[assembly: HostingStartup(typeof(RegisterAndLogin.Areas.Identity.IdentityHostingStartup))]
namespace RegisterAndLogin.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<RegisterAndLoginContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("RegisterAndLoginContextConnection")));
               
            });
        }
    }
}