using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LandscapeWeb.Startup))]
namespace LandscapeWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
