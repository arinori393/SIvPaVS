using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_SIvPaVS.Startup))]
namespace MVC_SIvPaVS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
