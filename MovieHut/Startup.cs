using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieHut.Startup))]
namespace MovieHut
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
