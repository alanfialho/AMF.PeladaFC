using System.Data.Entity;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Daos
{
    public class UsuarioDaoEF : DaoEF<UsuarioEntity, int>, IUsuarioDaoEF
    {
       
    }
}
