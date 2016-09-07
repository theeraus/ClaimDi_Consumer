using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Consumer.Web.TH.Startup))]
namespace Consumer.Web.TH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
