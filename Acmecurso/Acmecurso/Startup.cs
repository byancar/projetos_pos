using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Acmecurso.Startup))]
namespace Acmecurso
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
