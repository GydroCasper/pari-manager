using Amazon.Lambda.Core;
using PariService.Dto;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace PariMan.Lambda.GetPari
{
    public class Function
    {

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="id"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public PariItem FunctionHandler(object id, ILambdaContext context)
        {
            return new PariItem { Name = "Наебнуть СБТ"};
        }
    }
}
