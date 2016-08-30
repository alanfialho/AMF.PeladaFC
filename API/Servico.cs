using Amf.Framework.Infraestrutura;

namespace Amf.PeladaFC.API
{
    public abstract class Servico
    {
        protected IUnitOfWork _unitOfWork;

        protected Servico(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
