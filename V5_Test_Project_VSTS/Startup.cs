using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(V5_Test_Project_VSTS.Startup))]
namespace V5_Test_Project_VSTS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
