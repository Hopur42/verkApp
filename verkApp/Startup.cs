using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(verkApp.Startup))]
namespace verkApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
