using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sample_MVC5.Startup))]
namespace Sample_MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
