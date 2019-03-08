using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Microsoft.Extensions.DependencyInjection;
using PariMan.Lambda.GetList.Code;
using PariMan.Lambda.GetList.Interfaces;
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
        public async Task<List<PariItem>> FunctionHandler(object input, ILambdaContext context)
        {
            var serviceProvider = BuildServiceProvider();

            return await serviceProvider.GetService<IRun>().Run();
        }

        private static IServiceProvider BuildServiceProvider()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<IPariList, Pari>();
            serviceCollection.AddScoped<IRun, App>();

            serviceCollection.AddPariDependencies();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
