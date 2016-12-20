using System.Linq;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Daos
{
    public interface IDao<TENTITY, CP>
        where TENTITY : class
    {
        void Atualizar(TENTITY entity);

        void Deletar(TENTITY entity);

        TENTITY ObterPorId(CP id);

        IQueryable<TENTITY> ObterTodos();

        void Salvar(TENTITY entity);
       
    }
}
