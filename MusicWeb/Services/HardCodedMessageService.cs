namespace MusicWeb.Services
{
    public class HardCodedMessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Message from Hardcoded Message Service";
        }
    }
}