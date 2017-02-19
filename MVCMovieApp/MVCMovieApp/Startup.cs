using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMovieApp.Startup))]
namespace MVCMovieApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
