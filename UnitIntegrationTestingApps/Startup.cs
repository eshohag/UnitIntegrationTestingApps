using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnitIntegrationTestingApps.Startup))]
namespace UnitIntegrationTestingApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
