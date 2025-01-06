using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OPPProject.Startup))]
namespace OPPProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
