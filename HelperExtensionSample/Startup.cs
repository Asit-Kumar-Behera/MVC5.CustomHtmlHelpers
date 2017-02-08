using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelperExtensionSample.Startup))]
namespace HelperExtensionSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
