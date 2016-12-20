using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Daos;
using Amf.PeladaFC.Infraestrutura.Servicos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amf.PeladaFC.APITests
{
    [TestClass]
    public class ServicoContaTests
    {
        [TestMethod()]
        public void CriarContaTests()
        {
            IServicoConta servico = new ServicoConta(new UsuarioDaoEF(), new ContaDaoEF());
            servico.Criar("alan", "alan@alan.com", "15031991");
        }
    }
}
