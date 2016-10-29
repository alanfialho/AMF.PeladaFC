using Amf.Framework.ObjetosComuns;
using Amf.PeladaFC.API;
using Amf.PeladaFC.DomainModel.Core;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Repositorios;
using System;
using System.Web.Http;
using WSPeladaFC.Models;

namespace WSPeladaFC.Controllers
{
    [RoutePrefix("api/Conta")]
    public class ContaController : ApiController
    {
        private IContaServicoAPI _servico;

        public ContaController()
        {
            PeladaFCContexto contexto = new PeladaFCContexto();
            _servico = new ContaServicoAPI(contexto, new ContaRepositoryEF(contexto));
        }

        [Route("Criar")]
        [HttpPost]
        public Resposta Criar(ContaDTO conta) {

            try
            {
                return new SucessoResposta(_servico.Criar(
                    conta.NomeCompletoPeladeiro, 
                    conta.PosicoesPeladeiro, 
                    conta.Referencia
                ));
            }
            catch (Exception)
            {
                return new ErroResposta();
            }
        }
    }
}
