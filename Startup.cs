using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lesson08EF.Startup))]
namespace Lesson08EF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // ConfigureAuth(app);
        }
    }
}
