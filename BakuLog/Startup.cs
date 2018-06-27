using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BakuLog.Startup))]
namespace BakuLog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
