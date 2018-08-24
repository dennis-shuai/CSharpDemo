using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDemo2.Startup))]
namespace WebDemo2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
