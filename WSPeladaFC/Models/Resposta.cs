namespace WSPeladaFC.Models
{
    public abstract class Resposta 
    {
        private int _codigo;
        private string _mensagem;
        private object _dados;

        public int Codigo { get { return _codigo; } }
        public string Mensagem { get { return _mensagem; } }
        public object Dados { get { return _dados; } }

        protected Resposta(int codigo, string mensagem, object dados)
        {
            _codigo = codigo;
            _mensagem = mensagem;
            _dados = dados;
        }

        protected Resposta(int codigo, string mensagem)
        {
            _codigo = codigo;
            _mensagem = mensagem;
        }
    }
}