using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Team_CodeProjectV1.Startup))]
namespace Team_CodeProjectV1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
