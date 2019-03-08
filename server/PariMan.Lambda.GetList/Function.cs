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

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param Name="input"></param>
        /// <param Name="context"></param>
        /// <returns></returns>
        public async Task<PariResponse<List<PariItem>>> FunctionHandler(object input, ILambdaContext context)
        {
            var serviceProvider = ServiceCollectionFactory.AddPariDependencies(x => x.AddSingleton<IPariList, Pari>());
            var app = serviceProvider.GetService<IRun>();
            var handler = serviceProvider.GetService<IPariList>();

            return await app.Run(handler.Get);
        }
    }
}
