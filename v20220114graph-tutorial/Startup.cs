using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(v20220114graph_tutorial.Startup))]

namespace v20220114graph_tutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}