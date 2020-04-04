using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SIGA.MVC.Startup))]
namespace SIGA.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
