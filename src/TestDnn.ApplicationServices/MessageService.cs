using TestDnn.ApplicationServices.Interfaces;

namespace TestDnn.ApplicationServices
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello World!";
        }
    }
}
