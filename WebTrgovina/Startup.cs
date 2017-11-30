using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTrgovina.Startup))]
namespace WebTrgovina
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
