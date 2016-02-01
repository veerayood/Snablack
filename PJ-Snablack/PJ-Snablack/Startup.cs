using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PJ_Snablack.Startup))]
namespace PJ_Snablack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
