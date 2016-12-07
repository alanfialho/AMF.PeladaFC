using Amf.Framework.ObjetosComuns;
using Amf.PeladaFC.DomainModel.Core;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework;
using System;
using System.Collections.Generic;

namespace Amf.PeladaFC.API
{
    public class ContaServicoAPI : ServicoAPI, IContaServicoAPI
    {
        private readonly IContaRepository _contaRepository;

        public ContaServicoAPI(PeladaFCContexto contexto, IContaRepository contaRepository) : base(contexto)
        {
            _contaRepository = contaRepository;
        }

        public Guid Criar(string nomeCompletoPeladeiro, 
            ICollection<Posicao> posicoesPeladeiro = null, 
            Endereco referencia = null,
            byte[] foto = null)
        {
            return CriarInterno(nomeCompletoPeladeiro, posicoesPeladeiro, referencia, foto);
        }

        private Guid CriarInterno(string nomeCompletoPeladeiro, ICollection<Posicao> posicoesPeladeiro , Endereco referencia, byte[] foto)
        {
            Peladeiro peladeiro = posicoesPeladeiro == null ? new Peladeiro(nomeCompletoPeladeiro) : 
                new Peladeiro(nomeCompletoPeladeiro, posicoesPeladeiro);

            Conta conta = referencia == null ? ContaFactory.CriarConta(peladeiro) : 
                ContaFactory.CriarContaComReferencia(peladeiro, referencia);

            conta.Foto = foto;
            
            using (_contexto)
            {
                _contaRepository.Salvar(conta);
                _contexto.SaveChanges();
            }

            return conta.Id;
        }

    }
}
