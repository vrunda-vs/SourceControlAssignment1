using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SourceControlAss.Startup))]
namespace SourceControlAss
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
