using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProteinManagementSystem.Web.Startup))]
namespace ProteinManagementSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
