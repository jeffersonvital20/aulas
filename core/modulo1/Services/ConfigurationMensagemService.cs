using Microsoft.Extensions.Configuration;

namespace modulo1.Services
{
    public class ConfigurationMensagemService : IMensagemService
    {
        private IConfiguration _config;
        public ConfigurationMensagemService(IConfiguration config)
        {
            _config = config;
        }
        public string getMensagem()
        {
            return _config["Mensagem"];
        }
    }
}