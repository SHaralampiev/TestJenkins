using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMvcTest.Startup))]
namespace WebMvcTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
