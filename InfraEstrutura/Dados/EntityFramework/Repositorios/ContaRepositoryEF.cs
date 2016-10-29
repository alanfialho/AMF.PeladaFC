using Amf.PeladaFC.DomainModel.Core;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel;
using System;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Repositorios
{
    public class ContaRepositoryEF : RepositoryEF<Conta, ContaEntity, Guid>, IContaRepository
    {
        public ContaRepositoryEF(PeladaFCContexto contexto) : base(contexto)
        {
        }
    }
}
