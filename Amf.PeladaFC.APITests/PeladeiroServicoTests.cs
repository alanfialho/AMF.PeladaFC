using Amf.Framework.ObjetosComuns;
using Amf.PeladaFC.DomainModel.Core;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Repositorios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Amf.PeladaFC.API.Tests
{
    [TestClass()]
    public class ContaServicoTests
    {
        private class ContaDTO
        {
            public string NomeCompletoPeladeiro { get; set; }
            public ICollection<Posicao> PosicoesPeladeiro { get; set; }
            public Endereco Referencia { get; set; }
        }

        [TestMethod()]
        public void ContaServicoCriarTest()
        {
            
            PeladaFCContexto contexto = new PeladaFCContexto();
            IContaServicoAPI servico = new ContaServicoAPI(contexto, new ContaRepositoryEF(contexto));
            Endereco endereco = new Endereco("test", "1", "81021-180", "vila rosaria", "sao paulo", new Estado("SP", "São Paulo"));
            servico.Criar("alan test", new HashSet<Posicao>() { new Posicao("QL", "Qualquer", Posicao.SALAO) }, endereco);
        }

        [TestMethod()]
        public void GerarJson()
        {
            HashSet<Posicao> posicoes = new HashSet<Posicao>() { new Posicao("QL", "Qualquer", "Campo") };
            ContaDTO conta = new ContaDTO() { NomeCompletoPeladeiro = "alan", PosicoesPeladeiro = posicoes }; 
            var output = JsonConvert.SerializeObject(conta);
            Console.Write(output); 
        }
    }
}