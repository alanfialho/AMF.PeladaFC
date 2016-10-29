namespace WSPeladaFC.Models
{
    public class SucessoResposta : Resposta
    {
        private static int _codigo = 0;
        private static string _mensagem = "Parabens! a operação foi executada com sucesso!";

        public SucessoResposta() : base(_codigo, _mensagem)
        {

        }

        public SucessoResposta(object dados) : base(_codigo, _mensagem, dados)
        {

        }
    }
}