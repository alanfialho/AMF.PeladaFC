using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Daos;
using Amf.PeladaFC.Infraestrutura.Servicos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amf.PeladaFC.APITests
{
    [TestClass]
    public class ServicoUsuarioTests
    {
        [TestMethod]
        public void ServicoUsuarioCriarTest()
        {
            IServicoUsuario servico = new ServicoUsuario(new UsuarioDaoEF());
            servico.Criar("alan@alan.com", "alan");
        }
    }
}
