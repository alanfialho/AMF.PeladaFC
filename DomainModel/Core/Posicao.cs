using Amf.Framework.DDDConcepts;

namespace Amf.PeladaFC.DomainModel.Core
{
    public class Posicao : ValueObject<Posicao>
    {
        public static readonly string CAMPO = "campo";
        public static readonly string SALAO = "salao";

        private readonly string _codigo;
        private readonly string _nome;
        //TODO: esta podendo inserir qualquer string
        private readonly string _tipoPosicao;

        public string Nome
        {
            get { return _nome; }
        }
        public string Codigo
        {
            get { return _codigo; }
        }
        public string TipoPosicao
        {
            get { return _tipoPosicao; }
        }

        public Posicao(string codigo, string nome, string tipoPosicao)
        {
            _codigo = codigo;
            _nome = nome;
            _tipoPosicao = tipoPosicao;
        }

    }
}