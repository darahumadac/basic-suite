using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicSuite.Startup))]
namespace BasicSuite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
