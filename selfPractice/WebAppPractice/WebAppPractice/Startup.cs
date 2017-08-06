using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppPractice.Startup))]
namespace WebAppPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
