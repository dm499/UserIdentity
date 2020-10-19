using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(UserLoginLogout.Areas.Identity.IdentityHostingStartup))]
namespace UserLoginLogout.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}