using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(winform.Startup))]
namespace winform
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
