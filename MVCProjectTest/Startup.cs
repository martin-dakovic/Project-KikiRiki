using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCProjectTest.Startup))]
namespace MVCProjectTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
