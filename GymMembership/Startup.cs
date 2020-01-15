using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GymMembership.Startup))]
namespace GymMembership
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
