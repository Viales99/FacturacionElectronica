using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacturaElectronica.UI.Startup))]
namespace FacturaElectronica.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
