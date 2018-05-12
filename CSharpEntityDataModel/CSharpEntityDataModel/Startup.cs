using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSharpEntityDataModel.Startup))]
namespace CSharpEntityDataModel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
