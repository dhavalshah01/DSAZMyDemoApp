using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyDemoApp.Startup))]
namespace MyDemoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
