using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JWPWS.Startup))]
namespace JWPWS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
