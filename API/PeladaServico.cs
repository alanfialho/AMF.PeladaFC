using System;
using Amf.Framework.ObjetosComuns;
using Amf.PeladaFC.DomainModel.Core;
using Amf.Framework.Infraestrutura;

namespace Amf.PeladaFC.API
{
    public class PeladaServico : Servico, IPeladaServico
    {
        private readonly IPeladaRepository _peladaRepository;
        private readonly IPeladeiroRepository _peladeiroRepository;

        public PeladaServico(IUnitOfWork unitOfWork, 
            IPeladaRepository peladaRepository, 
            IPeladeiroRepository peladeiroRepository) : base(unitOfWork)
        {
            _peladaRepository = peladaRepository;
            _peladeiroRepository = peladeiroRepository;
        }

        public void Criar(Endereco local, DateTime inicio, string titulo, Guid peladeiroId)
        {
            Peladeiro peladeiro = _peladeiroRepository.ObterPorId(peladeiroId);

            if (peladeiro == null)
                throw new PeladeiroNaoExistenteException("o peladeiro não existe");

            Pelada novaPelada = Pelada.Criar(local, 
                inicio, 
                Administrador.TornarAdministrador(peladeiro), 
                titulo);

            using (_unitOfWork)
            {
                _peladaRepository.Salvar(novaPelada);
                _unitOfWork.FinalizarTransacao();
            }
            
        }
    }
}
