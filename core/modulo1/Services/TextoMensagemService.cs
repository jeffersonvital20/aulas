namespace modulo1.Services
{
    public class TextoMensagemService : IMensagemService
    {
        public string getMensagem()
        {
           // throw new System.Exception("Testando variaveis de ambiente");

            return "Texto de mensagem";
        }
    }
}