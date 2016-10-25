using Amf.Framework.ObjetosComuns;
using Amf.PeladaFC.DomainModel.Core;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Repositorios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Amf.PeladaFC.API.Tests
{
    [TestClass()]
    public class ContaServicoTests
    {
        [TestMethod()]
        public void ContaServicoCriarTest()
        {
            
            PeladaFCContexto contexto = new PeladaFCContexto();
            IContaServicoAPI servico = new ContaServicoAPI(contexto, new ContaRepository(contexto));
            Peladeiro peladeiro = new Peladeiro("alan test", new HashSet<Posicao>() { new Posicao("QL", "Qualquer", Posicao.SALAO) });
            Endereco endereco = new Endereco("test", "1", "81021-180", "vila rosaria", "sao paulo", new Estado("SP", "São Paulo"));
            servico.Criar(peladeiro, endereco);
        }
    }
}