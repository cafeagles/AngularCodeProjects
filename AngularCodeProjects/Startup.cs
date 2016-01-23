using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularCodeProjects.Startup))]
namespace AngularCodeProjects
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
