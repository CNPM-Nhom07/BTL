using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FordBell.StartupOwin))]

namespace FordBell
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
