using System;
using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Microsoft.Extensions.DependencyInjection;
using PariManager.Code;
using PariManager.Interfaces;
using PariService.Code;
using PariService.Interfaces;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace PariManager
{
    public class Function
    {
        public async Task<object> FunctionHandler(object input, ILambdaContext context)
        {
            var serviceProvider = BuildServiceProvider();

            return await serviceProvider.GetService<IGet>().Get();
        }

        private static IServiceProvider BuildServiceProvider()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddScoped<IGet, App>();
            serviceCollection.AddSingleton<IPariList, Pari>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
