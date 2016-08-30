using Amf.Framework.Infraestrutura;
using Amf.PeladaFC.DomainModel.Core;
using System;

namespace Amf.PeladaFC.API
{
    public class PeladeiroServico : Servico, IPeladeiroServico
    {
        private readonly IPeladeiroRepository _peladeiroRepository;

        public PeladeiroServico(IUnitOfWork unitOfWork, IPeladeiroRepository peladeiroRepository): base(unitOfWork)
        {
            _peladeiroRepository = peladeiroRepository;
        }       
    }
}
