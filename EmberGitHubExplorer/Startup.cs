using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmberGitHubExplorer.Startup))]
namespace EmberGitHubExplorer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
