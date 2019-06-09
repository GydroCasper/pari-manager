using System.Collections.Generic;
using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Microsoft.Extensions.DependencyInjection;
using PariService.Code;
using PariService.Dto;
using PariService.Helpers;
using PariService.Interfaces;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace PariMan.Lambda.GetList
{
    public class Function
    {
        private readonly IRun _app;
        private readonly IPariList _handler;

        public Function()
        {
            var serviceProvider = ServiceCollectionFactory.AddPariDependencies(x =>
            {

                x.AddSingleton<IPariList, Pari>();
                x.AddSingleton<IAttitude, Attitude>();
            });

            _app = serviceProvider.GetService<IRun>();
            _handler = serviceProvider.GetService<IPariList>();
        }

        public async Task<PariResponse<List<PariItem>>> FunctionHandler(object input, ILambdaContext context)
        {
            return await _app.Run(_handler.Get, context.AwsRequestId);
        }
    }
}
