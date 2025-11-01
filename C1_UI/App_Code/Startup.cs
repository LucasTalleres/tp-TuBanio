using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(C1_UI.Startup))]
namespace C1_UI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
