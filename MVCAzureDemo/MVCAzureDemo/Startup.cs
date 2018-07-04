using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAzureDemo.Startup))]
namespace MVCAzureDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
