using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bookshelf1.Startup))]
namespace Bookshelf1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
