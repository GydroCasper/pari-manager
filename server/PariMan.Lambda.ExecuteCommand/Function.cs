using System;
using System.Net;
using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using PariService.Helpers;
using PariService.Interfaces;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace PariMan.Lambda.ExecuteCommand
{
    public class Function
    {
        public async Task<PariResponse<Guid>> FunctionHandler(Command input, ILambdaContext context)
        {
            try
            {
                var serviceProvider = ServiceCollectionFactory.AddPariDependencies(x => x.AddTransient(typeof(ICommandHandler), input.Name.GetHandler()));
                var app = serviceProvider.GetService<IRun>();
                var handler = serviceProvider.GetService<ICommandHandler>();

                return await app.Run(handler.Handle, input.Body, context.AwsRequestId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"message: {ex.Message}\r\n command: {JsonConvert.SerializeObject(input)}\r\n stackTrace: {ex.StackTrace}");

                return new PariResponse<Guid>
                {
                    Status = HttpStatusCode.InternalServerError,
                    Body = default,
                    ErrorMessage = $"Internal Server Error. Request Id: {context.AwsRequestId}",
                    RequestId = context.AwsRequestId
                };
            }
        }
    }
}
