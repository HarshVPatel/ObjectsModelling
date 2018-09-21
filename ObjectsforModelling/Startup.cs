using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ObjectsforModelling.Startup))]
namespace ObjectsforModelling
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
