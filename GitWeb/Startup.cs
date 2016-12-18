using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitWeb.Startup))]
namespace GitWeb
{
       
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }

        public void GitT(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        public void GitN(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        public void GitM(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

    }
}
