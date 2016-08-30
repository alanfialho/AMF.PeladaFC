using Amf.PeladaFC.DomainModel.Core;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel;
using System;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Repositorios
{
    public class PeladaRepository : Repository<PeladaFCContexto, Pelada, PeladaEntity, Guid>, IPeladaRepository
    {
        
    }
}
