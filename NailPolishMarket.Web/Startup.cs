using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NailPolishMarket.Web.Startup))]
namespace NailPolishMarket.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
