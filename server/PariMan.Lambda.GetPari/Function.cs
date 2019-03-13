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
        private readonly IRun _app;
        private readonly IPari _handler;

        public Function()
        {
            var serviceProvider = ServiceCollectionFactory.AddPariDependencies(x => x.AddSingleton<IPari, Pari>());
            _app = serviceProvider.GetService<IRun>();
            _handler = serviceProvider.GetService<IPari>();
        }

        public async Task<PariResponse<PariItem>> FunctionHandler(PariItem item, ILambdaContext context)
        {
            return await _app.Run(_handler.Get, item?.Id, context.AwsRequestId);
        }
    }
}
