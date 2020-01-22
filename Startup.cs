using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ew774515_MIS4800.Startup))]
namespace ew774515_MIS4800
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
