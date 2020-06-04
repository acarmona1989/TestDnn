using DotNetNuke.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using TestDnn.ApplicationServices;
using TestDnn.ApplicationServices.Interfaces;

namespace Planeta.Modules.DNNModule1
{
    public class Startup : IDnnStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IMessageService, MessageService>();
        }
    }
}