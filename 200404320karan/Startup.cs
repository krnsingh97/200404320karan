using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200404320karan.Startup))]
namespace _200404320karan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
