using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NeoVicky.Startup))]
namespace NeoVicky
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
