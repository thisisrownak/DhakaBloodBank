using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MDRownakJahanTanjil_296627.Startup))]
namespace MDRownakJahanTanjil_296627
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
