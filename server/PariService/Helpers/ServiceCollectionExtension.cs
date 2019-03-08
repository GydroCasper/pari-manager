using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PariService.Code;
using PariService.Database;
using PariService.Interfaces;

namespace PariService.Helpers
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddPariDependencies(this IServiceCollection services)
        {
            services.AddSingleton<ILogger, Logger>();

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

            return services;
        }

        private static IConfiguration BuildConfiguration()
        {
            return new ConfigurationBuilder()
                .AddSystemsManager("/pari-manager")
                .Build();
        }
    }
}