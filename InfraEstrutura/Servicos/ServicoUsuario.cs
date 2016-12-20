using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.Daos;
using Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel;
using Amf.PeladaFC.Infraestrutura.Security;
using System.Security.Cryptography;
using System.Text;

namespace Amf.PeladaFC.Infraestrutura.Servicos
{
    public class ServicoUsuario : IServicoUsuario
    {
        private IUsuarioDaoEF _dao;

        public ServicoUsuario(IUsuarioDaoEF dao)
        {
            _dao = dao;
        }

        public int Criar(string email, string senha)
        {
            UsuarioEntity usuario = new UsuarioEntity() { Email = email, HashSenha = CryptoHelper.GenerateSHA256(senha) };

            PeladaFCContexto contexto = new PeladaFCContexto();
            _dao.SetContexto(contexto);

            using (_dao)
            {
                _dao.Salvar(usuario);
                contexto.SaveChanges();
                
            }

            return usuario.Id;
        }
    }
}
