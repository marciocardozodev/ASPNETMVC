using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoTesteMVC.Startup))]
namespace ProjetoTesteMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
