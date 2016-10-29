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

        public ContaServicoAPI(PeladaFCContexto contexto, IContaRepository contaRepository):base(contexto)
        {
            _contaRepository = contaRepository;
        }

        public Guid Criar(string nomeCompletoPeladeiro, ICollection<Posicao> posicoesPeladeiro, Endereco referencia = null)
        {
            return CriarInterno(nomeCompletoPeladeiro, posicoesPeladeiro, referencia);
        }

        private Guid CriarInterno(string nomeCompletoPeladeiro, ICollection<Posicao> posicoesPeladeiro, Endereco referencia)
        {
            Conta conta = null;
            Peladeiro peladeiro = new Peladeiro(nomeCompletoPeladeiro, posicoesPeladeiro); 

            if (referencia != null)   
                conta = ContaFactory.CriarContaComReferencia(peladeiro, referencia);
            else
                conta = ContaFactory.CriarConta(peladeiro);
            
            using (_contexto)
            {
                _contaRepository.Salvar(conta);
                _contexto.SaveChanges();
            }

            return conta.Id;
        }

    }
}
