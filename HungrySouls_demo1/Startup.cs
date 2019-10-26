using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HungrySouls_demo1.Startup))]
namespace HungrySouls_demo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
            //public void Configuration(IAppBuilder app)
          //  {
         //       app.MapSignalR();
           // }
        

    }
}
