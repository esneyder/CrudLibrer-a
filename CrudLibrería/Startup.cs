using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrudLibrería.Startup))]
namespace CrudLibrería
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
