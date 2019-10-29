using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GarbageCollectProject.Startup))]
namespace GarbageCollectProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
