using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cis411_Homework08_Petshop.Startup))]
namespace Cis411_Homework08_Petshop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
