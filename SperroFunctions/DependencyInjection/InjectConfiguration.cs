
namespace SperroFunctions.DependencyInjection
{
    using System;
    using Microsoft.Azure.WebJobs.Host.Config;
    using Microsoft.Extensions.DependencyInjection;
    using SperroFunctions.Interfaces;
    using SperroFunctions.StorageRepository;

    namespace DependencyInjection
    {
        public class InjectConfiguration : IExtensionConfigProvider
        {
            private IServiceProvider _serviceProvider;

            public void Initialize(ExtensionConfigContext context)
            {
                var services = new ServiceCollection();
                RegisterServices(services);
                _serviceProvider = services.BuildServiceProvider(true);

                context
                    .AddBindingRule<InjectAttribute>()
                    .BindToInput<dynamic>(i => _serviceProvider.GetRequiredService(i.Type));
            }
            private void RegisterServices(IServiceCollection services)
            {
                services.AddSingleton<IGameRepository, GameRepository>();
                services.AddSingleton<IPrizeRepository, PrizeRepository>();
                services.AddSingleton<ISponsorRepository, SponsorRepository>();
                services.AddSingleton<ICustomerRepository, CustomerRepository>();
            }
        }
    }
}
