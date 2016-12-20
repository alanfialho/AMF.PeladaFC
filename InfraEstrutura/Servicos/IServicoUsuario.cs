namespace Amf.PeladaFC.Infraestrutura.Servicos
{
    public interface IServicoUsuario
    {
        int Criar(string email, string senha);
    }
}
