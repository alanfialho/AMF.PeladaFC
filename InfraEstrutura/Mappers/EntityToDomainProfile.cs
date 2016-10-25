using Amf.PeladaFC.DomainModel.Core;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel;
using AutoMapper;
using System.Linq;

namespace Amf.PeladaFC.Infraestrutura.Mappers
{
    internal class EntityToDomainProfile : Profile
    {
        public EntityToDomainProfile()
        {
            CreateMap<PeladeiroEntity, Peladeiro>();
            CreateMap<IQueryable<PeladeiroEntity>, IQueryable<Peladeiro>>();
            CreateMap<PosicaoEntity, Posicao>();
            CreateMap<IQueryable<PosicaoEntity>, IQueryable<Posicao>>();
            CreateMap<ContaEntity, Conta>();
            CreateMap<IQueryable<ContaEntity>, IQueryable<Conta>>();
        }
    }
}