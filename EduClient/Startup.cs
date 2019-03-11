using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EduClient.Startup))]
namespace EduClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
