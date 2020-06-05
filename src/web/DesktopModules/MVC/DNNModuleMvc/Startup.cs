using DotNetNuke.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using TestDnn.ApplicationServices;
using TestDnn.ApplicationServices.Interfaces;
using TestDnn.Domain.Interfaces;
using TestDnn.Domain.MainContext;
using TestDnn.Infrastructure.Data;

namespace Planeta.Modules.DNNModuleMvc
{
    public class Startup : IDnnStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped(_ => new MainDbContext("testConnection"));
            services.AddTransient<IUnitOfWork, MainUnitOfWork>();
            services.AddTransient<IRepository<TestMessage>, GenericRepository<TestMessage>>();
            services.AddTransient<IMessageService, MessageService>();
        }
    }
}