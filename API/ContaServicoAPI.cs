using Amf.Framework.Infraestrutura;
using Amf.Framework.ObjetosComuns;
using Amf.PeladaFC.DomainModel.Core;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework;
using System;
using System.Collections.Generic;
using static Amf.PeladaFC.DomainModel.Core.Peladeiro;

namespace Amf.PeladaFC.API
{
    public class ContaServicoAPI : ServicoAPI, IContaServicoAPI
    {
        private readonly IContaRepository _contaRepository;

        public ContaServicoAPI(PeladaFCContexto peladaFCContexto, 
            IContaRepository contaRepository) : base (peladaFCContexto)
        {
            _contaRepository = contaRepository;
        }

        public Guid Criar(Peladeiro peladeiro)
        {
            return CriarInterno(peladeiro, null);
        }

        public Guid Criar(Peladeiro peladeiro, Endereco referencia)
        {
            return CriarInterno(peladeiro, referencia);
        }

        private Guid CriarInterno(Peladeiro peladeiro, Endereco referencia)
        {
            Conta conta = null;

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
