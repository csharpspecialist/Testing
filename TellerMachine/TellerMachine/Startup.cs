using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TellerMachine.Startup))]
namespace TellerMachine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
