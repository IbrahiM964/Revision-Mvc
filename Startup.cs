using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RevisionMVCENTF.Startup))]
namespace RevisionMVCENTF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
