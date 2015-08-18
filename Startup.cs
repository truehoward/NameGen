using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NameGen.Startup))]
namespace NameGen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
