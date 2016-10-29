namespace WSPeladaFC.Models
{
    public class ErroResposta : Resposta
    {
        private static int _codigo = 1;
        private static string _mensagem = "Ops! Houve um erro desconhecido ao processar a operação!";
        private int _codigoRazao;
        private string _mensagemRazao;


        public ErroResposta() : base(_codigo, _mensagem)
        {

        }

        public ErroResposta(int codigoRazao, string mensagemRazao) : base(_codigo, _mensagem)
        {
            _codigoRazao = codigoRazao;
            _mensagemRazao = mensagemRazao;       
        }

    }
}