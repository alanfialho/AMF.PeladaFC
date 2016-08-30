using Amf.PeladaFC.DomainModel.Core;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel;
using AutoMapper;
using System.Linq;

namespace Amf.PeladaFC.Infraestrutura.Mappers
{
    internal class DomainToEntityProfile : Profile
    {
        public DomainToEntityProfile()
        {
            CreateMap<Peladeiro, PeladeiroEntity>();
            CreateMap<IQueryable<Peladeiro>, IQueryable<PeladeiroEntity>>();
        }
    }
}
