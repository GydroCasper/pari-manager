using System.Threading.Tasks;
using Amazon.Lambda.Core;
using PariService.Code;
using PariService.Dto;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace PariManager
{
    public class Function
    {
        public async Task<object> FunctionHandler(object input, ILambdaContext context)
        {
            var query = new Query();
            return await query.Execute((QueryDto)input);
        }
    }
}
