using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebReporting.Startup))]
namespace WebReporting
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
