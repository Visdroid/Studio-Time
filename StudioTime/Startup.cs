using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudioTime.Startup))]
namespace StudioTime
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
