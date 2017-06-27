using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_ASP_MVC_Practice.Startup))]
namespace _ASP_MVC_Practice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
