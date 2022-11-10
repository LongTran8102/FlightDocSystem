using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlightDocSystem.Startup))]
namespace FlightDocSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
