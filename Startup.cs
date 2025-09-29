using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Railway_Reservation_System.Startup))]
namespace Railway_Reservation_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
