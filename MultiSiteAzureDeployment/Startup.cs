using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultiSiteAzureDeployment.Startup))]
namespace MultiSiteAzureDeployment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
