using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp_appsistencia.Startup))]
namespace asp_appsistencia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
