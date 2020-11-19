using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aut.Startup))]
namespace Aut
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
