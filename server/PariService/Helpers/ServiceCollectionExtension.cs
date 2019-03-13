using System;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PariService.Code;
using PariService.Database;
using PariService.Interfaces;

namespace PariService.Helpers
{
    public static class ServiceCollectionFactory
    {
        public static IServiceProvider AddPariDependencies(Action<IServiceCollection> registerDependencies)
        {
            var services = new ServiceCollection();

            services.AddSingleton<ILogger, Logger>();
            services.AddScoped<IRun, App>();

            services.AddEntityFrameworkNpgsql();
            services.AddDbContext<PariDbContext>();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            var configuration = BuildConfiguration();
            services.AddScoped(sp => configuration);
            services.Configure<AppSettings>(configuration);

            services.AddOptions();

            registerDependencies(services);

            return services.BuildServiceProvider();
        }

        private static IConfiguration BuildConfiguration()
        {
            return new ConfigurationBuilder()
                .AddSystemsManager("/pari-manager")
                .Build();
        }
    }
}