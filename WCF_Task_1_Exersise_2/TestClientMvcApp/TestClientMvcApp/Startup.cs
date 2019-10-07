using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestClientMvcApp.Startup))]
namespace TestClientMvcApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
