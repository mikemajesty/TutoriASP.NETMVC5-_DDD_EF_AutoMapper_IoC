using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoModelo.MVC.Startup))]
namespace ProjetoModelo.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
