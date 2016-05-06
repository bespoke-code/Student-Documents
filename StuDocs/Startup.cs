using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StuDocs.Startup))]
namespace StuDocs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
