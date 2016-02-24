using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureADDemo.Startup))]
namespace AzureADDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
