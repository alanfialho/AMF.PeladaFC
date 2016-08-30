using Amf.PeladaFC.DomainModel.Core;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel;
using AutoMapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Repositorios
{
    public class PeladeiroRepository : Repository<PeladaFCContexto, Peladeiro, PeladeiroEntity, Guid>, IPeladeiroRepository
    {
        public List<Peladeiro> ObterPorCriterios(string nomeCompleto = "", string apelido = "", string email = "")
        {
            throw new NotImplementedException();
        }

        public Peladeiro ObterPorEmail(string email)
        {
            ApplicationUser au = _contexto.Users.Where(p => p.Email.Equals(email)).FirstOrDefault();
            return Mapper.Map<PeladeiroEntity, Peladeiro>(au.PeladeiroEntity);
        }

        public void SalvarConvite(Convite convite)
        {
            throw new NotImplementedException();
        }
    }
}
