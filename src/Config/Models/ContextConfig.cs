
namespace Ollio.Config.Models
{
    public class ContextConfig
    {
        public string Prefix { get; set; } = "/";
        public string Server { get; set; } = "";
        public int Tick { get; set; } = 10;
        public string Token { get; set; }
    }
}