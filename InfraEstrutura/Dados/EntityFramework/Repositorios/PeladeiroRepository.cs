﻿using Amf.PeladaFC.DomainModel.Core;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Repositorios
{
    public class PeladeiroRepository : Repository<Peladeiro, PeladeiroEntity, int>, IPeladeiroRepository
    {
        public PeladeiroRepository(PeladaFCContexto contexto) : base(contexto)
        {
        }
    }
}
