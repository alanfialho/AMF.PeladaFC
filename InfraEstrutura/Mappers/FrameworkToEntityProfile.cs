using Amf.Framework.ObjetosComuns;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel;
using AutoMapper;

namespace Amf.PeladaFC.Infraestrutura.Mappers
{
    internal class FrameworkToEntityProfile : Profile
    {
        public FrameworkToEntityProfile()
        {
            CreateMap<Endereco, EnderecoEntity>();
        }
    }
}
