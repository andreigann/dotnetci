using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersSite.Startup))]
namespace PersSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
