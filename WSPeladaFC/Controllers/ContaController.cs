using Amf.PeladaFC.API;
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
        public IHttpActionResult Criar([FromBody] ContaDTO dto) {

            try
            {
                return Ok(new { Id = _servico.Criar(dto.NomeCompletoPeladeiro, foto: dto.Foto) });
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
