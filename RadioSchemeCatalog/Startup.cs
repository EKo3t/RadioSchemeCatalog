using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RadioSchemeCatalog.Startup))]
namespace RadioSchemeCatalog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
