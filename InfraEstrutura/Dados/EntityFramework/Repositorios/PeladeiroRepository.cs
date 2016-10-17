using Amf.PeladaFC.DomainModel.Core;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel;
using AutoMapper;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Repositorios
{
    public class PeladeiroRepository : Repository<Peladeiro, PeladeiroEntity, Guid>, IPeladeiroRepository
    {
        public PeladeiroRepository(PeladaFCContexto contexto) : base(contexto)
        {
        }
    }
}
