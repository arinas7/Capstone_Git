using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Admin_Web.Startup))]
namespace Admin_Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
