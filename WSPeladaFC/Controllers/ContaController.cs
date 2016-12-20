using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Daos;
using Amf.PeladaFC.Infraestrutura.Servicos;
using System;
using System.Web.Http;
using WSPeladaFC.Models;

namespace WSPeladaFC.Controllers
{
    [RoutePrefix("api/Conta")]
    public class ContaController : ApiController
    {
        private IServicoConta _servico;

        public ContaController()
        {
            _servico = new ServicoConta(new UsuarioDaoEF(), new ContaDaoEF());
        }

        [Route("Criar")]
        [HttpPost]
        public IHttpActionResult Criar([FromBody] ContaDTO dto) {

            try
            {
                return Ok(new { Id = _servico.Criar(dto.NomeCompletoPeladeiro, dto.Email, dto.Senha, dto.Foto) });
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
