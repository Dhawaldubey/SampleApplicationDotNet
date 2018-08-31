using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleApplicationDotNet.Startup))]
namespace SampleApplicationDotNet
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
