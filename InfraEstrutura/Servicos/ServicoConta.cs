using System;
using System.Collections.Generic;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Daos;
using AutoMapper;
using Amf.PeladaFC.DomainModel.Core;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework;
using Amf.PeladaFC.Infraestrutura.Security;

namespace Amf.PeladaFC.Infraestrutura.Servicos
{
    public class ServicoConta : IServicoConta
    {
        IUsuarioDaoEF _usuarioDao;
        IContaDaoEF _contaDao;

        public ServicoConta(IUsuarioDaoEF usuarioDao, IContaDaoEF contaDao)
        {
            _usuarioDao = usuarioDao;
            _contaDao = contaDao;

        }

        public Guid Criar(string nomeCompletoPeladeiro, 
            string email, 
            string senha, 
            byte[] foto = null)
        {
            PeladaFCContexto contexto = new PeladaFCContexto();
            _usuarioDao.SetContexto(contexto);
            _contaDao.SetContexto(contexto);
            UsuarioEntity usuario = new UsuarioEntity() { Email = email, HashSenha = CryptoHelper.GenerateSHA256(senha) };
            _usuarioDao.Salvar(usuario);

            ContaEntity conta = new ContaEntity()
            {
                Foto = foto,
                Peladeiro = Mapper.Map<Peladeiro, PeladeiroEntity>(new Peladeiro(nomeCompletoPeladeiro)),
                Usuario = usuario,
                Id = Guid.NewGuid()
            };

            using (_contaDao)
            {
                _contaDao.Salvar(conta);
                contexto.SaveChanges();
            }

            return conta.Id;
        }
    }
}
