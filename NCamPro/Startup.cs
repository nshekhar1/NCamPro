using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NCamPro.Startup))]
namespace NCamPro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
