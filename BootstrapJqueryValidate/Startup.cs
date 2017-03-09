using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapJqueryValidate.Startup))]
namespace BootstrapJqueryValidate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
