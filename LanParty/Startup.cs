using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LanParty.Startup))]
namespace LanParty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
