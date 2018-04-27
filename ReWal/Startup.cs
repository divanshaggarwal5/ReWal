using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReWal.Startup))]
namespace ReWal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
