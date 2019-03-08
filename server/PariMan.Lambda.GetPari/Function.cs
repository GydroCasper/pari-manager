using System;
using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Microsoft.Extensions.DependencyInjection;
using PariMan.Lambda.GetPari.Code;
using PariMan.Lambda.GetPari.Interfaces;
using PariService.Code;
using PariService.Dto;
using PariService.Helpers;
using PariService.Interfaces;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace PariMan.Lambda.GetPari
{
    public class Function
    {
        public async Task<PariItem> FunctionHandler(PariItem item, ILambdaContext context)
        {
            var serviceProvider = BuildServiceProvider();

            return await serviceProvider.GetService<IRun>().Run(item?.Id);
        }

        private static IServiceProvider BuildServiceProvider()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<IPari, Pari>();
            serviceCollection.AddScoped<IRun, App>();

            serviceCollection.AddPariDependencies();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
