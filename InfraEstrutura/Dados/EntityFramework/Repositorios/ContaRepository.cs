using Amf.PeladaFC.DomainModel.Core;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel;
using System;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Repositorios
{
    public class ContaRepository : Repository<Conta, ContaEntity, Guid>, IContaRepository
    {
        public ContaRepository(PeladaFCContexto contexto) : base(contexto)
        {
        }
    }
}
