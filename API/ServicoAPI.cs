using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework;
using System.Data.Entity;

namespace Amf.PeladaFC.API
{
    public class ServicoAPI
    {
        protected DbContext _contexto;

        public ServicoAPI(DbContext contexto)
        {
            _contexto = contexto;
        }

    }
}
