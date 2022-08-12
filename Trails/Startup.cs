using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trails.Startup))]
namespace Trails
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
