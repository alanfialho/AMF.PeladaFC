using Amf.PeladaFC.DomainModel.Core;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel;
using AutoMapper;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Amf.PeladaFC.Infraestrutura.Mappers
{
    internal class DomainToEntityProfile : Profile
    {
        public DomainToEntityProfile()
        {
            CreateMap<Peladeiro, PeladeiroEntity>();
            CreateMap<IQueryable<Peladeiro>, IQueryable<PeladeiroEntity>>();
            CreateMap<Posicao, PosicaoEntity>();
            CreateMap<IQueryable<Posicao>, IQueryable<PosicaoEntity>>();
            CreateMap<Conta, ContaEntity>();
            CreateMap<IQueryable<Conta>, IQueryable<ContaEntity>>();
        }
    }
}
