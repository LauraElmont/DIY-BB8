using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DIY.BB8.Web.Startup))]
namespace DIY.BB8.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
