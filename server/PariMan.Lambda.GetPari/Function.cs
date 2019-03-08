using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Microsoft.Extensions.DependencyInjection;
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
        public async Task<PariResponse<PariItem>> FunctionHandler(PariItem item, ILambdaContext context)
        {
            var serviceProvider = ServiceCollectionFactory.AddPariDependencies(x => x.AddSingleton<IPari, Pari>());
            var app = serviceProvider.GetService<IRun>();
            var handler = serviceProvider.GetService<IPari>();

            return await app.Run(handler.Get, item?.Id);
        }
    }
}
