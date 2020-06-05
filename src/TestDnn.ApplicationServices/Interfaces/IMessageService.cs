using System.Collections.Generic;
using TestDnn.Domain.MainContext;

namespace TestDnn.ApplicationServices.Interfaces
{
    public interface IMessageService
    {
        IEnumerable<TestMessage> GetMessages();
    }
}
