using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OCBurrito.Web.Startup))]
namespace OCBurrito.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
