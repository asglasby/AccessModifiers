using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Modifiers.Startup))]
namespace Modifiers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
