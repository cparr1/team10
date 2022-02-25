using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(team10.Startup))]
namespace team10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
