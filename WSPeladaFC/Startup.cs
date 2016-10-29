using Amf.PeladaFC.Infraestrutura.Mappers;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WSPeladaFC.Startup))]

namespace WSPeladaFC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
            AutoMapperConfig.RegisterMappings();
        }
    }
}
