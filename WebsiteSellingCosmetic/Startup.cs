using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebsiteSellingCosmetic.Startup))]
namespace WebsiteSellingCosmetic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
