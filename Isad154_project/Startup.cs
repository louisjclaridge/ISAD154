using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Isad154_project.Startup))]
namespace Isad154_project
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
