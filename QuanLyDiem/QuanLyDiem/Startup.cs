using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuanLyDiem.Startup))]
namespace QuanLyDiem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
