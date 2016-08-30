using Amf.Framework.Utilitarios;

namespace Amf.PeladaFC.DomainModel.Core
{
    public class ConviteStatus : Enumeracao
    {
        public static readonly ConviteStatus Aceito = new ConviteStatus(1, "Aceito");
        public static readonly ConviteStatus Pendente = new ConviteStatus(2, "Pendente");
        public static readonly ConviteStatus Recusado = new ConviteStatus(3, "Recusado");

        private ConviteStatus(int valor, string descricao) : base(valor, descricao)
        {
        }
    }
}