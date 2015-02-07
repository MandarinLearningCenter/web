using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MLC.Startup))]
namespace MLC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
