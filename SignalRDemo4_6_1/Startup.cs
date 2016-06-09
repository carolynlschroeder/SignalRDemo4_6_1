using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRDemo4_6_1.Startup))]
namespace SignalRDemo4_6_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            app.MapSignalR();
            //GlobalHost.HubPipeline.RequireAuthentication();
        }
    }
}
