using Amf.PeladaFC.Infraestrutura.Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amf.PeladaFC.APITests
{
    [TestClass()]
    public sealed class Initializer
    {
        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
            AutoMapperConfig.RegisterMappings();
        }
    }
}
