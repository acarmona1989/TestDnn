using DotNetNuke.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using TestDnn.ApplicationServices;
using TestDnn.ApplicationServices.Interfaces;
using TestDnn.Domain.MainContext;
using TestDnn.Infrastructure.Data;

namespace Planeta.Modules.DNNModule1
{
    public class Startup : IDnnStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<TestDnn.Domain.Interfaces.IRepository<Message>, MessageRepository>();
            services.AddTransient<IMessageService, MessageService>();
        }
    }
}