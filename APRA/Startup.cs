using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APRA.Startup))]
namespace APRA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
